namespace AerolineaFrba
{
    partial class AerolineaFrba
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AerolineaFrba));
            this.boton_Rol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton_Rol
            // 
            this.boton_Rol.Location = new System.Drawing.Point(68, 46);
            this.boton_Rol.Name = "boton_Rol";
            this.boton_Rol.Size = new System.Drawing.Size(146, 33);
            this.boton_Rol.TabIndex = 0;
            this.boton_Rol.Text = "ABM Rol";
            this.boton_Rol.UseVisualStyleBackColor = true;
            this.boton_Rol.Click += new System.EventHandler(this.boton_Rol_Click);
            // 
            // AerolineaFrba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 342);
            this.Controls.Add(this.boton_Rol);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AerolineaFrba";
            this.Text = "AerolineaFRBA";
            this.Load += new System.EventHandler(this.AerolineaFrba_Load);
            this.ResumeLayout(false);

        }

        private void tabPage2_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button boton_Rol;


    }
}

