namespace AerolineaFrba.Abm_Aeronave
{
    partial class DecisionAeronave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecisionAeronave));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_reprogramar = new System.Windows.Forms.Button();
            this.button_cancelarTodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_repro = new System.Windows.Forms.Button();
            this.comboBox_aeronaves = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_reprogramar);
            this.groupBox1.Controls.Add(this.button_cancelarTodo);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione";
            // 
            // button_reprogramar
            // 
            this.button_reprogramar.Location = new System.Drawing.Point(199, 33);
            this.button_reprogramar.Name = "button_reprogramar";
            this.button_reprogramar.Size = new System.Drawing.Size(108, 45);
            this.button_reprogramar.TabIndex = 1;
            this.button_reprogramar.Text = "Reprogramar Pasajes";
            this.button_reprogramar.UseVisualStyleBackColor = true;
            this.button_reprogramar.Click += new System.EventHandler(this.button_reprogramar_Click);
            // 
            // button_cancelarTodo
            // 
            this.button_cancelarTodo.Location = new System.Drawing.Point(81, 33);
            this.button_cancelarTodo.Name = "button_cancelarTodo";
            this.button_cancelarTodo.Size = new System.Drawing.Size(102, 45);
            this.button_cancelarTodo.TabIndex = 0;
            this.button_cancelarTodo.Text = "Cancelar Pasajes";
            this.button_cancelarTodo.UseVisualStyleBackColor = true;
            this.button_cancelarTodo.Click += new System.EventHandler(this.button_cancelarTodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "La aeronave posee viajes programados, ¿Qué desea hacer?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_repro);
            this.groupBox2.Controls.Add(this.comboBox_aeronaves);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 118);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cambio";
            // 
            // button_repro
            // 
            this.button_repro.Location = new System.Drawing.Point(148, 65);
            this.button_repro.Name = "button_repro";
            this.button_repro.Size = new System.Drawing.Size(103, 43);
            this.button_repro.TabIndex = 2;
            this.button_repro.Text = "Reprogramar";
            this.button_repro.UseVisualStyleBackColor = true;
            this.button_repro.Click += new System.EventHandler(this.button_repro_Click);
            // 
            // comboBox_aeronaves
            // 
            this.comboBox_aeronaves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_aeronaves.FormattingEnabled = true;
            this.comboBox_aeronaves.Location = new System.Drawing.Point(148, 29);
            this.comboBox_aeronaves.Name = "comboBox_aeronaves";
            this.comboBox_aeronaves.Size = new System.Drawing.Size(141, 21);
            this.comboBox_aeronaves.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aeronaves:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "No se encontro una aeronave compatible";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Se procedera a dar de alta una nueva aeronave por la que se podra sustituir.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingrese la matricula del nuevo avion:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(12, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reemplazo";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(313, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DecisionAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 400);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DecisionAeronave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decisión Aeronave";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_reprogramar;
        private System.Windows.Forms.Button button_cancelarTodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_aeronaves;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_repro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
    }
}