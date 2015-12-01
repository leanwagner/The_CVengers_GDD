namespace AerolineaFrba.Abm_Ruta
{
    partial class Abm_Ruta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abm_Ruta));
            this.button_modificarRuta = new System.Windows.Forms.Button();
            this.dataGridView_listadoRutas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_eliminarRuta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox_ciudadDestino = new System.Windows.Forms.ComboBox();
            this.comboBox_ciudadOrigen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox_servicios = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_agregarRuta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listadoRutas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_modificarRuta
            // 
            this.button_modificarRuta.Location = new System.Drawing.Point(208, 226);
            this.button_modificarRuta.Name = "button_modificarRuta";
            this.button_modificarRuta.Size = new System.Drawing.Size(75, 23);
            this.button_modificarRuta.TabIndex = 7;
            this.button_modificarRuta.Text = "Modificar";
            this.button_modificarRuta.UseVisualStyleBackColor = true;
            this.button_modificarRuta.Click += new System.EventHandler(this.boton_Modificar_Click);
            // 
            // dataGridView_listadoRutas
            // 
            this.dataGridView_listadoRutas.AllowUserToAddRows = false;
            this.dataGridView_listadoRutas.AllowUserToDeleteRows = false;
            this.dataGridView_listadoRutas.AllowUserToResizeColumns = false;
            this.dataGridView_listadoRutas.AllowUserToResizeRows = false;
            this.dataGridView_listadoRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listadoRutas.Location = new System.Drawing.Point(16, 43);
            this.dataGridView_listadoRutas.Name = "dataGridView_listadoRutas";
            this.dataGridView_listadoRutas.ReadOnly = true;
            this.dataGridView_listadoRutas.RowHeadersVisible = false;
            this.dataGridView_listadoRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_listadoRutas.ShowEditingIcon = false;
            this.dataGridView_listadoRutas.Size = new System.Drawing.Size(343, 177);
            this.dataGridView_listadoRutas.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_eliminarRuta);
            this.groupBox1.Controls.Add(this.button_modificarRuta);
            this.groupBox1.Controls.Add(this.dataGridView_listadoRutas);
            this.groupBox1.Location = new System.Drawing.Point(85, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 255);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Rutas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_eliminarRuta
            // 
            this.button_eliminarRuta.Location = new System.Drawing.Point(296, 226);
            this.button_eliminarRuta.Name = "button_eliminarRuta";
            this.button_eliminarRuta.Size = new System.Drawing.Size(75, 23);
            this.button_eliminarRuta.TabIndex = 8;
            this.button_eliminarRuta.Text = "Eliminar";
            this.button_eliminarRuta.UseVisualStyleBackColor = true;
            this.button_eliminarRuta.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.comboBox_ciudadDestino);
            this.groupBox2.Controls.Add(this.comboBox_ciudadOrigen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkedListBox_servicios);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_agregarRuta);
            this.groupBox2.Location = new System.Drawing.Point(85, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 241);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear Ruta";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(139, 27);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(153, 20);
            this.numericUpDown3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Código Ruta:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown2.Location = new System.Drawing.Point(139, 186);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(153, 20);
            this.numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(139, 160);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(153, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // comboBox_ciudadDestino
            // 
            this.comboBox_ciudadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ciudadDestino.FormattingEnabled = true;
            this.comboBox_ciudadDestino.Location = new System.Drawing.Point(139, 79);
            this.comboBox_ciudadDestino.Name = "comboBox_ciudadDestino";
            this.comboBox_ciudadDestino.Size = new System.Drawing.Size(153, 21);
            this.comboBox_ciudadDestino.Sorted = true;
            this.comboBox_ciudadDestino.TabIndex = 2;
            this.comboBox_ciudadDestino.SelectedIndexChanged += new System.EventHandler(this.comboBox_ciudadDestino_SelectedIndexChanged);
            // 
            // comboBox_ciudadOrigen
            // 
            this.comboBox_ciudadOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ciudadOrigen.FormattingEnabled = true;
            this.comboBox_ciudadOrigen.Location = new System.Drawing.Point(139, 53);
            this.comboBox_ciudadOrigen.Name = "comboBox_ciudadOrigen";
            this.comboBox_ciudadOrigen.Size = new System.Drawing.Size(153, 21);
            this.comboBox_ciudadOrigen.Sorted = true;
            this.comboBox_ciudadOrigen.TabIndex = 1;
            this.comboBox_ciudadOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBox_ciudadOrigen_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Precio Base Pasaje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio Base Kg:";
            // 
            // checkedListBox_servicios
            // 
            this.checkedListBox_servicios.FormattingEnabled = true;
            this.checkedListBox_servicios.Location = new System.Drawing.Point(139, 105);
            this.checkedListBox_servicios.Name = "checkedListBox_servicios";
            this.checkedListBox_servicios.Size = new System.Drawing.Size(153, 49);
            this.checkedListBox_servicios.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Servicios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ciudad Destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ciudad Origen:";
            // 
            // button_agregarRuta
            // 
            this.button_agregarRuta.Location = new System.Drawing.Point(296, 212);
            this.button_agregarRuta.Name = "button_agregarRuta";
            this.button_agregarRuta.Size = new System.Drawing.Size(75, 23);
            this.button_agregarRuta.TabIndex = 6;
            this.button_agregarRuta.Text = "Agregar";
            this.button_agregarRuta.UseVisualStyleBackColor = true;
            // 
            // Abm_Ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(545, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Abm_Ruta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rutas";
            this.Load += new System.EventHandler(this.Abm_Ruta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listadoRutas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_modificarRuta;
        private System.Windows.Forms.DataGridView dataGridView_listadoRutas;
        private System.Windows.Forms.Button button_eliminarRuta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_agregarRuta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox_servicios;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_ciudadDestino;
        private System.Windows.Forms.ComboBox comboBox_ciudadOrigen;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label6;
    }
}