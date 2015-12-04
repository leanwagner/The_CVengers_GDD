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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown_telefono = new NumericUpDownModified();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.numericUpDown_dni = new NumericUpDownModified();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.button_terminarCompra = new System.Windows.Forms.Button();
            this.button_eliminarItem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_telefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dni)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(58, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 199);
            this.listBox1.TabIndex = 0;
            // 
            // button_aPasaje
            // 
            this.button_aPasaje.Location = new System.Drawing.Point(336, 99);
            this.button_aPasaje.Name = "button_aPasaje";
            this.button_aPasaje.Size = new System.Drawing.Size(143, 23);
            this.button_aPasaje.TabIndex = 1;
            this.button_aPasaje.Text = "Agregar Pasaje";
            this.button_aPasaje.UseVisualStyleBackColor = true;
            this.button_aPasaje.Click += new System.EventHandler(this.button_aPasaje_Click);
            // 
            // button_aEncomienda
            // 
            this.button_aEncomienda.Location = new System.Drawing.Point(336, 45);
            this.button_aEncomienda.Name = "button_aEncomienda";
            this.button_aEncomienda.Size = new System.Drawing.Size(143, 23);
            this.button_aEncomienda.TabIndex = 2;
            this.button_aEncomienda.Text = "Agregar Encomienda";
            this.button_aEncomienda.UseVisualStyleBackColor = true;
            this.button_aEncomienda.Click += new System.EventHandler(this.button_aEncomienda_Click);
            // 
            // button_confirmarItems
            // 
            this.button_confirmarItems.Location = new System.Drawing.Point(336, 201);
            this.button_confirmarItems.Name = "button_confirmarItems";
            this.button_confirmarItems.Size = new System.Drawing.Size(143, 23);
            this.button_confirmarItems.TabIndex = 3;
            this.button_confirmarItems.Text = "Confirmar Ítems";
            this.button_confirmarItems.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_eliminarItem);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button_confirmarItems);
            this.groupBox1.Controls.Add(this.button_aPasaje);
            this.groupBox1.Controls.Add(this.button_aEncomienda);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 272);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Ítems al carrito";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_terminarCompra);
            this.groupBox2.Controls.Add(this.dateTimePicker_nacimiento);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.numericUpDown_telefono);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_apellido);
            this.groupBox2.Controls.Add(this.textBox_nombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Nombre);
            this.groupBox2.Controls.Add(this.numericUpDown_dni);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(35, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 216);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso datos Comprador";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 9;
            // 
            // numericUpDown_telefono
            // 
            this.numericUpDown_telefono.Location = new System.Drawing.Point(435, 78);
            this.numericUpDown_telefono.Name = "numericUpDown_telefono";
            this.numericUpDown_telefono.Size = new System.Drawing.Size(132, 20);
            this.numericUpDown_telefono.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teléfono:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.textBox_apellido.Location = new System.Drawing.Point(485, 34);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(170, 20);
            this.textBox_apellido.TabIndex = 5;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(265, 34);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(161, 20);
            this.textBox_nombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(212, 37);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre:";
            // 
            // numericUpDown_dni
            // 
            this.numericUpDown_dni.Location = new System.Drawing.Point(58, 37);
            this.numericUpDown_dni.Name = "numericUpDown_dni";
            this.numericUpDown_dni.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_dni.TabIndex = 1;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 12;
            // 
            // dateTimePicker_nacimiento
            // 
            this.dateTimePicker_nacimiento.Location = new System.Drawing.Point(415, 120);
            this.dateTimePicker_nacimiento.Name = "dateTimePicker_nacimiento";
            this.dateTimePicker_nacimiento.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker_nacimiento.TabIndex = 13;
            // 
            // button_terminarCompra
            // 
            this.button_terminarCompra.Location = new System.Drawing.Point(525, 164);
            this.button_terminarCompra.Name = "button_terminarCompra";
            this.button_terminarCompra.Size = new System.Drawing.Size(141, 37);
            this.button_terminarCompra.TabIndex = 14;
            this.button_terminarCompra.Text = "Terminar Compra";
            this.button_terminarCompra.UseVisualStyleBackColor = true;
            // 
            // button_eliminarItem
            // 
            this.button_eliminarItem.Location = new System.Drawing.Point(336, 146);
            this.button_eliminarItem.Name = "button_eliminarItem";
            this.button_eliminarItem.Size = new System.Drawing.Size(143, 23);
            this.button_eliminarItem.TabIndex = 4;
            this.button_eliminarItem.Text = "Eliminar Ítem";
            this.button_eliminarItem.UseVisualStyleBackColor = true;
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
            this.groupBox1.ResumeLayout(false);
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
        private NumericUpDownModified numericUpDown_dni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private NumericUpDownModified numericUpDown_telefono;
        private System.Windows.Forms.Button button_eliminarItem;
        private System.Windows.Forms.Button button_terminarCompra;
        private System.Windows.Forms.DateTimePicker dateTimePicker_nacimiento;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;

    }
}