using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DARKCODE
{
    class Conexion
    {
        MySqlConnection miConexion;
        bool blConexionEstablecida = false;
        string server = "";
        string database = "";
        string password = "";
        string uid = "";

        public Conexion(string strServer, string strDatabase, string strUID, string strPassword)
        {
            this.server = strServer;
            this.database = strDatabase;
            this.uid = strUID;
            this.password = strPassword;
            string connectionString = @"server=" + this.server + ";" + "database=" +
                this.database + ";" + "uid=" + this.uid + ";" + "pwd=" + this.password + ";";
            this.miConexion = new MySqlConnection(connectionString);
            Abrir();
            if (!(miConexion.State == ConnectionState.Open))
            {
                return;
            }
            blConexionEstablecida = true;
        }
        public void Ejecutar(string query)
        {
            Abrir();
            if (!(miConexion.State == ConnectionState.Open))
            {
                return;
            }
            MySqlCommand cmd;
            cmd = new MySqlCommand(query, miConexion);
            cmd.ExecuteNonQuery();
            Cerrar();
        }

        public DataTable ObtenerTabla(string query)
        {
            Abrir();
            DataTable table = new DataTable();
            if (!(miConexion.State == ConnectionState.Open))
            {
                return table;
            }
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, miConexion);
            try
            {
                adapter.Fill(table);
            }
            catch
            {

            }
            finally
            {
                Cerrar();
            }
            return table;
        }
        public void Abrir()
        {
            try
            {
                if (miConexion.State != ConnectionState.Open)
                {
                    miConexion.Open();
                }
            }
            catch { }
        }
        public void Cerrar()
        {
            if (miConexion.State == ConnectionState.Open)
            {
                miConexion.Close();
            }
        }
        public bool ConexionEstablecida()
        {
            return blConexionEstablecida;
        }
    }
}
