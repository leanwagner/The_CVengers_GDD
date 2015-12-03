namespace AerolineaFrba.Consulta_Millas
{
    partial class Consulta_Millas
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
            this.dniBox = new System.Windows.Forms.TextBox();
            this.millasLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(59, 6);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(100, 20);
            this.dniBox.TabIndex = 1;
            this.dniBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // millasLabel
            // 
            this.millasLabel.AutoSize = true;
            this.millasLabel.Location = new System.Drawing.Point(173, 22);
            this.millasLabel.Name = "millasLabel";
            this.millasLabel.Size = new System.Drawing.Size(99, 13);
            this.millasLabel.TabIndex = 2;
            this.millasLabel.Text = "*cantidad de millas*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(248, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(59, 32);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 2;
            // 
            // Consulta_Millas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.millasLabel);
            this.Controls.Add(this.dniBox);
            this.Controls.Add(this.label1);
            this.Name = "Consulta_Millas";
            this.Text = "Consulta de millas";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.Label millasLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
    }
}