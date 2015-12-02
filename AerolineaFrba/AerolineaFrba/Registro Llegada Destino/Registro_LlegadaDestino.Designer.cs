namespace AerolineaFrba.Registro_Llegada_Destino
{
    partial class Registro_LlegadaDestino
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_LlegadaDestino));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_AeropuertoSalida = new System.Windows.Forms.ComboBox();
            this.comboBox_AeropuertoLlegada = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_LlegadaEstimadaAeronave = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_SalidaAeronave = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_TipoServicio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_ModeloAeronave = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_MatriculaAeronave = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_BuscarAeronave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_matricula = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider_buscarAeronave = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_buscarAeronave)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aeropuerto Salida: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Aeropuerto Llegada:";
            // 
            // comboBox_AeropuertoSalida
            // 
            this.comboBox_AeropuertoSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AeropuertoSalida.FormattingEnabled = true;
            this.comboBox_AeropuertoSalida.Location = new System.Drawing.Point(144, 58);
            this.comboBox_AeropuertoSalida.Name = "comboBox_AeropuertoSalida";
            this.comboBox_AeropuertoSalida.Size = new System.Drawing.Size(100, 21);
            this.comboBox_AeropuertoSalida.Sorted = true;
            this.comboBox_AeropuertoSalida.TabIndex = 1;
            this.comboBox_AeropuertoSalida.SelectedIndexChanged += new System.EventHandler(this.comboBox_AeropuertoSalida_SelectedIndexChanged);
            // 
            // comboBox_AeropuertoLlegada
            // 
            this.comboBox_AeropuertoLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AeropuertoLlegada.FormattingEnabled = true;
            this.comboBox_AeropuertoLlegada.Location = new System.Drawing.Point(411, 58);
            this.comboBox_AeropuertoLlegada.Name = "comboBox_AeropuertoLlegada";
            this.comboBox_AeropuertoLlegada.Size = new System.Drawing.Size(100, 21);
            this.comboBox_AeropuertoLlegada.Sorted = true;
            this.comboBox_AeropuertoLlegada.TabIndex = 2;
            this.comboBox_AeropuertoLlegada.SelectedIndexChanged += new System.EventHandler(this.comboBox_AeropuertoLlegada_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_LlegadaEstimadaAeronave);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label_SalidaAeronave);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_TipoServicio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_ModeloAeronave);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_MatriculaAeronave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(43, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Aeronave";
            // 
            // label_LlegadaEstimadaAeronave
            // 
            this.label_LlegadaEstimadaAeronave.AutoSize = true;
            this.label_LlegadaEstimadaAeronave.Location = new System.Drawing.Point(371, 44);
            this.label_LlegadaEstimadaAeronave.Name = "label_LlegadaEstimadaAeronave";
            this.label_LlegadaEstimadaAeronave.Size = new System.Drawing.Size(115, 13);
            this.label_LlegadaEstimadaAeronave.TabIndex = 9;
            this.label_LlegadaEstimadaAeronave.Text = "**hh:mm dd/mm/yyyy**";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fecha Llegada estimada:";
            // 
            // label_SalidaAeronave
            // 
            this.label_SalidaAeronave.AutoSize = true;
            this.label_SalidaAeronave.Location = new System.Drawing.Point(99, 44);
            this.label_SalidaAeronave.Name = "label_SalidaAeronave";
            this.label_SalidaAeronave.Size = new System.Drawing.Size(115, 13);
            this.label_SalidaAeronave.TabIndex = 7;
            this.label_SalidaAeronave.Text = "**hh:mm dd/mm/yyyy**";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha Salida:";
            // 
            // label_TipoServicio
            // 
            this.label_TipoServicio.AutoSize = true;
            this.label_TipoServicio.Location = new System.Drawing.Point(433, 20);
            this.label_TipoServicio.Name = "label_TipoServicio";
            this.label_TipoServicio.Size = new System.Drawing.Size(61, 13);
            this.label_TipoServicio.TabIndex = 5;
            this.label_TipoServicio.Text = "**Servicio**";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo Servicio:";
            // 
            // label_ModeloAeronave
            // 
            this.label_ModeloAeronave.AutoSize = true;
            this.label_ModeloAeronave.Location = new System.Drawing.Point(262, 20);
            this.label_ModeloAeronave.Name = "label_ModeloAeronave";
            this.label_ModeloAeronave.Size = new System.Drawing.Size(58, 13);
            this.label_ModeloAeronave.TabIndex = 3;
            this.label_ModeloAeronave.Text = "**Modelo**";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Modelo Aeronave:";
            // 
            // label_MatriculaAeronave
            // 
            this.label_MatriculaAeronave.AutoSize = true;
            this.label_MatriculaAeronave.Location = new System.Drawing.Point(81, 20);
            this.label_MatriculaAeronave.Name = "label_MatriculaAeronave";
            this.label_MatriculaAeronave.Size = new System.Drawing.Size(47, 13);
            this.label_MatriculaAeronave.TabIndex = 1;
            this.label_MatriculaAeronave.Text = "**NRO**";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Matrícula:";
            // 
            // button_BuscarAeronave
            // 
            this.button_BuscarAeronave.Enabled = false;
            this.button_BuscarAeronave.Location = new System.Drawing.Point(411, 86);
            this.button_BuscarAeronave.Name = "button_BuscarAeronave";
            this.button_BuscarAeronave.Size = new System.Drawing.Size(100, 23);
            this.button_BuscarAeronave.TabIndex = 3;
            this.button_BuscarAeronave.Text = "Buscar Aeronave";
            this.button_BuscarAeronave.UseVisualStyleBackColor = true;
            this.button_BuscarAeronave.Click += new System.EventHandler(this.button_BuscarAeronave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_matricula);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_BuscarAeronave);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox_AeropuertoLlegada);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox_AeropuertoSalida);
            this.groupBox2.Location = new System.Drawing.Point(43, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 117);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda";
            // 
            // comboBox_matricula
            // 
            this.comboBox_matricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_matricula.FormattingEnabled = true;
            this.comboBox_matricula.Location = new System.Drawing.Point(144, 22);
            this.comboBox_matricula.Name = "comboBox_matricula";
            this.comboBox_matricula.Size = new System.Drawing.Size(100, 21);
            this.comboBox_matricula.Sorted = true;
            this.comboBox_matricula.TabIndex = 0;
            this.comboBox_matricula.SelectedIndexChanged += new System.EventHandler(this.comboBox_matricula_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 263);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2015, 12, 26, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Fecha Llegada a Destino:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Registrar Llegada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider_buscarAeronave
            // 
            this.errorProvider_buscarAeronave.ContainerControl = this;
            this.errorProvider_buscarAeronave.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_buscarAeronave.Icon")));
            this.errorProvider_buscarAeronave.RightToLeft = true;
            // 
            // Registro_LlegadaDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_LlegadaDestino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Llegada a Destino";
            this.Load += new System.EventHandler(this.Registro_LlegadaDestino_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_buscarAeronave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_AeropuertoSalida;
        private System.Windows.Forms.ComboBox comboBox_AeropuertoLlegada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_LlegadaEstimadaAeronave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_SalidaAeronave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_TipoServicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_ModeloAeronave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_MatriculaAeronave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_BuscarAeronave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_matricula;
        private System.Windows.Forms.ErrorProvider errorProvider_buscarAeronave;
    }
}