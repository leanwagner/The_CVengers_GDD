namespace AerolineaFrba.Compra
{
    partial class Compra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_origen = new System.Windows.Forms.ComboBox();
            this.comboBox_destino = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad Destino:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_destino);
            this.groupBox1.Controls.Add(this.comboBox_origen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Vuelos";
            // 
            // comboBox_origen
            // 
            this.comboBox_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_origen.FormattingEnabled = true;
            this.comboBox_origen.Location = new System.Drawing.Point(147, 54);
            this.comboBox_origen.Name = "comboBox_origen";
            this.comboBox_origen.Size = new System.Drawing.Size(121, 21);
            this.comboBox_origen.TabIndex = 2;
            this.comboBox_origen.SelectedIndexChanged += new System.EventHandler(this.comboBox_origen_SelectedIndexChanged);
            // 
            // comboBox_destino
            // 
            this.comboBox_destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_destino.FormattingEnabled = true;
            this.comboBox_destino.Location = new System.Drawing.Point(418, 54);
            this.comboBox_destino.Name = "comboBox_destino";
            this.comboBox_destino.Size = new System.Drawing.Size(121, 21);
            this.comboBox_destino.TabIndex = 3;
            this.comboBox_destino.SelectedIndexChanged += new System.EventHandler(this.comboBox_destino_SelectedIndexChanged);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 408);
            this.Controls.Add(this.groupBox1);
            this.Name = "Compra";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_destino;
        private System.Windows.Forms.ComboBox comboBox_origen;
    }
}