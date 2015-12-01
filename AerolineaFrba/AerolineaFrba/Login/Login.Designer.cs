namespace AerolineaFrba.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_roles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_contraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Location = new System.Drawing.Point(80, 23);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(151, 20);
            this.textBox_usuario.TabIndex = 0;
            this.textBox_usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_usuario_KeyDown);

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // comboBox_roles
            // 
            this.comboBox_roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_roles.FormattingEnabled = true;
            this.comboBox_roles.Location = new System.Drawing.Point(91, 126);
            this.comboBox_roles.Name = "comboBox_roles";
            this.comboBox_roles.Size = new System.Drawing.Size(121, 21);
            this.comboBox_roles.Sorted = true;
            this.comboBox_roles.TabIndex = 4;
            this.comboBox_roles.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña";
            // 
            // textBox_contraseña
            // 
            this.textBox_contraseña.Location = new System.Drawing.Point(80, 73);
            this.textBox_contraseña.Name = "textBox_contraseña";
            this.textBox_contraseña.PasswordChar = '*';
            this.textBox_contraseña.Size = new System.Drawing.Size(151, 20);
            this.textBox_contraseña.TabIndex = 5;
            this.textBox_contraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox_contraseña.Enter += new System.EventHandler(this.textBox_contraseña_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Roles";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(338, 192);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_contraseña);
            this.Controls.Add(this.comboBox_roles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_usuario);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AerolineaFrba";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_roles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_contraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}