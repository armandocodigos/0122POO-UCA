namespace Estrategia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDama = new System.Windows.Forms.RadioButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.radAlfil = new System.Windows.Forms.RadioButton();
            this.radCaballo = new System.Windows.Forms.RadioButton();
            this.radTorre = new System.Windows.Forms.RadioButton();
            this.radPeon = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radDama2 = new System.Windows.Forms.RadioButton();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.btnInfo2 = new System.Windows.Forms.Button();
            this.radAlfil2 = new System.Windows.Forms.RadioButton();
            this.radCaballo2 = new System.Windows.Forms.RadioButton();
            this.radTorre2 = new System.Windows.Forms.RadioButton();
            this.radPeon2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDama);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.btnInfo);
            this.groupBox1.Controls.Add(this.radAlfil);
            this.groupBox1.Controls.Add(this.radCaballo);
            this.groupBox1.Controls.Add(this.radTorre);
            this.groupBox1.Controls.Add(this.radPeon);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(458, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patrón Estrategia - Forma 1:";
            // 
            // radDama
            // 
            this.radDama.Location = new System.Drawing.Point(31, 160);
            this.radDama.Name = "radDama";
            this.radDama.Size = new System.Drawing.Size(104, 24);
            this.radDama.TabIndex = 6;
            this.radDama.Text = "Dama";
            this.radDama.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(223, 93);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(188, 101);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "<Movimiento>";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(223, 41);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(188, 42);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Dar Información";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnMovimiento_Click);
            // 
            // radAlfil
            // 
            this.radAlfil.Location = new System.Drawing.Point(31, 130);
            this.radAlfil.Name = "radAlfil";
            this.radAlfil.Size = new System.Drawing.Size(104, 24);
            this.radAlfil.TabIndex = 3;
            this.radAlfil.Text = "Alfil";
            this.radAlfil.UseVisualStyleBackColor = true;
            // 
            // radCaballo
            // 
            this.radCaballo.Location = new System.Drawing.Point(31, 100);
            this.radCaballo.Name = "radCaballo";
            this.radCaballo.Size = new System.Drawing.Size(104, 24);
            this.radCaballo.TabIndex = 2;
            this.radCaballo.Text = "Caballo";
            this.radCaballo.UseVisualStyleBackColor = true;
            // 
            // radTorre
            // 
            this.radTorre.Location = new System.Drawing.Point(31, 70);
            this.radTorre.Name = "radTorre";
            this.radTorre.Size = new System.Drawing.Size(104, 24);
            this.radTorre.TabIndex = 1;
            this.radTorre.Text = "Torre";
            this.radTorre.UseVisualStyleBackColor = true;
            // 
            // radPeon
            // 
            this.radPeon.Checked = true;
            this.radPeon.Location = new System.Drawing.Point(31, 40);
            this.radPeon.Name = "radPeon";
            this.radPeon.Size = new System.Drawing.Size(104, 24);
            this.radPeon.TabIndex = 0;
            this.radPeon.TabStop = true;
            this.radPeon.Text = "Peón";
            this.radPeon.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radDama2);
            this.groupBox2.Controls.Add(this.lblInfo2);
            this.groupBox2.Controls.Add(this.btnInfo2);
            this.groupBox2.Controls.Add(this.radAlfil2);
            this.groupBox2.Controls.Add(this.radCaballo2);
            this.groupBox2.Controls.Add(this.radTorre2);
            this.groupBox2.Controls.Add(this.radPeon2);
            this.groupBox2.Location = new System.Drawing.Point(13, 246);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(458, 225);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patrón Estrategia - Forma 2:";
            // 
            // radDama2
            // 
            this.radDama2.Location = new System.Drawing.Point(31, 160);
            this.radDama2.Name = "radDama2";
            this.radDama2.Size = new System.Drawing.Size(104, 24);
            this.radDama2.TabIndex = 6;
            this.radDama2.Text = "Dama";
            this.radDama2.UseVisualStyleBackColor = true;
            // 
            // lblInfo2
            // 
            this.lblInfo2.Location = new System.Drawing.Point(223, 93);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(188, 101);
            this.lblInfo2.TabIndex = 5;
            this.lblInfo2.Text = "<Movimiento>";
            this.lblInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInfo2
            // 
            this.btnInfo2.Location = new System.Drawing.Point(223, 41);
            this.btnInfo2.Name = "btnInfo2";
            this.btnInfo2.Size = new System.Drawing.Size(188, 42);
            this.btnInfo2.TabIndex = 4;
            this.btnInfo2.Text = "Dar Información";
            this.btnInfo2.UseVisualStyleBackColor = true;
            this.btnInfo2.Click += new System.EventHandler(this.btnInfo2_Click);
            // 
            // radAlfil2
            // 
            this.radAlfil2.Location = new System.Drawing.Point(31, 130);
            this.radAlfil2.Name = "radAlfil2";
            this.radAlfil2.Size = new System.Drawing.Size(104, 24);
            this.radAlfil2.TabIndex = 3;
            this.radAlfil2.Text = "Alfil";
            this.radAlfil2.UseVisualStyleBackColor = true;
            // 
            // radCaballo2
            // 
            this.radCaballo2.Location = new System.Drawing.Point(31, 100);
            this.radCaballo2.Name = "radCaballo2";
            this.radCaballo2.Size = new System.Drawing.Size(104, 24);
            this.radCaballo2.TabIndex = 2;
            this.radCaballo2.Text = "Caballo";
            this.radCaballo2.UseVisualStyleBackColor = true;
            // 
            // radTorre2
            // 
            this.radTorre2.Location = new System.Drawing.Point(31, 70);
            this.radTorre2.Name = "radTorre2";
            this.radTorre2.Size = new System.Drawing.Size(104, 24);
            this.radTorre2.TabIndex = 1;
            this.radTorre2.Text = "Torre";
            this.radTorre2.UseVisualStyleBackColor = true;
            // 
            // radPeon2
            // 
            this.radPeon2.Checked = true;
            this.radPeon2.Location = new System.Drawing.Point(31, 40);
            this.radPeon2.Name = "radPeon2";
            this.radPeon2.Size = new System.Drawing.Size(104, 24);
            this.radPeon2.TabIndex = 0;
            this.radPeon2.TabStop = true;
            this.radPeon2.Text = "Peón";
            this.radPeon2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Intro. a los Patrones de Diseño";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radDama2;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Button btnInfo2;
        private System.Windows.Forms.RadioButton radAlfil2;
        private System.Windows.Forms.RadioButton radCaballo2;
        private System.Windows.Forms.RadioButton radTorre2;
        private System.Windows.Forms.RadioButton radPeon2;

        private System.Windows.Forms.RadioButton radDama;

        private System.Windows.Forms.RadioButton radCaballo;
        private System.Windows.Forms.RadioButton radAlfil;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblInfo;

        private System.Windows.Forms.RadioButton radTorre;

        private System.Windows.Forms.RadioButton radPeon;

        private System.Windows.Forms.GroupBox groupBox1;

        #endregion
    }
}