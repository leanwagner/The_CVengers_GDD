using AerolineaFrba.MyNumericUpDown;
namespace AerolineaFrba.Compra
{
    partial class Carrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_aPasaje = new System.Windows.Forms.Button();
            this.button_aEncomienda = new System.Windows.Forms.Button();
            this.button_confirmarItems = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMonto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_eliminarItem = new System.Windows.Forms.Button();
            this.groupBox_tarjeta = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton_tarjeta = new System.Windows.Forms.RadioButton();
            this.radioButton_efectivo = new System.Windows.Forms.RadioButton();
            this.comboBox_tipoTarjeta = new System.Windows.Forms.ComboBox();
            this.numericUpDown_codigoTarjeta = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown_numeroTarjeta = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.numericUpDown_telefono = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_dni = new System.Windows.Forms.NumericUpDown();
            this.button_terminarCompra = new System.Windows.Forms.Button();
            this.dateTimePicker_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider_dniDup = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_tarjeta.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_codigoTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numeroTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_telefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_dniDup)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(346, 186);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_aPasaje
            // 
            this.button_aPasaje.Location = new System.Drawing.Point(369, 88);
            this.button_aPasaje.Name = "button_aPasaje";
            this.button_aPasaje.Size = new System.Drawing.Size(143, 23);
            this.button_aPasaje.TabIndex = 1;
            this.button_aPasaje.Text = "Agregar Pasaje";
            this.button_aPasaje.UseVisualStyleBackColor = true;
            this.button_aPasaje.Click += new System.EventHandler(this.button_aPasaje_Click);
            // 
            // button_aEncomienda
            // 
            this.button_aEncomienda.Location = new System.Drawing.Point(369, 38);
            this.button_aEncomienda.Name = "button_aEncomienda";
            this.button_aEncomienda.Size = new System.Drawing.Size(143, 23);
            this.button_aEncomienda.TabIndex = 2;
            this.button_aEncomienda.Text = "Agregar Encomienda";
            this.button_aEncomienda.UseVisualStyleBackColor = true;
            this.button_aEncomienda.Click += new System.EventHandler(this.button_aEncomienda_Click);
            // 
            // button_confirmarItems
            // 
            this.button_confirmarItems.Enabled = false;
            this.button_confirmarItems.Location = new System.Drawing.Point(369, 184);
            this.button_confirmarItems.Name = "button_confirmarItems";
            this.button_confirmarItems.Size = new System.Drawing.Size(143, 23);
            this.button_confirmarItems.TabIndex = 3;
            this.button_confirmarItems.Text = "Confirmar Ítems";
            this.button_confirmarItems.UseVisualStyleBackColor = true;
            this.button_confirmarItems.Click += new System.EventHandler(this.button_confirmarItems_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMonto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button_eliminarItem);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button_confirmarItems);
            this.groupBox1.Controls.Add(this.button_aPasaje);
            this.groupBox1.Controls.Add(this.button_aEncomienda);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 289);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Ítems al carrito";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.Location = new System.Drawing.Point(644, 239);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(83, 27);
            this.labelMonto.TabIndex = 7;
            this.labelMonto.Text = "00.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(516, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "TOTAL:  $";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AerolineaFrba.Properties.Resources.carrito;
            this.pictureBox1.Location = new System.Drawing.Point(548, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 188);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button_eliminarItem
            // 
            this.button_eliminarItem.Enabled = false;
            this.button_eliminarItem.Location = new System.Drawing.Point(369, 138);
            this.button_eliminarItem.Name = "button_eliminarItem";
            this.button_eliminarItem.Size = new System.Drawing.Size(143, 23);
            this.button_eliminarItem.TabIndex = 4;
            this.button_eliminarItem.Text = "Eliminar Ítem";
            this.button_eliminarItem.UseVisualStyleBackColor = true;
            this.button_eliminarItem.Click += new System.EventHandler(this.button_eliminarItem_Click);
            // 
            // groupBox_tarjeta
            // 
            this.groupBox_tarjeta.Controls.Add(this.button1);
            this.groupBox_tarjeta.Controls.Add(this.groupBox3);
            this.groupBox_tarjeta.Controls.Add(this.numericUpDown_telefono);
            this.groupBox_tarjeta.Controls.Add(this.numericUpDown_dni);
            this.groupBox_tarjeta.Controls.Add(this.button_terminarCompra);
            this.groupBox_tarjeta.Controls.Add(this.dateTimePicker_nacimiento);
            this.groupBox_tarjeta.Controls.Add(this.textBox2);
            this.groupBox_tarjeta.Controls.Add(this.label6);
            this.groupBox_tarjeta.Controls.Add(this.label5);
            this.groupBox_tarjeta.Controls.Add(this.textBox1);
            this.groupBox_tarjeta.Controls.Add(this.label4);
            this.groupBox_tarjeta.Controls.Add(this.label2);
            this.groupBox_tarjeta.Controls.Add(this.textBox_apellido);
            this.groupBox_tarjeta.Controls.Add(this.textBox_nombre);
            this.groupBox_tarjeta.Controls.Add(this.label3);
            this.groupBox_tarjeta.Controls.Add(this.Nombre);
            this.groupBox_tarjeta.Controls.Add(this.label1);
            this.groupBox_tarjeta.Location = new System.Drawing.Point(12, 307);
            this.groupBox_tarjeta.Name = "groupBox_tarjeta";
            this.groupBox_tarjeta.Size = new System.Drawing.Size(778, 349);
            this.groupBox_tarjeta.TabIndex = 5;
            this.groupBox_tarjeta.TabStop = false;
            this.groupBox_tarjeta.Text = "Ingreso datos Comprador";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Volver a Ítems";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.radioButton_tarjeta);
            this.groupBox3.Controls.Add(this.radioButton_efectivo);
            this.groupBox3.Controls.Add(this.comboBox_tipoTarjeta);
            this.groupBox3.Controls.Add(this.numericUpDown_codigoTarjeta);
            this.groupBox3.Controls.Add(this.dateTimePicker_vencimiento);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.numericUpDown_numeroTarjeta);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.shapeContainer2);
            this.groupBox3.Location = new System.Drawing.Point(26, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 138);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Pago";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(344, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Cuotas:";
            // 
            // radioButton_tarjeta
            // 
            this.radioButton_tarjeta.AutoSize = true;
            this.radioButton_tarjeta.Location = new System.Drawing.Point(24, 31);
            this.radioButton_tarjeta.Name = "radioButton_tarjeta";
            this.radioButton_tarjeta.Size = new System.Drawing.Size(58, 17);
            this.radioButton_tarjeta.TabIndex = 1;
            this.radioButton_tarjeta.TabStop = true;
            this.radioButton_tarjeta.Text = "Tarjeta";
            this.radioButton_tarjeta.UseVisualStyleBackColor = true;
            this.radioButton_tarjeta.CheckedChanged += new System.EventHandler(this.radioButton_tarjeta_CheckedChanged);
            // 
            // radioButton_efectivo
            // 
            this.radioButton_efectivo.AutoSize = true;
            this.radioButton_efectivo.Location = new System.Drawing.Point(24, 96);
            this.radioButton_efectivo.Name = "radioButton_efectivo";
            this.radioButton_efectivo.Size = new System.Drawing.Size(64, 17);
            this.radioButton_efectivo.TabIndex = 0;
            this.radioButton_efectivo.TabStop = true;
            this.radioButton_efectivo.Text = "Efectivo";
            this.radioButton_efectivo.UseVisualStyleBackColor = true;
            this.radioButton_efectivo.CheckedChanged += new System.EventHandler(this.radioButton_tarjeta_CheckedChanged);
            // 
            // comboBox_tipoTarjeta
            // 
            this.comboBox_tipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipoTarjeta.Enabled = false;
            this.comboBox_tipoTarjeta.FormattingEnabled = true;
            this.comboBox_tipoTarjeta.Location = new System.Drawing.Point(151, 30);
            this.comboBox_tipoTarjeta.Name = "comboBox_tipoTarjeta";
            this.comboBox_tipoTarjeta.Size = new System.Drawing.Size(131, 21);
            this.comboBox_tipoTarjeta.TabIndex = 7;
            // 
            // numericUpDown_codigoTarjeta
            // 
            this.numericUpDown_codigoTarjeta.Enabled = false;
            this.numericUpDown_codigoTarjeta.Location = new System.Drawing.Point(415, 62);
            this.numericUpDown_codigoTarjeta.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_codigoTarjeta.Name = "numericUpDown_codigoTarjeta";
            this.numericUpDown_codigoTarjeta.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_codigoTarjeta.TabIndex = 5;
            // 
            // dateTimePicker_vencimiento
            // 
            this.dateTimePicker_vencimiento.Enabled = false;
            this.dateTimePicker_vencimiento.Location = new System.Drawing.Point(288, 98);
            this.dateTimePicker_vencimiento.Name = "dateTimePicker_vencimiento";
            this.dateTimePicker_vencimiento.Size = new System.Drawing.Size(107, 20);
            this.dateTimePicker_vencimiento.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Código de seguridad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(114, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tipo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(214, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Vencimiento:";
            // 
            // numericUpDown_numeroTarjeta
            // 
            this.numericUpDown_numeroTarjeta.Enabled = false;
            this.numericUpDown_numeroTarjeta.Location = new System.Drawing.Point(167, 62);
            this.numericUpDown_numeroTarjeta.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_numeroTarjeta.Name = "numericUpDown_numeroTarjeta";
            this.numericUpDown_numeroTarjeta.Size = new System.Drawing.Size(115, 20);
            this.numericUpDown_numeroTarjeta.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Número:";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(486, 119);
            this.shapeContainer2.TabIndex = 12;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 100;
            this.lineShape1.X2 = 100;
            this.lineShape1.Y1 = 5;
            this.lineShape1.Y2 = 102;
            // 
            // numericUpDown_telefono
            // 
            this.numericUpDown_telefono.Location = new System.Drawing.Point(524, 77);
            this.numericUpDown_telefono.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDown_telefono.Name = "numericUpDown_telefono";
            this.numericUpDown_telefono.Size = new System.Drawing.Size(203, 20);
            this.numericUpDown_telefono.TabIndex = 16;
            // 
            // numericUpDown_dni
            // 
            this.numericUpDown_dni.Location = new System.Drawing.Point(56, 34);
            this.numericUpDown_dni.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_dni.Name = "numericUpDown_dni";
            this.numericUpDown_dni.Size = new System.Drawing.Size(203, 20);
            this.numericUpDown_dni.TabIndex = 15;
            this.numericUpDown_dni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_dni_KeyUp);
            // 
            // button_terminarCompra
            // 
            this.button_terminarCompra.Location = new System.Drawing.Point(586, 226);
            this.button_terminarCompra.Name = "button_terminarCompra";
            this.button_terminarCompra.Size = new System.Drawing.Size(141, 46);
            this.button_terminarCompra.TabIndex = 14;
            this.button_terminarCompra.Text = "Terminar Compra";
            this.button_terminarCompra.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_nacimiento
            // 
            this.dateTimePicker_nacimiento.Location = new System.Drawing.Point(487, 118);
            this.dateTimePicker_nacimiento.Name = "dateTimePicker_nacimiento";
            this.dateTimePicker_nacimiento.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker_nacimiento.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mail:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dirección:";
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Location = new System.Drawing.Point(342, 33);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(170, 20);
            this.textBox_apellido.TabIndex = 5;
            this.textBox_apellido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_dni_KeyUp);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(588, 34);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(161, 20);
            this.textBox_nombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(535, 37);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // errorProvider_dniDup
            // 
            this.errorProvider_dniDup.ContainerControl = this;
            this.errorProvider_dniDup.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_dniDup.Icon")));
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 670);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_tarjeta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Carrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito de Compras";
            this.Activated += new System.EventHandler(this.Carrito_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Carrito_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_tarjeta.ResumeLayout(false);
            this.groupBox_tarjeta.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_codigoTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numeroTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_telefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_dniDup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_aPasaje;
        private System.Windows.Forms.Button button_aEncomienda;
        private System.Windows.Forms.Button button_confirmarItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_tarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre;
     
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
       
        private System.Windows.Forms.Button button_eliminarItem;
        private System.Windows.Forms.Button button_terminarCompra;
        private System.Windows.Forms.DateTimePicker dateTimePicker_nacimiento;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_telefono;
        private System.Windows.Forms.NumericUpDown numericUpDown_dni;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_tarjeta;
        private System.Windows.Forms.RadioButton radioButton_efectivo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_tipoTarjeta;
        private System.Windows.Forms.NumericUpDown numericUpDown_codigoTarjeta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown_numeroTarjeta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_vencimiento;
        private System.Windows.Forms.ErrorProvider errorProvider_dniDup;

    }
}