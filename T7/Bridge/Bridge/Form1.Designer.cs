namespace Bridge
{
    partial class Form1
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
            this.radLujo = new System.Windows.Forms.RadioButton();
            this.radCarga = new System.Windows.Forms.RadioButton();
            this.radBala = new System.Windows.Forms.RadioButton();
            this.btnTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radLujo
            // 
            this.radLujo.Checked = true;
            this.radLujo.Location = new System.Drawing.Point(37, 46);
            this.radLujo.Name = "radLujo";
            this.radLujo.Size = new System.Drawing.Size(96, 35);
            this.radLujo.TabIndex = 0;
            this.radLujo.TabStop = true;
            this.radLujo.Text = "Tren de lujo";
            this.radLujo.UseVisualStyleBackColor = true;
            // 
            // radCarga
            // 
            this.radCarga.Location = new System.Drawing.Point(37, 105);
            this.radCarga.Name = "radCarga";
            this.radCarga.Size = new System.Drawing.Size(96, 35);
            this.radCarga.TabIndex = 1;
            this.radCarga.Text = "Tren de carga";
            this.radCarga.UseVisualStyleBackColor = true;
            // 
            // radBala
            // 
            this.radBala.Location = new System.Drawing.Point(37, 164);
            this.radBala.Name = "radBala";
            this.radBala.Size = new System.Drawing.Size(96, 35);
            this.radBala.TabIndex = 2;
            this.radBala.Text = "Tren Bala";
            this.radBala.UseVisualStyleBackColor = true;
            // 
            // btnTransporte
            // 
            this.btnTransporte.Location = new System.Drawing.Point(178, 74);
            this.btnTransporte.Name = "btnTransporte";
            this.btnTransporte.Size = new System.Drawing.Size(160, 89);
            this.btnTransporte.TabIndex = 3;
            this.btnTransporte.Text = "Transporte";
            this.btnTransporte.UseVisualStyleBackColor = true;
            this.btnTransporte.Click += new System.EventHandler(this.btnTransporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 234);
            this.Controls.Add(this.btnTransporte);
            this.Controls.Add(this.radBala);
            this.Controls.Add(this.radCarga);
            this.Controls.Add(this.radLujo);
            this.Name = "Form1";
            this.Text = "Patrón de Diseño Bridge";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RadioButton radLujo;
        private System.Windows.Forms.RadioButton radCarga;
        private System.Windows.Forms.RadioButton radBala;
        private System.Windows.Forms.Button btnTransporte;

        #endregion
    }
}