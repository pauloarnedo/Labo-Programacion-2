namespace Vistas
{
    partial class FrmSaludo
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
            this.lblHola = new System.Windows.Forms.Label();
            this.lblMsjNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHola.Location = new System.Drawing.Point(12, 9);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(219, 25);
            this.lblHola.TabIndex = 0;
            this.lblHola.Text = "¡Hola, Windows Form!";
            // 
            // lblMsjNombre
            // 
            this.lblMsjNombre.AutoSize = true;
            this.lblMsjNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMsjNombre.Location = new System.Drawing.Point(12, 57);
            this.lblMsjNombre.Name = "lblMsjNombre";
            this.lblMsjNombre.Size = new System.Drawing.Size(116, 21);
            this.lblMsjNombre.TabIndex = 1;
            this.lblMsjNombre.Text = "Soy Juan Pérez.";
            // 
            // FrmSaludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 104);
            this.Controls.Add(this.lblMsjNombre);
            this.Controls.Add(this.lblHola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaludo";
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHola;
        private Label lblMsjNombre;
    }
}