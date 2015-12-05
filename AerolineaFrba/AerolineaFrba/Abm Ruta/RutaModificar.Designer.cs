namespace AerolineaFrba.Abm_Ruta
{
    partial class RutaModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RutaModificar));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_codRuta = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_precioPasaje = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_precioKG = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox_servicios = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boton_Agregar_Ciudad = new System.Windows.Forms.Button();
            this.errorProvider_ciudadOrigen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_ciudadDestino = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Servicios = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_precioKg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_precioPasaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_codRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_precioPasaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_precioKG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ciudadOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ciudadDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Servicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_precioKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_precioPasaje)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown_codRuta);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDown_precioPasaje);
            this.groupBox2.Controls.Add(this.numericUpDown_precioKG);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkedListBox_servicios);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.boton_Agregar_Ciudad);
            this.groupBox2.Location = new System.Drawing.Point(30, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 226);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Ruta";
            // 
            // numericUpDown_codRuta
            // 
            this.numericUpDown_codRuta.Location = new System.Drawing.Point(128, 27);
            this.numericUpDown_codRuta.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_codRuta.Name = "numericUpDown_codRuta";
            this.numericUpDown_codRuta.Size = new System.Drawing.Size(153, 20);
            this.numericUpDown_codRuta.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Código de Ruta:";
            // 
            // numericUpDown_precioPasaje
            // 
            this.numericUpDown_precioPasaje.DecimalPlaces = 2;
            this.numericUpDown_precioPasaje.Location = new System.Drawing.Point(128, 142);
            this.numericUpDown_precioPasaje.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_precioPasaje.Name = "numericUpDown_precioPasaje";
            this.numericUpDown_precioPasaje.Size = new System.Drawing.Size(153, 20);
            this.numericUpDown_precioPasaje.TabIndex = 18;
            // 
            // numericUpDown_precioKG
            // 
            this.numericUpDown_precioKG.DecimalPlaces = 2;
            this.numericUpDown_precioKG.Location = new System.Drawing.Point(128, 115);
            this.numericUpDown_precioKG.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_precioKG.Name = "numericUpDown_precioKG";
            this.numericUpDown_precioKG.Size = new System.Drawing.Size(153, 20);
            this.numericUpDown_precioKG.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Precio Base Pasaje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio Base Kg:";
            // 
            // checkedListBox_servicios
            // 
            this.checkedListBox_servicios.FormattingEnabled = true;
            this.checkedListBox_servicios.Location = new System.Drawing.Point(128, 57);
            this.checkedListBox_servicios.Name = "checkedListBox_servicios";
            this.checkedListBox_servicios.Size = new System.Drawing.Size(153, 49);
            this.checkedListBox_servicios.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Servicios:";
            // 
            // boton_Agregar_Ciudad
            // 
            this.boton_Agregar_Ciudad.Location = new System.Drawing.Point(294, 177);
            this.boton_Agregar_Ciudad.Name = "boton_Agregar_Ciudad";
            this.boton_Agregar_Ciudad.Size = new System.Drawing.Size(75, 23);
            this.boton_Agregar_Ciudad.TabIndex = 0;
            this.boton_Agregar_Ciudad.Text = "Modificar";
            this.boton_Agregar_Ciudad.UseVisualStyleBackColor = true;
            this.boton_Agregar_Ciudad.Click += new System.EventHandler(this.boton_Agregar_Ciudad_Click);
            // 
            // errorProvider_ciudadOrigen
            // 
            this.errorProvider_ciudadOrigen.ContainerControl = this;
            // 
            // errorProvider_ciudadDestino
            // 
            this.errorProvider_ciudadDestino.ContainerControl = this;
            // 
            // errorProvider_Servicios
            // 
            this.errorProvider_Servicios.ContainerControl = this;
            // 
            // errorProvider_precioKg
            // 
            this.errorProvider_precioKg.ContainerControl = this;
            // 
            // errorProvider_precioPasaje
            // 
            this.errorProvider_precioPasaje.ContainerControl = this;
            // 
            // RutaModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 275);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RutaModificar";
            this.Text = "Rutas - Modificar";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_codRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_precioPasaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_precioKG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ciudadOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ciudadDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Servicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_precioKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_precioPasaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox_servicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boton_Agregar_Ciudad;
        private System.Windows.Forms.NumericUpDown numericUpDown_precioPasaje;
        private System.Windows.Forms.NumericUpDown numericUpDown_precioKG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_codRuta;
        private System.Windows.Forms.ErrorProvider errorProvider_ciudadOrigen;
        private System.Windows.Forms.ErrorProvider errorProvider_ciudadDestino;
        private System.Windows.Forms.ErrorProvider errorProvider_Servicios;
        private System.Windows.Forms.ErrorProvider errorProvider_precioKg;
        private System.Windows.Forms.ErrorProvider errorProvider_precioPasaje;


    }
}