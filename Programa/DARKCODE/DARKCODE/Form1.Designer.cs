namespace DARKCODE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtErrores = new System.Windows.Forms.RichTextBox();
            this.dgvValores = new System.Windows.Forms.DataGridView();
            this.IDEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtREVERR = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxtTokens = new System.Windows.Forms.RichTextBox();
            this.LineNumberTextBoxToken = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnCargarFuente = new System.Windows.Forms.Button();
            this.btnGuardarFuente = new System.Windows.Forms.Button();
            this.grpArchivos = new System.Windows.Forms.GroupBox();
            this.btnCargarToken = new System.Windows.Forms.Button();
            this.btnGuardarToken = new System.Windows.Forms.Button();
            this.LineNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtConsola = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValores)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpArchivos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtErrores
            // 
            this.txtErrores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtErrores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(90)))), ((int)(((byte)(109)))));
            this.txtErrores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErrores.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrores.ForeColor = System.Drawing.Color.White;
            this.txtErrores.Location = new System.Drawing.Point(33, 606);
            this.txtErrores.Margin = new System.Windows.Forms.Padding(2);
            this.txtErrores.Name = "txtErrores";
            this.txtErrores.ReadOnly = true;
            this.txtErrores.Size = new System.Drawing.Size(737, 314);
            this.txtErrores.TabIndex = 13;
            this.txtErrores.Text = "Lista de errores";
            // 
            // dgvValores
            // 
            this.dgvValores.AllowUserToAddRows = false;
            this.dgvValores.AllowUserToDeleteRows = false;
            this.dgvValores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvValores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvValores.BackgroundColor = System.Drawing.Color.White;
            this.dgvValores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvValores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvValores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEN,
            this.NOMBRE,
            this.Tipo,
            this.VALOR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvValores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvValores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.dgvValores.Location = new System.Drawing.Point(791, 606);
            this.dgvValores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvValores.Name = "dgvValores";
            this.dgvValores.ReadOnly = true;
            this.dgvValores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvValores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvValores.RowHeadersVisible = false;
            this.dgvValores.RowHeadersWidth = 51;
            this.dgvValores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvValores.RowTemplate.Height = 24;
            this.dgvValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvValores.Size = new System.Drawing.Size(552, 314);
            this.dgvValores.TabIndex = 14;
            // 
            // IDEN
            // 
            this.IDEN.HeaderText = "IDEN";
            this.IDEN.MinimumWidth = 6;
            this.IDEN.Name = "IDEN";
            this.IDEN.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "TIPO";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 98);
            this.label1.TabIndex = 15;
            this.label1.Text = "DARKCODE";
            // 
            // txtREVERR
            // 
            this.txtREVERR.Location = new System.Drawing.Point(163, 579);
            this.txtREVERR.Margin = new System.Windows.Forms.Padding(2);
            this.txtREVERR.Name = "txtREVERR";
            this.txtREVERR.Size = new System.Drawing.Size(352, 20);
            this.txtREVERR.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxtTokens);
            this.groupBox2.Controls.Add(this.LineNumberTextBoxToken);
            this.groupBox2.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(788, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 369);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tokens";
            // 
            // rtxtTokens
            // 
            this.rtxtTokens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rtxtTokens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTokens.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.rtxtTokens.ForeColor = System.Drawing.SystemColors.Window;
            this.rtxtTokens.Location = new System.Drawing.Point(41, 31);
            this.rtxtTokens.Name = "rtxtTokens";
            this.rtxtTokens.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtTokens.Size = new System.Drawing.Size(508, 328);
            this.rtxtTokens.TabIndex = 13;
            this.rtxtTokens.Text = "";
            this.rtxtTokens.VScroll += new System.EventHandler(this.rtxtConsola_VScroll);
            this.rtxtTokens.FontChanged += new System.EventHandler(this.rtxtConsola_FontChanged);
            this.rtxtTokens.TextChanged += new System.EventHandler(this.rtxtConsola_TextChanged);
            // 
            // LineNumberTextBoxToken
            // 
            this.LineNumberTextBoxToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LineNumberTextBoxToken.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.LineNumberTextBoxToken.Dock = System.Windows.Forms.DockStyle.Left;
            this.LineNumberTextBoxToken.ForeColor = System.Drawing.Color.Red;
            this.LineNumberTextBoxToken.Location = new System.Drawing.Point(3, 31);
            this.LineNumberTextBoxToken.Margin = new System.Windows.Forms.Padding(2);
            this.LineNumberTextBoxToken.Name = "LineNumberTextBoxToken";
            this.LineNumberTextBoxToken.ReadOnly = true;
            this.LineNumberTextBoxToken.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LineNumberTextBoxToken.Size = new System.Drawing.Size(17, 335);
            this.LineNumberTextBoxToken.TabIndex = 13;
            this.LineNumberTextBoxToken.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLimpiar);
            this.groupBox3.Controls.Add(this.btnEvaluar);
            this.groupBox3.Controls.Add(this.btnCargarFuente);
            this.groupBox3.Controls.Add(this.btnGuardarFuente);
            this.groupBox3.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(36, 493);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(734, 82);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controles del código";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Courier New", 11.25F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Location = new System.Drawing.Point(407, 23);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(123, 38);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.btnEvaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluar.Font = new System.Drawing.Font("Courier New", 11.25F);
            this.btnEvaluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnEvaluar.Location = new System.Drawing.Point(586, 23);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(123, 38);
            this.btnEvaluar.TabIndex = 11;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = false;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click_1);
            // 
            // btnCargarFuente
            // 
            this.btnCargarFuente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.btnCargarFuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarFuente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnCargarFuente.Location = new System.Drawing.Point(209, 25);
            this.btnCargarFuente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarFuente.Name = "btnCargarFuente";
            this.btnCargarFuente.Size = new System.Drawing.Size(123, 36);
            this.btnCargarFuente.TabIndex = 1;
            this.btnCargarFuente.Text = "&Cargar";
            this.btnCargarFuente.UseVisualStyleBackColor = false;
            this.btnCargarFuente.Click += new System.EventHandler(this.btnCargarFuente_Click);
            // 
            // btnGuardarFuente
            // 
            this.btnGuardarFuente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.btnGuardarFuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarFuente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnGuardarFuente.Location = new System.Drawing.Point(26, 25);
            this.btnGuardarFuente.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarFuente.Name = "btnGuardarFuente";
            this.btnGuardarFuente.Size = new System.Drawing.Size(123, 36);
            this.btnGuardarFuente.TabIndex = 0;
            this.btnGuardarFuente.Text = "Guardar";
            this.btnGuardarFuente.UseVisualStyleBackColor = false;
            this.btnGuardarFuente.Click += new System.EventHandler(this.btnGuardarFuente_Click);
            // 
            // grpArchivos
            // 
            this.grpArchivos.Controls.Add(this.btnCargarToken);
            this.grpArchivos.Controls.Add(this.btnGuardarToken);
            this.grpArchivos.Font = new System.Drawing.Font("Courier New", 11.25F);
            this.grpArchivos.ForeColor = System.Drawing.Color.White;
            this.grpArchivos.Location = new System.Drawing.Point(788, 493);
            this.grpArchivos.Margin = new System.Windows.Forms.Padding(2);
            this.grpArchivos.Name = "grpArchivos";
            this.grpArchivos.Padding = new System.Windows.Forms.Padding(2);
            this.grpArchivos.Size = new System.Drawing.Size(555, 82);
            this.grpArchivos.TabIndex = 20;
            this.grpArchivos.TabStop = false;
            this.grpArchivos.Text = "Controles para los tokens";
            // 
            // btnCargarToken
            // 
            this.btnCargarToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.btnCargarToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnCargarToken.Location = new System.Drawing.Point(362, 23);
            this.btnCargarToken.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarToken.Name = "btnCargarToken";
            this.btnCargarToken.Size = new System.Drawing.Size(140, 43);
            this.btnCargarToken.TabIndex = 1;
            this.btnCargarToken.Text = "Cargar &TOKEN";
            this.btnCargarToken.UseVisualStyleBackColor = false;
            this.btnCargarToken.Click += new System.EventHandler(this.btnCargarToken_Click);
            // 
            // btnGuardarToken
            // 
            this.btnGuardarToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.btnGuardarToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnGuardarToken.Location = new System.Drawing.Point(95, 22);
            this.btnGuardarToken.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarToken.Name = "btnGuardarToken";
            this.btnGuardarToken.Size = new System.Drawing.Size(139, 44);
            this.btnGuardarToken.TabIndex = 0;
            this.btnGuardarToken.Text = "&Guardar TOKEN";
            this.btnGuardarToken.UseVisualStyleBackColor = false;
            this.btnGuardarToken.Click += new System.EventHandler(this.btnGuardarToken_Click);
            // 
            // LineNumberTextBox
            // 
            this.LineNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LineNumberTextBox.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.LineNumberTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LineNumberTextBox.ForeColor = System.Drawing.Color.Red;
            this.LineNumberTextBox.Location = new System.Drawing.Point(3, 28);
            this.LineNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LineNumberTextBox.Name = "LineNumberTextBox";
            this.LineNumberTextBox.ReadOnly = true;
            this.LineNumberTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LineNumberTextBox.Size = new System.Drawing.Size(17, 338);
            this.LineNumberTextBox.TabIndex = 12;
            this.LineNumberTextBox.Text = "";
            this.LineNumberTextBox.SelectionChanged += new System.EventHandler(this.LineNumberTextBox_SelectionChanged);
            this.LineNumberTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LineNumberTextBox_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtConsola);
            this.groupBox1.Controls.Add(this.LineNumberTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(33, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 369);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigo";
            // 
            // rtxtConsola
            // 
            this.rtxtConsola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rtxtConsola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtConsola.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtConsola.ForeColor = System.Drawing.SystemColors.Window;
            this.rtxtConsola.Location = new System.Drawing.Point(47, 31);
            this.rtxtConsola.Name = "rtxtConsola";
            this.rtxtConsola.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtConsola.Size = new System.Drawing.Size(679, 328);
            this.rtxtConsola.TabIndex = 13;
            this.rtxtConsola.Text = "";
            this.rtxtConsola.SelectionChanged += new System.EventHandler(this.rtxtConsola_SelectionChanged);
            this.rtxtConsola.VScroll += new System.EventHandler(this.rtxtConsola_VScroll);
            this.rtxtConsola.FontChanged += new System.EventHandler(this.rtxtConsola_FontChanged);
            this.rtxtConsola.TextChanged += new System.EventHandler(this.rtxtConsola_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1364, 931);
            this.Controls.Add(this.grpArchivos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtREVERR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvValores);
            this.Controls.Add(this.txtErrores);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Programa Lexico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvValores)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.grpArchivos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtErrores;
        private System.Windows.Forms.DataGridView dgvValores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtREVERR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox LineNumberTextBoxToken;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCargarFuente;
        private System.Windows.Forms.Button btnGuardarFuente;
        private System.Windows.Forms.GroupBox grpArchivos;
        private System.Windows.Forms.Button btnCargarToken;
        private System.Windows.Forms.Button btnGuardarToken;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.RichTextBox LineNumberTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RichTextBox rtxtConsola;
        private System.Windows.Forms.RichTextBox rtxtTokens;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
    }
}

