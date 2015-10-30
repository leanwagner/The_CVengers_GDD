namespace AerolineaFrba.Generacion_Viaje
{
    partial class Generacion_Viaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generacion_Viaje));
            this.dateTimePicker_Salida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCiudadPartida = new System.Windows.Forms.ComboBox();
            this.comboCiudadDestino = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Llegada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker_Salida
            // 
            this.dateTimePicker_Salida.Location = new System.Drawing.Point(258, 17);
            this.dateTimePicker_Salida.MinDate = new System.DateTime(2015, 10, 30, 20, 22, 14, 0);
            this.dateTimePicker_Salida.Name = "dateTimePicker_Salida";
            this.dateTimePicker_Salida.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Salida.TabIndex = 0;
            this.dateTimePicker_Salida.Value = new System.DateTime(2015, 10, 30, 20, 22, 14, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciudad Partida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ciudad Destino: ";
            // 
            // comboCiudadPartida
            // 
            this.comboCiudadPartida.FormattingEnabled = true;
            this.comboCiudadPartida.Location = new System.Drawing.Point(108, 16);
            this.comboCiudadPartida.Name = "comboCiudadPartida";
            this.comboCiudadPartida.Size = new System.Drawing.Size(121, 21);
            this.comboCiudadPartida.TabIndex = 3;
            // 
            // comboCiudadDestino
            // 
            this.comboCiudadDestino.FormattingEnabled = true;
            this.comboCiudadDestino.Location = new System.Drawing.Point(110, 51);
            this.comboCiudadDestino.Name = "comboCiudadDestino";
            this.comboCiudadDestino.Size = new System.Drawing.Size(121, 21);
            this.comboCiudadDestino.TabIndex = 4;
            // 
            // dateTimePicker_Llegada
            // 
            this.dateTimePicker_Llegada.Location = new System.Drawing.Point(258, 54);
            this.dateTimePicker_Llegada.Name = "dateTimePicker_Llegada";
            this.dateTimePicker_Llegada.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Llegada.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Matrícula Aeronave:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker_Llegada);
            this.groupBox1.Controls.Add(this.comboCiudadDestino);
            this.groupBox1.Controls.Add(this.comboCiudadPartida);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker_Salida);
            this.groupBox1.Location = new System.Drawing.Point(22, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 279);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar Viaje";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Servicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "¿Autocompletado x la matricula?";
            // 
            // Generacion_Viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 340);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Generacion_Viaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Viaje";
            this.Load += new System.EventHandler(this.Generacion_Viaje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_Salida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCiudadPartida;
        private System.Windows.Forms.ComboBox comboCiudadDestino;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Llegada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;

    }
}