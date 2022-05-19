namespace BibliotecaUCA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.coleccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nosotrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misiónYVisiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cifras2016ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspRedesSociales = new System.Windows.Forms.ToolStrip();
            this.tsbYoutube = new System.Windows.Forms.ToolStripButton();
            this.tsbTwitter = new System.Windows.Forms.ToolStripButton();
            this.tsbFacebook = new System.Windows.Forms.ToolStripButton();
            this.tsbInstagram = new System.Windows.Forms.ToolStripButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tabContenedor = new System.Windows.Forms.TabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.tabMisionVision = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCifras = new System.Windows.Forms.TabPage();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.tabResultados = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picImagenLibro = new System.Windows.Forms.PictureBox();
            this.tlpGeneral.SuspendLayout();
            this.mspMenu.SuspendLayout();
            this.tspRedesSociales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabContenedor.SuspendLayout();
            this.tabInicio.SuspendLayout();
            this.tabMisionVision.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabBusqueda.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.tabResultados.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpGeneral
            // 
            this.tlpGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpGeneral.ColumnCount = 2;
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpGeneral.Controls.Add(this.mspMenu, 1, 0);
            this.tlpGeneral.Controls.Add(this.tspRedesSociales, 1, 1);
            this.tlpGeneral.Controls.Add(this.picLogo, 0, 0);
            this.tlpGeneral.Controls.Add(this.tabContenedor, 0, 2);
            this.tlpGeneral.Location = new System.Drawing.Point(12, 12);
            this.tlpGeneral.Name = "tlpGeneral";
            this.tlpGeneral.RowCount = 3;
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpGeneral.Size = new System.Drawing.Size(660, 537);
            this.tlpGeneral.TabIndex = 0;
            // 
            // mspMenu
            // 
            this.mspMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.mspMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mspMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.coleccionesToolStripMenuItem, this.nosotrosToolStripMenuItem, this.inicioToolStripMenuItem });
            this.mspMenu.Location = new System.Drawing.Point(132, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mspMenu.Size = new System.Drawing.Size(528, 53);
            this.mspMenu.TabIndex = 0;
            this.mspMenu.Text = "menuStrip1";
            // 
            // coleccionesToolStripMenuItem
            // 
            this.coleccionesToolStripMenuItem.Name = "coleccionesToolStripMenuItem";
            this.coleccionesToolStripMenuItem.Size = new System.Drawing.Size(83, 49);
            this.coleccionesToolStripMenuItem.Text = "Colecciones";
            this.coleccionesToolStripMenuItem.Click += new System.EventHandler(this.coleccionesToolStripMenuItem_Click);
            // 
            // nosotrosToolStripMenuItem
            // 
            this.nosotrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.misiónYVisiónToolStripMenuItem, this.cifras2016ToolStripMenuItem });
            this.nosotrosToolStripMenuItem.Name = "nosotrosToolStripMenuItem";
            this.nosotrosToolStripMenuItem.Size = new System.Drawing.Size(67, 49);
            this.nosotrosToolStripMenuItem.Text = "Nosotros";
            // 
            // misiónYVisiónToolStripMenuItem
            // 
            this.misiónYVisiónToolStripMenuItem.Name = "misiónYVisiónToolStripMenuItem";
            this.misiónYVisiónToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.misiónYVisiónToolStripMenuItem.Text = "Misión y visión";
            this.misiónYVisiónToolStripMenuItem.Click += new System.EventHandler(this.misiónYVisiónToolStripMenuItem_Click);
            // 
            // cifras2016ToolStripMenuItem
            // 
            this.cifras2016ToolStripMenuItem.Name = "cifras2016ToolStripMenuItem";
            this.cifras2016ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.cifras2016ToolStripMenuItem.Text = "Cifras 2016";
            this.cifras2016ToolStripMenuItem.Click += new System.EventHandler(this.cifras2016ToolStripMenuItem_Click);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 49);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // tspRedesSociales
            // 
            this.tspRedesSociales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tspRedesSociales.BackColor = System.Drawing.Color.Orange;
            this.tspRedesSociales.Dock = System.Windows.Forms.DockStyle.None;
            this.tspRedesSociales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.tsbYoutube, this.tsbTwitter, this.tsbFacebook, this.tsbInstagram });
            this.tspRedesSociales.Location = new System.Drawing.Point(132, 53);
            this.tspRedesSociales.Name = "tspRedesSociales";
            this.tspRedesSociales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tspRedesSociales.Size = new System.Drawing.Size(528, 53);
            this.tspRedesSociales.TabIndex = 1;
            this.tspRedesSociales.Text = "toolStrip1";
            // 
            // tsbYoutube
            // 
            this.tsbYoutube.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbYoutube.Image = global::BibliotecaUCA.Properties.Resources.YT;
            this.tsbYoutube.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbYoutube.Name = "tsbYoutube";
            this.tsbYoutube.Size = new System.Drawing.Size(23, 50);
            this.tsbYoutube.Text = "toolStripButton1";
            this.tsbYoutube.Click += new System.EventHandler(this.tsbYoutube_Click);
            // 
            // tsbTwitter
            // 
            this.tsbTwitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTwitter.Image = global::BibliotecaUCA.Properties.Resources.TW;
            this.tsbTwitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTwitter.Name = "tsbTwitter";
            this.tsbTwitter.Size = new System.Drawing.Size(23, 50);
            this.tsbTwitter.Text = "toolStripButton2";
            this.tsbTwitter.Click += new System.EventHandler(this.tsbTwitter_Click);
            // 
            // tsbFacebook
            // 
            this.tsbFacebook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFacebook.Image = global::BibliotecaUCA.Properties.Resources.FB;
            this.tsbFacebook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFacebook.Name = "tsbFacebook";
            this.tsbFacebook.Size = new System.Drawing.Size(23, 50);
            this.tsbFacebook.Text = "toolStripButton3";
            this.tsbFacebook.Click += new System.EventHandler(this.tsbFacebook_Click);
            // 
            // tsbInstagram
            // 
            this.tsbInstagram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInstagram.Image = global::BibliotecaUCA.Properties.Resources.IG;
            this.tsbInstagram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInstagram.Name = "tsbInstagram";
            this.tsbInstagram.Size = new System.Drawing.Size(23, 50);
            this.tsbInstagram.Text = "toolStripButton4";
            this.tsbInstagram.Click += new System.EventHandler(this.tsbInstagram_Click);
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = global::BibliotecaUCA.Properties.Resources.logo_biblioteca;
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.tlpGeneral.SetRowSpan(this.picLogo, 2);
            this.picLogo.Size = new System.Drawing.Size(126, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // tabContenedor
            // 
            this.tabContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tabContenedor.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tlpGeneral.SetColumnSpan(this.tabContenedor, 2);
            this.tabContenedor.Controls.Add(this.tabInicio);
            this.tabContenedor.Controls.Add(this.tabMisionVision);
            this.tabContenedor.Controls.Add(this.tabCifras);
            this.tabContenedor.Controls.Add(this.tabBusqueda);
            this.tabContenedor.Controls.Add(this.tabResultados);
            this.tabContenedor.Location = new System.Drawing.Point(3, 109);
            this.tabContenedor.Name = "tabContenedor";
            this.tabContenedor.SelectedIndex = 0;
            this.tabContenedor.Size = new System.Drawing.Size(654, 425);
            this.tabContenedor.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabContenedor.TabIndex = 3;
            this.tabContenedor.TabStop = false;
            // 
            // tabInicio
            // 
            this.tabInicio.BackColor = System.Drawing.Color.SteelBlue;
            this.tabInicio.BackgroundImage = global::BibliotecaUCA.Properties.Resources.fondo;
            this.tabInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabInicio.Controls.Add(this.lblBienvenidos);
            this.tabInicio.Location = new System.Drawing.Point(4, 25);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(646, 396);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "Inicio";
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBienvenidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.ForeColor = System.Drawing.Color.White;
            this.lblBienvenidos.Location = new System.Drawing.Point(3, 3);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(640, 390);
            this.lblBienvenidos.TabIndex = 0;
            this.lblBienvenidos.Text = "¡Bienvenidos!";
            this.lblBienvenidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMisionVision
            // 
            this.tabMisionVision.Controls.Add(this.tableLayoutPanel1);
            this.tabMisionVision.Location = new System.Drawing.Point(4, 25);
            this.tabMisionVision.Name = "tabMisionVision";
            this.tabMisionVision.Padding = new System.Windows.Forms.Padding(3);
            this.tabMisionVision.Size = new System.Drawing.Size(646, 396);
            this.tabMisionVision.TabIndex = 1;
            this.tabMisionVision.Text = "Misión y Visión";
            this.tabMisionVision.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 384);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(3, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(628, 117);
            this.label4.TabIndex = 3;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(628, 76);
            this.label3.TabIndex = 2;
            this.label3.Text = "VISIÓN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(628, 115);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "MISIÓN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabCifras
            // 
            this.tabCifras.BackgroundImage = global::BibliotecaUCA.Properties.Resources.cifras;
            this.tabCifras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabCifras.Location = new System.Drawing.Point(4, 25);
            this.tabCifras.Name = "tabCifras";
            this.tabCifras.Padding = new System.Windows.Forms.Padding(3);
            this.tabCifras.Size = new System.Drawing.Size(646, 396);
            this.tabCifras.TabIndex = 2;
            this.tabCifras.Text = "Cifras 2016";
            this.tabCifras.UseVisualStyleBackColor = true;
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.Controls.Add(this.tableLayoutPanel2);
            this.tabBusqueda.Location = new System.Drawing.Point(4, 25);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusqueda.Size = new System.Drawing.Size(646, 396);
            this.tabBusqueda.TabIndex = 3;
            this.tabBusqueda.Text = "Búsqueda";
            this.tabBusqueda.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.cmbBusqueda, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBusqueda, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBusqueda, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgvBusqueda, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(634, 384);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] { "Título", "Autor" });
            this.cmbBusqueda.Location = new System.Drawing.Point(66, 41);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(120, 21);
            this.cmbBusqueda.TabIndex = 0;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Location = new System.Drawing.Point(192, 41);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(311, 20);
            this.txtBusqueda.TabIndex = 1;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusqueda.BackColor = System.Drawing.Color.Orange;
            this.btnBusqueda.BackgroundImage = global::BibliotecaUCA.Properties.Resources.lupa1;
            this.btnBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Location = new System.Drawing.Point(509, 41);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(57, 32);
            this.btnBusqueda.TabIndex = 2;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dgvBusqueda, 3);
            this.dgvBusqueda.Location = new System.Drawing.Point(66, 79);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusqueda.Size = new System.Drawing.Size(500, 262);
            this.dgvBusqueda.TabIndex = 3;
            this.dgvBusqueda.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusqueda_CellContentDoubleClick);
            // 
            // tabResultados
            // 
            this.tabResultados.Controls.Add(this.tableLayoutPanel3);
            this.tabResultados.Location = new System.Drawing.Point(4, 25);
            this.tabResultados.Name = "tabResultados";
            this.tabResultados.Padding = new System.Windows.Forms.Padding(3);
            this.tabResultados.Size = new System.Drawing.Size(646, 396);
            this.tabResultados.TabIndex = 4;
            this.tabResultados.Text = "Resultados";
            this.tabResultados.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.lblTitulo, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblAutor, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblTema, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblClasificacion, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.label8, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.picImagenLibro, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(634, 387);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.lblTitulo, 2);
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(192, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(373, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAutor
            // 
            this.lblAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutor.Location = new System.Drawing.Point(318, 76);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(247, 38);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTema
            // 
            this.lblTema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTema.Location = new System.Drawing.Point(318, 114);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(247, 38);
            this.lblTema.TabIndex = 9;
            this.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClasificacion.Location = new System.Drawing.Point(318, 152);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(247, 38);
            this.lblClasificacion.TabIndex = 10;
            this.lblClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "Autor:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(192, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 38);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tema:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(192, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 38);
            this.label8.TabIndex = 4;
            this.label8.Text = "Clasificación:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picImagenLibro
            // 
            this.picImagenLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.picImagenLibro.Location = new System.Drawing.Point(66, 41);
            this.picImagenLibro.Name = "picImagenLibro";
            this.tableLayoutPanel3.SetRowSpan(this.picImagenLibro, 4);
            this.picImagenLibro.Size = new System.Drawing.Size(120, 146);
            this.picImagenLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagenLibro.TabIndex = 15;
            this.picImagenLibro.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.tlpGeneral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspMenu;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca \"Padre Florentino Idoate S.J.\"";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tlpGeneral.ResumeLayout(false);
            this.tlpGeneral.PerformLayout();
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.tspRedesSociales.ResumeLayout(false);
            this.tspRedesSociales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tabContenedor.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tabMisionVision.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabBusqueda.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.tabResultados.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagenLibro)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picImagenLibro;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblClasificacion;

        private System.Windows.Forms.Label lblAutor;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.TabPage tabResultados;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

        private System.Windows.Forms.DataGridView dgvBusqueda;

        private System.Windows.Forms.Button btnBusqueda;

        private System.Windows.Forms.TextBox txtBusqueda;

        private System.Windows.Forms.ComboBox cmbBusqueda;

        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        private System.Windows.Forms.TabPage tabCifras;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.Label lblBienvenidos;

        private System.Windows.Forms.ToolStripButton tsbInstagram;

        private System.Windows.Forms.ToolStripButton tsbFacebook;

        private System.Windows.Forms.ToolStripButton tsbTwitter;

        private System.Windows.Forms.ToolStripButton tsbYoutube;

        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nosotrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misiónYVisiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cifras2016ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coleccionesToolStripMenuItem;

        private System.Windows.Forms.TabControl tabContenedor;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabMisionVision;

        private System.Windows.Forms.PictureBox picLogo;

        private System.Windows.Forms.ToolStrip tspRedesSociales;

        private System.Windows.Forms.MenuStrip mspMenu;

        private System.Windows.Forms.TableLayoutPanel tlpGeneral;

        #endregion
    }
}