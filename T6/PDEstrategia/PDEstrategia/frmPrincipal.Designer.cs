namespace PDEstrategia
{
    partial class frmPrincipal
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
            this.btnAlfil = new System.Windows.Forms.Button();
            this.btnRey = new System.Windows.Forms.Button();
            this.btnCaballo = new System.Windows.Forms.Button();
            this.btnReina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlfil
            // 
            this.btnAlfil.Location = new System.Drawing.Point(24, 173);
            this.btnAlfil.Name = "btnAlfil";
            this.btnAlfil.Size = new System.Drawing.Size(123, 50);
            this.btnAlfil.TabIndex = 0;
            this.btnAlfil.Text = "Alfil";
            this.btnAlfil.UseVisualStyleBackColor = true;
            this.btnAlfil.Click += new System.EventHandler(this.btnAlfil_Click);
            // 
            // btnRey
            // 
            this.btnRey.Location = new System.Drawing.Point(167, 173);
            this.btnRey.Name = "btnRey";
            this.btnRey.Size = new System.Drawing.Size(123, 50);
            this.btnRey.TabIndex = 1;
            this.btnRey.Text = "Rey";
            this.btnRey.UseVisualStyleBackColor = true;
            this.btnRey.Click += new System.EventHandler(this.btnRey_Click);
            // 
            // btnCaballo
            // 
            this.btnCaballo.Location = new System.Drawing.Point(308, 173);
            this.btnCaballo.Name = "btnCaballo";
            this.btnCaballo.Size = new System.Drawing.Size(123, 50);
            this.btnCaballo.TabIndex = 2;
            this.btnCaballo.Text = "Caballo";
            this.btnCaballo.UseVisualStyleBackColor = true;
            // 
            // btnReina
            // 
            this.btnReina.Location = new System.Drawing.Point(448, 173);
            this.btnReina.Name = "btnReina";
            this.btnReina.Size = new System.Drawing.Size(123, 50);
            this.btnReina.TabIndex = 3;
            this.btnReina.Text = "Reina";
            this.btnReina.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.btnReina);
            this.Controls.Add(this.btnCaballo);
            this.Controls.Add(this.btnRey);
            this.Controls.Add(this.btnAlfil);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAlfil;
        private System.Windows.Forms.Button btnRey;
        private System.Windows.Forms.Button btnCaballo;
        private System.Windows.Forms.Button btnReina;

        #endregion
    }
}