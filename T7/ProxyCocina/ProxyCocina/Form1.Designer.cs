namespace ProxyCocina
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
            this.btnSencilla01 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSencilla02 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSencilla01
            // 
            this.btnSencilla01.Location = new System.Drawing.Point(25, 37);
            this.btnSencilla01.Name = "btnSencilla01";
            this.btnSencilla01.Size = new System.Drawing.Size(108, 67);
            this.btnSencilla01.TabIndex = 0;
            this.btnSencilla01.Text = "Método 01";
            this.btnSencilla01.UseVisualStyleBackColor = true;
            this.btnSencilla01.Click += new System.EventHandler(this.btnSencilla01_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSencilla02);
            this.groupBox1.Controls.Add(this.btnSencilla01);
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxy Sencilla";
            // 
            // btnSencilla02
            // 
            this.btnSencilla02.Location = new System.Drawing.Point(172, 37);
            this.btnSencilla02.Name = "btnSencilla02";
            this.btnSencilla02.Size = new System.Drawing.Size(108, 67);
            this.btnSencilla02.TabIndex = 1;
            this.btnSencilla02.Text = "Método 02";
            this.btnSencilla02.UseVisualStyleBackColor = true;
            this.btnSencilla02.Click += new System.EventHandler(this.btnSencilla02_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 361);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Patrón de Diseño Proxy: Ejemplo 01";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnSencilla01;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Button btnSencilla02;

        #endregion
    }
}