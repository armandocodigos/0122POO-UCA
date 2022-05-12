namespace TalleresGraficos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.picLogoUCA = new System.Windows.Forms.PictureBox();
            this.picLogoTG = new System.Windows.Forms.PictureBox();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.btnEncuadernado = new System.Windows.Forms.Button();
            this.btnImpresion = new System.Windows.Forms.Button();
            this.btnPlegados = new System.Windows.Forms.Button();
            this.txtCarrito = new System.Windows.Forms.TextBox();
            this.grbCarrito = new System.Windows.Forms.GroupBox();
            this.ttpCompleto = new System.Windows.Forms.ToolTip(this.components);
            this.ttpIncompleto = new System.Windows.Forms.ToolTip(this.components);
            this.sspInfo = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrBanner = new System.Windows.Forms.Timer(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoUCA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoTG)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.grbCarrito.SuspendLayout();
            this.sspInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogoUCA
            // 
            this.picLogoUCA.Image = ((System.Drawing.Image)(resources.GetObject("picLogoUCA.Image")));
            this.picLogoUCA.Location = new System.Drawing.Point(3, 3);
            this.picLogoUCA.Name = "picLogoUCA";
            this.picLogoUCA.Size = new System.Drawing.Size(68, 80);
            this.picLogoUCA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoUCA.TabIndex = 0;
            this.picLogoUCA.TabStop = false;
            // 
            // picLogoTG
            // 
            this.picLogoTG.Image = ((System.Drawing.Image)(resources.GetObject("picLogoTG.Image")));
            this.picLogoTG.Location = new System.Drawing.Point(77, 3);
            this.picLogoTG.Name = "picLogoTG";
            this.picLogoTG.Size = new System.Drawing.Size(590, 80);
            this.picLogoTG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoTG.TabIndex = 1;
            this.picLogoTG.TabStop = false;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.picLogoUCA);
            this.pnlEncabezado.Controls.Add(this.picLogoTG);
            this.pnlEncabezado.Location = new System.Drawing.Point(12, 12);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(670, 88);
            this.pnlEncabezado.TabIndex = 2;
            // 
            // picBanner
            // 
            this.picBanner.Image = global::TalleresGraficos.Properties.Resources.banner02;
            this.picBanner.Location = new System.Drawing.Point(12, 101);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(670, 190);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 3;
            this.picBanner.TabStop = false;
            // 
            // btnEncuadernado
            // 
            this.btnEncuadernado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncuadernado.Image = ((System.Drawing.Image)(resources.GetObject("btnEncuadernado.Image")));
            this.btnEncuadernado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEncuadernado.Location = new System.Drawing.Point(12, 297);
            this.btnEncuadernado.Name = "btnEncuadernado";
            this.btnEncuadernado.Size = new System.Drawing.Size(223, 92);
            this.btnEncuadernado.TabIndex = 4;
            this.btnEncuadernado.Text = "Encuadernado";
            this.btnEncuadernado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttpCompleto.SetToolTip(this.btnEncuadernado, "Encarga tu Encuadernado");
            this.btnEncuadernado.UseVisualStyleBackColor = true;
            this.btnEncuadernado.Click += new System.EventHandler(this.btnEncuadernado_Click);
            // 
            // btnImpresion
            // 
            this.btnImpresion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpresion.Image = ((System.Drawing.Image)(resources.GetObject("btnImpresion.Image")));
            this.btnImpresion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImpresion.Location = new System.Drawing.Point(241, 297);
            this.btnImpresion.Name = "btnImpresion";
            this.btnImpresion.Size = new System.Drawing.Size(219, 92);
            this.btnImpresion.TabIndex = 5;
            this.btnImpresion.Text = "Impresión Digital";
            this.btnImpresion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttpIncompleto.SetToolTip(this.btnImpresion, "En desarrollo");
            this.btnImpresion.UseVisualStyleBackColor = true;
            // 
            // btnPlegados
            // 
            this.btnPlegados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlegados.Image = ((System.Drawing.Image)(resources.GetObject("btnPlegados.Image")));
            this.btnPlegados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlegados.Location = new System.Drawing.Point(466, 297);
            this.btnPlegados.Name = "btnPlegados";
            this.btnPlegados.Size = new System.Drawing.Size(216, 92);
            this.btnPlegados.TabIndex = 6;
            this.btnPlegados.Text = "Plegados";
            this.btnPlegados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttpIncompleto.SetToolTip(this.btnPlegados, "En desarrollo");
            this.btnPlegados.UseVisualStyleBackColor = true;
            // 
            // txtCarrito
            // 
            this.txtCarrito.Location = new System.Drawing.Point(6, 21);
            this.txtCarrito.Multiline = true;
            this.txtCarrito.Name = "txtCarrito";
            this.txtCarrito.ReadOnly = true;
            this.txtCarrito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCarrito.Size = new System.Drawing.Size(658, 107);
            this.txtCarrito.TabIndex = 7;
            // 
            // grbCarrito
            // 
            this.grbCarrito.Controls.Add(this.txtCarrito);
            this.grbCarrito.Location = new System.Drawing.Point(12, 395);
            this.grbCarrito.Name = "grbCarrito";
            this.grbCarrito.Size = new System.Drawing.Size(670, 134);
            this.grbCarrito.TabIndex = 8;
            this.grbCarrito.TabStop = false;
            this.grbCarrito.Text = "Carrito:";
            // 
            // ttpCompleto
            // 
            this.ttpCompleto.IsBalloon = true;
            this.ttpCompleto.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpCompleto.ToolTipTitle = "Talleres Gráficos UCA";
            // 
            // ttpIncompleto
            // 
            this.ttpIncompleto.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.ttpIncompleto.ToolTipTitle = "Talleres Gráficos UCA";
            // 
            // sspInfo
            // 
            this.sspInfo.BackColor = System.Drawing.Color.White;
            this.sspInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblEstado });
            this.sspInfo.Location = new System.Drawing.Point(0, 577);
            this.sspInfo.Name = "sspInfo";
            this.sspInfo.Size = new System.Drawing.Size(694, 22);
            this.sspInfo.TabIndex = 9;
            this.sspInfo.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(196, 17);
            this.lblEstado.Text = "No hay encuadernados encargados.";
            // 
            // tmrBanner
            // 
            this.tmrBanner.Enabled = true;
            this.tmrBanner.Interval = 2000;
            this.tmrBanner.Tick += new System.EventHandler(this.tmrBanner_Tick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(557, 535);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 36);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 599);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.sspInfo);
            this.Controls.Add(this.grbCarrito);
            this.Controls.Add(this.btnPlegados);
            this.Controls.Add(this.btnImpresion);
            this.Controls.Add(this.btnEncuadernado);
            this.Controls.Add(this.picBanner);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a Talleres Gráficos UCA";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoUCA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoTG)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.grbCarrito.ResumeLayout(false);
            this.grbCarrito.PerformLayout();
            this.sspInfo.ResumeLayout(false);
            this.sspInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnLimpiar;

        private System.Windows.Forms.Timer tmrBanner;

        private System.Windows.Forms.ToolStripStatusLabel lblEstado;

        private System.Windows.Forms.StatusStrip sspInfo;

        private System.Windows.Forms.ToolTip ttpIncompleto;

        private System.Windows.Forms.ToolTip ttpCompleto;

        private System.Windows.Forms.TextBox txtCarrito;
        private System.Windows.Forms.GroupBox grbCarrito;

        private System.Windows.Forms.Button btnImpresion;
        private System.Windows.Forms.Button btnPlegados;

        private System.Windows.Forms.Button btnEncuadernado;

        private System.Windows.Forms.PictureBox picBanner;

        private System.Windows.Forms.Panel pnlEncabezado;

        private System.Windows.Forms.PictureBox picLogoUCA;
        private System.Windows.Forms.PictureBox picLogoTG;

        #endregion
    }
}