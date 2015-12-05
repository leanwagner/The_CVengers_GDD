namespace AerolineaFrba.Abm_Aeronave
{
    partial class BajaAeronave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BajaAeronave));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_reinc = new System.Windows.Forms.DateTimePicker();
            this.radioButton_bajaTotal = new System.Windows.Forms.RadioButton();
            this.radioButton_bajaTaller = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker_reinc);
            this.groupBox1.Controls.Add(this.radioButton_bajaTotal);
            this.groupBox1.Controls.Add(this.radioButton_bajaTaller);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Opción";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dar de Baja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha de reincorporación:";
            // 
            // dateTimePicker_reinc
            // 
            this.dateTimePicker_reinc.Location = new System.Drawing.Point(285, 41);
            this.dateTimePicker_reinc.Name = "dateTimePicker_reinc";
            this.dateTimePicker_reinc.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_reinc.TabIndex = 2;
            // 
            // radioButton_bajaTotal
            // 
            this.radioButton_bajaTotal.AutoSize = true;
            this.radioButton_bajaTotal.Location = new System.Drawing.Point(49, 79);
            this.radioButton_bajaTotal.Name = "radioButton_bajaTotal";
            this.radioButton_bajaTotal.Size = new System.Drawing.Size(78, 17);
            this.radioButton_bajaTotal.TabIndex = 1;
            this.radioButton_bajaTotal.TabStop = true;
            this.radioButton_bajaTotal.Text = "Fin vida útil";
            this.radioButton_bajaTotal.UseVisualStyleBackColor = true;
            // 
            // radioButton_bajaTaller
            // 
            this.radioButton_bajaTaller.AutoSize = true;
            this.radioButton_bajaTaller.Location = new System.Drawing.Point(49, 44);
            this.radioButton_bajaTaller.Name = "radioButton_bajaTaller";
            this.radioButton_bajaTaller.Size = new System.Drawing.Size(71, 17);
            this.radioButton_bajaTaller.TabIndex = 0;
            this.radioButton_bajaTaller.TabStop = true;
            this.radioButton_bajaTaller.Text = "Baja taller";
            this.radioButton_bajaTaller.UseVisualStyleBackColor = true;
            this.radioButton_bajaTaller.CheckedChanged += new System.EventHandler(this.radioButton_bajaTaller_CheckedChanged);
            // 
            // BajaAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 187);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BajaAeronave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja Aeronave";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_bajaTotal;
        private System.Windows.Forms.RadioButton radioButton_bajaTaller;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_reinc;
    }
}