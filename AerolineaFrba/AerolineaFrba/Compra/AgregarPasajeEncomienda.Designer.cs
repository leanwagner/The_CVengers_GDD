using AerolineaFrba.MyNumericUpDown;
namespace AerolineaFrba.Compra
{
    partial class AgregarPasajeEncomienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPasajeEncomienda));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_piso = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_butacasDisponibles = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_agregarItem = new System.Windows.Forms.Button();
            this.dateTimePicker_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.numericUpDown_telefono = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.numericUpDown_dni = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider_disponibles = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_kilos = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider_nombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_apellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_direccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_dni = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_limpiar = new System.Windows.Forms.Button();
            this.errorProvider_dniDup = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_telefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_disponibles)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kilos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_apellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_direccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_dni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_dniDup)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.comboBox_piso);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox_butacasDisponibles);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Pasaje";
            // 
            // comboBox_piso
            // 
            this.comboBox_piso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_piso.FormattingEnabled = true;
            this.comboBox_piso.Location = new System.Drawing.Point(59, 40);
            this.comboBox_piso.Name = "comboBox_piso";
            this.comboBox_piso.Size = new System.Drawing.Size(121, 21);
            this.comboBox_piso.Sorted = true;
            this.comboBox_piso.TabIndex = 16;
            this.comboBox_piso.SelectedIndexChanged += new System.EventHandler(this.comboBox_piso_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Piso:";
            // 
            // comboBox_butacasDisponibles
            // 
            this.comboBox_butacasDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_butacasDisponibles.Enabled = false;
            this.comboBox_butacasDisponibles.FormattingEnabled = true;
            this.comboBox_butacasDisponibles.Location = new System.Drawing.Point(533, 40);
            this.comboBox_butacasDisponibles.Name = "comboBox_butacasDisponibles";
            this.comboBox_butacasDisponibles.Size = new System.Drawing.Size(121, 21);
            this.comboBox_butacasDisponibles.TabIndex = 3;
            this.comboBox_butacasDisponibles.SelectedIndexChanged += new System.EventHandler(this.comboBox_butacasDisponibles_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Butacas disponibles:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(285, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tipo de butaca:";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.button_limpiar);
            this.groupBox2.Controls.Add(this.button_agregarItem);
            this.groupBox2.Controls.Add(this.dateTimePicker_nacimiento);
            this.groupBox2.Controls.Add(this.textBox_mail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_direccion);
            this.groupBox2.Controls.Add(this.numericUpDown_telefono);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_apellido);
            this.groupBox2.Controls.Add(this.textBox_nombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Nombre);
            this.groupBox2.Controls.Add(this.numericUpDown_dni);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 231);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso datos Cliente";
            // 
            // button_agregarItem
            // 
            this.button_agregarItem.Location = new System.Drawing.Point(568, 175);
            this.button_agregarItem.Name = "button_agregarItem";
            this.button_agregarItem.Size = new System.Drawing.Size(141, 37);
            this.button_agregarItem.TabIndex = 14;
            this.button_agregarItem.Text = "Agregar Pasaje";
            this.button_agregarItem.UseVisualStyleBackColor = true;
            this.button_agregarItem.Click += new System.EventHandler(this.button_agregarItem_Click);
            // 
            // dateTimePicker_nacimiento
            // 
            this.dateTimePicker_nacimiento.Location = new System.Drawing.Point(469, 121);
            this.dateTimePicker_nacimiento.Name = "dateTimePicker_nacimiento";
            this.dateTimePicker_nacimiento.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker_nacimiento.TabIndex = 13;
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(58, 123);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(219, 20);
            this.textBox_mail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mail:";
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(84, 78);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(236, 20);
            this.textBox_direccion.TabIndex = 9;
            // 
            // numericUpDown_telefono
            // 
            this.numericUpDown_telefono.Location = new System.Drawing.Point(469, 79);
            this.numericUpDown_telefono.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDown_telefono.Name = "numericUpDown_telefono";
            this.numericUpDown_telefono.Size = new System.Drawing.Size(151, 20);
            this.numericUpDown_telefono.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dirección:";
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Location = new System.Drawing.Point(530, 35);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(170, 20);
            this.textBox_apellido.TabIndex = 5;
            this.textBox_apellido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_dni_KeyUp);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(283, 35);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(161, 20);
            this.textBox_nombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(230, 38);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre:";
            // 
            // numericUpDown_dni
            // 
            this.numericUpDown_dni.Location = new System.Drawing.Point(55, 34);
            this.numericUpDown_dni.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_dni.Name = "numericUpDown_dni";
            this.numericUpDown_dni.Size = new System.Drawing.Size(134, 20);
            this.numericUpDown_dni.TabIndex = 1;
            this.numericUpDown_dni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_dni_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // errorProvider_disponibles
            // 
            this.errorProvider_disponibles.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.numericUpDown_kilos);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(22, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(726, 119);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Encomienda";
            // 
            // numericUpDown_kilos
            // 
            this.numericUpDown_kilos.Location = new System.Drawing.Point(323, 32);
            this.numericUpDown_kilos.Name = "numericUpDown_kilos";
            this.numericUpDown_kilos.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_kilos.TabIndex = 1;
            this.numericUpDown_kilos.ValueChanged += new System.EventHandler(this.numericUpDown_kilos_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cantidad de kilos a mandar:";
            // 
            // errorProvider_nombre
            // 
            this.errorProvider_nombre.ContainerControl = this;
            // 
            // errorProvider_apellido
            // 
            this.errorProvider_apellido.ContainerControl = this;
            // 
            // errorProvider_direccion
            // 
            this.errorProvider_direccion.ContainerControl = this;
            // 
            // errorProvider_dni
            // 
            this.errorProvider_dni.ContainerControl = this;
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(421, 175);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(141, 37);
            this.button_limpiar.TabIndex = 15;
            this.button_limpiar.Text = "Limpiar Campos";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // errorProvider_dniDup
            // 
            this.errorProvider_dniDup.ContainerControl = this;
            this.errorProvider_dniDup.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_dniDup.Icon")));
            // 
            // AgregarPasajeEncomienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(776, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarPasajeEncomienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Pasaje";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_telefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_disponibles)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kilos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_apellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_direccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_dni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_dniDup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_agregarItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker_nacimiento;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.NumericUpDown numericUpDown_telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.NumericUpDown numericUpDown_dni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_butacasDisponibles;
        private System.Windows.Forms.ComboBox comboBox_piso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider_disponibles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown_kilos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider_nombre;
        private System.Windows.Forms.ErrorProvider errorProvider_apellido;
        private System.Windows.Forms.ErrorProvider errorProvider_direccion;
        private System.Windows.Forms.ErrorProvider errorProvider_dni;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.ErrorProvider errorProvider_dniDup;
    }
}