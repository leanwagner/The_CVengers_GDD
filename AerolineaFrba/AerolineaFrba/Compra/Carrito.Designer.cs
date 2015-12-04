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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_telefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dni)).BeginInit();
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
            this.button_confirmarItems.Location = new System.Drawing.Point(369, 184);
            this.button_confirmarItems.Name = "button_confirmarItems";
            this.button_confirmarItems.Size = new System.Drawing.Size(143, 23);
            this.button_confirmarItems.TabIndex = 3;
            this.button_confirmarItems.Text = "Confirmar Ítems";
            this.button_confirmarItems.UseVisualStyleBackColor = true;
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
            this.button_eliminarItem.Location = new System.Drawing.Point(369, 138);
            this.button_eliminarItem.Name = "button_eliminarItem";
            this.button_eliminarItem.Size = new System.Drawing.Size(143, 23);
            this.button_eliminarItem.TabIndex = 4;
            this.button_eliminarItem.Text = "Eliminar Ítem";
            this.button_eliminarItem.UseVisualStyleBackColor = true;
            this.button_eliminarItem.Click += new System.EventHandler(this.button_eliminarItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown_telefono);
            this.groupBox2.Controls.Add(this.numericUpDown_dni);
            this.groupBox2.Controls.Add(this.button_terminarCompra);
            this.groupBox2.Controls.Add(this.dateTimePicker_nacimiento);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_apellido);
            this.groupBox2.Controls.Add(this.textBox_nombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Nombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(35, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 216);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso datos Comprador";
            // 
            // numericUpDown_telefono
            // 
            this.numericUpDown_telefono.Location = new System.Drawing.Point(504, 78);
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
            this.numericUpDown_dni.ValueChanged += new System.EventHandler(this.numericUpDown_dni_ValueChanged);
            // 
            // button_terminarCompra
            // 
            this.button_terminarCompra.Location = new System.Drawing.Point(583, 173);
            this.button_terminarCompra.Name = "button_terminarCompra";
            this.button_terminarCompra.Size = new System.Drawing.Size(141, 37);
            this.button_terminarCompra.TabIndex = 14;
            this.button_terminarCompra.Text = "Terminar Compra";
            this.button_terminarCompra.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_nacimiento
            // 
            this.dateTimePicker_nacimiento.Location = new System.Drawing.Point(464, 119);
            this.dateTimePicker_nacimiento.Name = "dateTimePicker_nacimiento";
            this.dateTimePicker_nacimiento.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker_nacimiento.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de nacimiento:";
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
            this.label4.Location = new System.Drawing.Point(446, 80);
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
            this.textBox_apellido.Location = new System.Drawing.Point(554, 34);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(170, 20);
            this.textBox_apellido.TabIndex = 5;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(334, 34);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(161, 20);
            this.textBox_nombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(281, 37);
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
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Carrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito de Compras";
            this.Activated += new System.EventHandler(this.Carrito_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_telefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_aPasaje;
        private System.Windows.Forms.Button button_aEncomienda;
        private System.Windows.Forms.Button button_confirmarItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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

    }
}