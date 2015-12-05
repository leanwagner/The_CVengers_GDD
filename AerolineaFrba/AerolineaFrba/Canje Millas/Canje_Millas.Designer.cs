namespace AerolineaFrba.Canje_Millas
{
    partial class Canje_Millas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Canje_Millas));
            this.label1 = new System.Windows.Forms.Label();
            this.premioCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dniBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.canUpDown = new System.Windows.Forms.NumericUpDown();
            this.canjBoton = new System.Windows.Forms.Button();
            this.nombreCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorDniDup = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNoStock = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPuntos = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dniBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDniDup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // premioCombo
            // 
            this.premioCombo.FormattingEnabled = true;
            this.premioCombo.Location = new System.Drawing.Point(60, 164);
            this.premioCombo.Name = "premioCombo";
            this.premioCombo.Size = new System.Drawing.Size(154, 21);
            this.premioCombo.TabIndex = 2;
            this.premioCombo.SelectedIndexChanged += new System.EventHandler(this.premioCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Premio:";
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(47, 6);
            this.dniBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(100, 20);
            this.dniBox.TabIndex = 0;
            this.dniBox.TextChanged += new System.EventHandler(this.dniBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 126);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "*aca iria la cantidad de millas*";
            this.label12.VisibleChanged += new System.EventHandler(this.label12_VisibleChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Millas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fecha Nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad:";
            // 
            // canUpDown
            // 
            this.canUpDown.Location = new System.Drawing.Point(293, 164);
            this.canUpDown.Name = "canUpDown";
            this.canUpDown.Size = new System.Drawing.Size(48, 20);
            this.canUpDown.TabIndex = 3;
            this.canUpDown.ValueChanged += new System.EventHandler(this.canUpDown_ValueChanged);
            // 
            // canjBoton
            // 
            this.canjBoton.Enabled = false;
            this.canjBoton.Location = new System.Drawing.Point(139, 203);
            this.canjBoton.Name = "canjBoton";
            this.canjBoton.Size = new System.Drawing.Size(75, 23);
            this.canjBoton.TabIndex = 4;
            this.canjBoton.Text = "Canjear";
            this.canjBoton.UseVisualStyleBackColor = true;
            this.canjBoton.Click += new System.EventHandler(this.canjBoton_Click);
            // 
            // nombreCombo
            // 
            this.nombreCombo.FormattingEnabled = true;
            this.nombreCombo.Location = new System.Drawing.Point(220, 5);
            this.nombreCombo.Name = "nombreCombo";
            this.nombreCombo.Size = new System.Drawing.Size(121, 21);
            this.nombreCombo.TabIndex = 1;
            this.nombreCombo.Visible = false;
            this.nombreCombo.SelectedIndexChanged += new System.EventHandler(this.nombreCombo_SelectedIndexChanged);
            this.nombreCombo.VisibleChanged += new System.EventHandler(this.nombreCombo_VisibleChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido:";
            this.label4.Visible = false;
            // 
            // errorDniDup
            // 
            this.errorDniDup.ContainerControl = this;
            this.errorDniDup.Icon = ((System.Drawing.Icon)(resources.GetObject("errorDniDup.Icon")));
            // 
            // errorNoStock
            // 
            this.errorNoStock.ContainerControl = this;
            // 
            // errorPuntos
            // 
            this.errorPuntos.ContainerControl = this;
            // 
            // Canje_Millas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 238);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombreCombo);
            this.Controls.Add(this.canjBoton);
            this.Controls.Add(this.canUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dniBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.premioCombo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Canje_Millas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Canje Millas";
            this.Load += new System.EventHandler(this.Canje_Millas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dniBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDniDup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox premioCombo;
        private System.Windows.Forms.Label label2;
       
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown canUpDown;
        private System.Windows.Forms.Button canjBoton;
        private System.Windows.Forms.ComboBox nombreCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorDniDup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorNoStock;
        private System.Windows.Forms.ErrorProvider errorPuntos;
        private System.Windows.Forms.NumericUpDown dniBox;
    }
}