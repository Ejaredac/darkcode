using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace DARKCODE
{
    public partial class Form1 : Form
    {
        string directorioActual = @"C:\";
        string TOKENSLINEAS = "";
        Conexion con = new Conexion("localhost", "darkcode", "root", "");
        DataTable miMatriz;
        DataTable miGramatica;
        List<Simbolo> Simbolos = new List<Simbolo>();
        public Form1()
        {
            InitializeComponent();
            miMatriz = con.ObtenerTabla("SELECT * FROM matrizdetransicion");
            miGramatica = con.ObtenerTabla("SELECT * FROM `table 2`");
            foreach (DataColumn item in miMatriz.Columns)
            {
                if (item.ColumnName.Length == 2)
                {
                    item.ColumnName = item.ColumnName.Substring(0, 1);
                }
                else if (item.ColumnName.Length == 3)
                {
                    item.ColumnName = cambiar(item.ColumnName);
                }
            }

            //-------------------------Codigo para los numeros
            LineNumberTextBox.Font = rtxtConsola.Font;
            rtxtConsola.Select();
            AddLineNumbers();
            //-------------------------Codigo para los numeros Fin
        }


        //--------------------------------Cargar y guardar documentos-----------------------------------------------------------------------
        void GuardarDocumento(int seccion)
        {
            string strTitulo = "";
            switch (seccion)
            {
                case 0: strTitulo = "Guardar código fuente"; break;
                case 1: strTitulo = "Guardar TOKENS"; break;
                default:
                    break;
            }
            SaveFileDialog objGuardar = new SaveFileDialog();
            objGuardar.Filter = "Documento de texto|*.txt";
            objGuardar.Title = strTitulo;
            objGuardar.FileName = "Sin titulo";
            var resultado = objGuardar.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(objGuardar.FileName);
                switch (seccion)
                {
                    case 0:
                        foreach (object linea in rtxtConsola.Lines) { escribir.WriteLine(linea); }
                        break;
                    case 1:
                        foreach (object linea in rtxtTokens.Lines) { escribir.WriteLine(linea); }
                        break;
                    default:
                        break;
                }

                escribir.Close();
            }
        }

        void CargarDocumento(int seccion)
        {
            string strTitulo = "";
            switch (seccion)
            {
                case 0: strTitulo = "Cargar código fuente"; break;
                case 1: strTitulo = "Cargar TOKENS"; break;
                default:
                    break;
            }
            OpenFileDialog objCargar = new OpenFileDialog();
            objCargar.Filter = "Documento de texto|*.txt";
            objCargar.Title = strTitulo;
            objCargar.FileName = "Sin titulo";
            var resultado = objCargar.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamReader leer = new StreamReader(objCargar.FileName);
                switch (seccion)
                {
                    case 0: strTitulo = rtxtConsola.Text = leer.ReadToEnd(); break;
                    case 1: strTitulo = rtxtTokens.Text = leer.ReadToEnd(); break;
                    default:
                        break;
                }

                leer.Close();
            }
        }


        //--------------------------------Fin Cargar y guardar documentos-----------------------------------------------------------------------

        //-------------------------Codigo para los numeros de linea-------------------------
        public int getWidth()
        {
            int w = 25;
            // get total lines of richTextBox1   
            int line = rtxtConsola.Lines.Length;

            if (line <= 99) { w = 20 + (int)rtxtConsola.Font.Size; }
            else if (line <= 999) { w = 30 + (int)rtxtConsola.Font.Size; }
            else { w = 50 + (int)rtxtConsola.Font.Size; }
            return w;
        }
        public void AddLineNumbers()
        {
            LineNumberTextBox.Clear();
            // create & set Point pt to (0,0)   
            Point pt = new Point(0, 0);
            // get First Index & First Line from richTextBox1   
            int First_Index = rtxtConsola.GetCharIndexFromPosition(pt);
            int First_Line = rtxtConsola.GetLineFromCharIndex(First_Index);

            //Token
            int First_Index_Token = rtxtConsola.GetCharIndexFromPosition(pt);
            int First_Line_Token = rtxtConsola.GetLineFromCharIndex(First_Index);
            // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively   
            pt.X = ClientRectangle.Width; pt.Y = ClientRectangle.Height;
            // get Last Index & Last Line from richTextBox1   
            int Last_Index = rtxtConsola.GetCharIndexFromPosition(pt);
            int Last_Line = rtxtConsola.GetLineFromCharIndex(Last_Index);

            //Token
            int Last_Index_Token = rtxtConsola.GetCharIndexFromPosition(pt);
            int Last_Line_Token = rtxtConsola.GetLineFromCharIndex(Last_Index_Token);

            // set Center alignment to LineNumberTextBox   
            LineNumberTextBox.SelectionAlignment = HorizontalAlignment.Center;
            LineNumberTextBoxToken.SelectionAlignment = HorizontalAlignment.Center;
            // set LineNumberTextBox text to null & width to getWidth() function value   
            LineNumberTextBox.Text = ""; LineNumberTextBox.Width = getWidth();
            //Token
            LineNumberTextBoxToken.Text = ""; LineNumberTextBoxToken.Width = getWidth();

            // now add each line number to LineNumberTextBox upto last line   
            for (int i = First_Line; i <= Last_Line + 1; i++)
            {
                LineNumberTextBox.Text += i + 1 + "\n";
            }
            for (int i = First_Line; i <= Last_Line + 1; i++)
            {
                LineNumberTextBoxToken.Text += i + 1 + "\n";
            }
        }


        void Limpiar()
        {
            rtxtConsola.Clear();
            rtxtTokens.Clear();
            dgvValores.Rows.Clear();
            //dtgTabSimbolos.Rows.Clear();
            rtxtConsola.Enabled = true;
            //intContadorElementos = 0;
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            string tokensGramatica = "";
            rtxtTokens.Clear();
            txtErrores.Clear();
            Simbolos = new List<Simbolo>();
            int ipal = 0;
            int i = 1; 
            foreach (string item in new List<string>(rtxtConsola.Lines))
            {
                string linea = formato(item);
                foreach (string palabra in linea.Split(' '))
                {
                    string nTKN = getTOKEN(palabra);
                    if (nTKN.Contains("ER"))
                    {
                        txtErrores.Text += "[" + nTKN + "]" + MensajeError(nTKN) + " en la linea (" + i + ")";
                        txtErrores.Text += Environment.NewLine; 
                    }
                    else if (nTKN.Equals("IINID") && rtxtTokens.Text.Split(' ')[rtxtTokens.Text.Split(' ').Length - 1].Contains("PTY"))
                        nTKN = getSimboloTOKEN(palabra,nTKN,"");
                    tokensGramatica += ((nTKN.Contains("IINID") ? nTKN : nTKN)) + " ";
                    rtxtTokens.Text += nTKN + " ";
                    ipal++;
                }
                rtxtTokens.Text += Environment.NewLine;
                tokensGramatica += Environment.NewLine;

                i++;
            }
            dgvValores.Rows.Clear();
            foreach (Simbolo item in Simbolos)
            {
                dgvValores.Rows.Add(item.ID, item.Nombre,item.Tipo,item.Valor);
            }
            EvaluarGramatica(tokensGramatica);
        }
        private string formato(String item)
        {
            item = item.Replace("      ", " ");
            item = item.Replace("     ", " ");
            item = item.Replace("    ", " ");
            item = item.Replace("   ", " ");
            item = item.Replace("  ", " ");
            item = item.Replace(" ", " ");
            return item;
        }
        int xClick = 0, yClick = 0;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCodigo();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarCodigo();
        }

        private void EvaluarGramatica(string tokens)
        {
            tokens = tokens.Replace("COM", "");
            tokens = tokens.Replace("    ", " ");
            tokens = tokens.Replace("   ", " ");
            tokens = tokens.Replace("  ", " ");
            TOKENSLINEAS = tokens;
            tokens = tokens.Replace(Environment.NewLine, "");
            string nToken = "";
            //CONVIERTE LAS INSTRUCCIONES
            do
            {
                nToken = tokens;
                tokens = RevGram(tokens);
            } while (nToken != tokens);

            if (tokens != "S ")
            {
                BuscarError();
                tokens = TOKENSLINEAS;
            }
            rtxtTokens.Text = tokens;
        }
        //Evaluacion de los identificadores y su ubicacion
        string getSimboloTOKEN(string nombre,string tipo, string valor)
        {
            string token = "IINID";
            foreach (Simbolo item in Simbolos)
            {
                if (item.Equals(nombre))
                {
                    token = "IINID" + item.ID;
                    return token;
                }
            }
            Simbolo nS = new Simbolo(nombre, Simbolos.Count + 1);
            nS.Tipo = tipo;
            nS.Valor = valor;
            Simbolos.Add(nS);
            return "IINID" + nS.ID;
        }
        //Separacion de cada palabra para que se evaluen los tokens
        string[] getNTOKENS(string tokens)
        {
            List<string> validos = new List<string>();
            string[] argTOKENS = tokens.Split(' ');
            for (int i = 0; i < argTOKENS.Length; i++)
            {
                if (argTOKENS[i] != "")
                {
                    validos.Add(argTOKENS[i]);
                }
            }
            return validos.ToArray();
        }
        string RevGram(string tokens)
        {
            string[] T = getNTOKENS(tokens);
            for (int f = T.Length - 1; f >= 0; f--)
            {
                for (int n = 0; n <= f; n++)
                {
                    foreach (DataRow item in miGramatica.Rows)
                    {
                        int db = 1;
                        for (int i = n; i <= f; i++)
                        {
                            if (item[db].Equals(T[i]))
                            {
                                //MessageBox.Show("DB:" + item[db] + " TK:" + T[i] + " i:" + i + " f:" + f);
                                if (item[db + 1].ToString() == "" && i == f)
                                {
                                    //Coincidio la instruccion
                                    string strT = "";
                                    for (int c = 1; c <= f + 1; c++)
                                    {
                                        if (c < 14)
                                        {
                                            if (item[c].ToString() != "")
                                            {
                                                strT += ((c >= 2) ? " " : "") + item[c];
                                            }
                                        }
                                    }
                                    Regex rgx = new Regex(strT);
                                    tokens = rgx.Replace(tokens, item[0].ToString() + " ", 1);
                                    TOKENSLINEAS = rgx.Replace(TOKENSLINEAS, item[0].ToString() + " ", 1);
                                    tokens = tokens.Replace("  ", " ");
                                    TOKENSLINEAS = TOKENSLINEAS.Replace("  ", " ");
                                    return tokens;
                                }
                                else if (i == f)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                break;
                            }
                            db++;
                        }
                    }
                }
            }
            return tokens;
        }
        string BuscarError()
        {
            Dictionary<string, int> errores = new Dictionary<string, int>();
            string tokens = TOKENSLINEAS;
            txtREVERR.Text = tokens;
            tokens = "";
            int linea;
            for (int x = txtREVERR.Lines.Length - 1; x >= 0; x--)
            {
                linea = x + 1;
                tokens = txtREVERR.Lines[x] + tokens;
                string[] T = getNTOKENS(tokens);
                for (int f = T.Length - 1; f >= 0; f--)
                {
                    int coinci = f - 1;
                    for (int n = 0; n <= f; n++)
                    {
                        foreach (DataRow item in miGramatica.Rows)
                        {
                            int db = 1;
                            for (int i = n; i <= f; i++)
                            {
                                //No hay error
                                if (item[db].Equals(T[i]) && item[db + 1].ToString() != "")
                                {
                                    //Se esperaba un caracter diferente.
                                    if (i == f - 1 && item[db + 1].ToString() != T[f])
                                    {
                                        if (db > coinci)
                                        {
                                            coinci = db;
                                            string strT = "";
                                            for (int c = 1; c <= f; c++)
                                            {
                                                if (c < 14)
                                                {
                                                    if (item[c].ToString() != "")
                                                    {
                                                        strT += ((c >= 2) ? " " : "") + item[c];
                                                    }
                                                }
                                            }
                                            foreach (string line in txtREVERR.Lines)
                                            {
                                                if (line.Equals(strT + " "))
                                                {
                                                    if (item[db + 1].ToString() != "S")
                                                    {
                                                        string msg = "Se esperaba " + Caracter(item[db + 1].ToString()) + " cerca de " + Caracter(T[i]) + " en la linea (" + linea + ")";
                                                        if (!errores.ContainsKey(msg))
                                                            errores.Add(msg, linea);
                                                    }

                                                }
                                            }
                                        }
                                        break;
                                    }
                                }
                                else
                                    break;
                                db++;
                            }
                        }
                    }
                }
            }
            string err = "";
            foreach (KeyValuePair<string, int> g in errores)
            {
                err = g.Key;
                string key = "ERROR: " + err;
                txtErrores.Text += key + Environment.NewLine;
                //break;
            }
            return tokens;
        }
        string Caracter(string token)
        {
            string car = token;
            switch (token)
            {
                
                case "IINID":
                    car = "[Id. Valido]";
                    break;
                case "OPLOGOR":
                    car = "||";
                    break;
                case "OPLOGNOT":
                    car = "!!";
                    break ;
                case "OPREL6":
                    car = "!=";
                    break ;
                case "OPREL3":
                    car = "<";
                    break ;
                case "OPREL4":
                    car= "<=";
                    break;
                case "OPREL2":
                    car = ">=";
                    break;


                
            }
            return car;
        }
        string MensajeError(string error)
        {
            switch (error)
            {
                case "ER01": return ": Identificador no valido";
                case "ER02": return ": Error de cadena";
                case "ER03": return ": Simbolo no valido";
                case "ER04": return ": Error en comentario: Numero";
                case "ER05": return ": Comando inexistente";
                case "ER06": return ": Comando no valido: Numero";
                case "ER07": return ": Comando no valido: Simbolo";
                case "ER08": return ": Error de numero";
                case "ER09": return ": Error de numero";
            }
            return "";
        }
        void GuardarCodigo()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName != "")
                    File.WriteAllText(sfd.FileName, rtxtConsola.Text);
            }
        }
        void CargarCodigo()
        {
            OpenFileDialog fileDial = new OpenFileDialog();
            fileDial.RestoreDirectory = true;
            fileDial.Multiselect = false;
            fileDial.DefaultExt = "txt";
            fileDial.Title = "Cargar Codigo";
            fileDial.ShowDialog();
            if (fileDial.FileName != null)
            {
                if (fileDial.FileName != "")
                {
                    rtxtTokens.Clear();
                    txtErrores.Text = "Lista de errores";
                    directorioActual = fileDial.FileName;
                    rtxtConsola.Text = System.IO.File.ReadAllText(fileDial.FileName);
                }
            }
        }
        //Evalua cada token otenido de la matriz
        string getTOKEN(string strPalabra)
        {
            string token = "";
            int row = 0;
            foreach (char c in (strPalabra + ";").ToCharArray())
            {
                string let = c.ToString();
                if (strPalabra.Contains(";;"))
                    return "ER09";
                let = (let == ";") ? "FDC" : let;
                if (miMatriz.Columns[let] != null)
                {
                    row = int.Parse(miMatriz.Rows[row][let].ToString());
                    if (miMatriz.Rows[row]["CAT"].ToString() != "")
                    {
                        token = miMatriz.Rows[row]["CAT"].ToString();
                        return token;
                    }
                }
            }
            return token;
        }

        private void btnGuardarFuente_Click(object sender, EventArgs e)
        {
            GuardarDocumento(0);
        }

        private void btnCargarFuente_Click(object sender, EventArgs e)
        {
            CargarDocumento(0);
        }

        private void btnGuardarToken_Click(object sender, EventArgs e)
        {
            GuardarDocumento(1);
        }

        private void btnCargarToken_Click(object sender, EventArgs e)
        {
            CargarDocumento(1);
        }

        private void btnEvaluar_Click_1(object sender, EventArgs e)
        {
            string tokensGramatica = "";
            rtxtTokens.Clear();
            txtErrores.Clear();
            Simbolos = new List<Simbolo>();
            int ipal = 0;
            int i = 1;
            foreach (string item in new List<string>(rtxtConsola.Lines))
            {
                string linea = formato(item);
                ipal = 0;
                foreach (string palabra in linea.Split(' '))
                {
                    string nTKN = getTOKEN(palabra);
                    try
                    {

                        if (nTKN.Contains("ER"))
                        {
                            txtErrores.Text += "[" + nTKN + "]" + MensajeError(nTKN) + " en la linea (" + i + ")";
                            txtErrores.Text += Environment.NewLine;
                        }
                        else if (nTKN.Equals("IINID") && rtxtTokens.Lines[i - 1].Split(' ')[rtxtTokens.Lines[i - 1].Split(' ').Length - 2].Contains("PTY") && linea.Split(' ')[ipal + 1].Equals("="))
                            nTKN = getSimboloTOKEN(palabra, linea.Split(' ')[rtxtTokens.Lines[i - 1].Split(' ').Length - 2], linea.Split(' ')[rtxtTokens.Lines[i - 1].Split(' ').Length + 1]);
                        else if (nTKN.Equals("IINID") && linea.Split(' ')[ipal + 1].Equals("="))
                            nTKN = getSimboloTOKEN(palabra, "", linea.Split(' ')[rtxtTokens.Lines[i - 1].Split(' ').Length + 1]);
                        else if (nTKN.Equals("IINID") && rtxtTokens.Lines[i - 1].Split(' ')[rtxtTokens.Lines[i - 1].Split(' ').Length - 2].Contains("PTY"))
                            nTKN = getSimboloTOKEN(palabra, linea.Split(' ')[rtxtTokens.Lines[i - 1].Split(' ').Length - 2], "");
                        else if (nTKN.Equals("IINID"))
                            nTKN = getSimboloTOKEN(palabra, "", "");
                    }
                    finally
                    {

                    }
                    tokensGramatica += ((nTKN.Contains("IINID") ? nTKN : nTKN)) + " ";
                    rtxtTokens.Text += nTKN + " ";
                    ipal++;
                }
                rtxtTokens.Text += Environment.NewLine;
                tokensGramatica += Environment.NewLine;

                i++;
            }
            dgvValores.Rows.Clear();
            foreach (Simbolo item in Simbolos)
            {
                dgvValores.Rows.Add(item.ID, item.Nombre,item.Tipo,item.Valor);
            }
            EvaluarGramatica(tokensGramatica);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        
        private void LineNumberTextBox_SelectionChanged(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void txtConsola_TextChanged(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void txtConsola_FontChanged(object sender, EventArgs e)
        {
            //Ignorar
        }
        
        private void LineNumberTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            rtxtConsola.Select();
            LineNumberTextBox.DeselectAll();
        }

        private void rtxtConsola_VScroll(object sender, EventArgs e)
        {
            LineNumberTextBox.Text = "";
            AddLineNumbers();
            LineNumberTextBox.Invalidate();
        }

        private void rtxtConsola_TextChanged(object sender, EventArgs e)
        {
            if (rtxtConsola.Text == "") { AddLineNumbers(); }
        }

        private void rtxtConsola_FontChanged(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = rtxtConsola.Font;
            rtxtConsola.Select();
            AddLineNumbers();
        }

        private void rtxtConsola_SelectionChanged(object sender, EventArgs e)
        {
            Point pt = rtxtConsola.GetPositionFromCharIndex(rtxtConsola.SelectionStart);
            if (pt.X == 1) { AddLineNumbers(); }
        }

        string cambiar(string col)
        {
            switch (col)
            {
                case "ene":
                    return "ñ";
                case "ENM":
                    return "Ñ";
                case "ADM":
                    return "¡";
                case "PRG":
                    return "¿";
            }
            return col;
        }
    }
}
