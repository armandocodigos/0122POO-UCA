using System.ComponentModel;

namespace Blockbuster
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.sstBarraInferior = new System.Windows.Forms.StatusStrip();
            this.lblBienvenida = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.tabInterior = new System.Windows.Forms.TabControl();
            this.tabTitulo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBusquedaTitulo = new System.Windows.Forms.TextBox();
            this.btnBusquedaTitulo = new System.Windows.Forms.Button();
            this.dgvTitulo = new System.Windows.Forms.DataGridView();
            this.tabGenero = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBusquedaGenero = new System.Windows.Forms.Button();
            this.dgvGenero = new System.Windows.Forms.DataGridView();
            this.cmbBusquedaGenero = new System.Windows.Forms.ComboBox();
            this.tabNuevaP = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbNDirector = new System.Windows.Forms.ComboBox();
            this.txtNDescripcion = new System.Windows.Forms.TextBox();
            this.nudNStock = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.txtNCodigo = new System.Windows.Forms.TextBox();
            this.txtNTitulo = new System.Windows.Forms.TextBox();
            this.dtpNEstreno = new System.Windows.Forms.DateTimePicker();
            this.nudNPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudNDuracion = new System.Windows.Forms.NumericUpDown();
            this.cmbNGenero = new System.Windows.Forms.ComboBox();
            this.dgvNuevaPelicula = new System.Windows.Forms.DataGridView();
            this.tabModP = new System.Windows.Forms.TabPage();
            this.tabEliminarP = new System.Windows.Forms.TabPage();
            this.tabNuevaR = new System.Windows.Forms.TabPage();
            this.tabVerR = new System.Windows.Forms.TabPage();
            this.mstMenuSuperior = new System.Windows.Forms.MenuStrip();
            this.btnMenuInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuBúsqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuNuevaPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuModificarPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuElliminarPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.rentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuNuevaRenta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuVerRenta = new System.Windows.Forms.ToolStripMenuItem();
            this.ttpIncompleto = new System.Windows.Forms.ToolTip(this.components);
            this.sstBarraInferior.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tabInicio.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabBusqueda.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabInterior.SuspendLayout();
            this.tabTitulo.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulo)).BeginInit();
            this.tabGenero.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).BeginInit();
            this.tabNuevaP.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevaPelicula)).BeginInit();
            this.mstMenuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // sstBarraInferior
            // 
            this.sstBarraInferior.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sstBarraInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblBienvenida });
            this.sstBarraInferior.Location = new System.Drawing.Point(0, 539);
            this.sstBarraInferior.Name = "sstBarraInferior";
            this.sstBarraInferior.Size = new System.Drawing.Size(784, 22);
            this.sstBarraInferior.TabIndex = 0;
            this.sstBarraInferior.Text = "statusStrip1";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(169, 17);
            this.lblBienvenida.Text = "Bienvenido <Usuario> (<Rol>)";
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPrincipal.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPrincipal.Controls.Add(this.tabInicio);
            this.tabPrincipal.Controls.Add(this.tabBusqueda);
            this.tabPrincipal.Controls.Add(this.tabNuevaP);
            this.tabPrincipal.Controls.Add(this.tabModP);
            this.tabPrincipal.Controls.Add(this.tabEliminarP);
            this.tabPrincipal.Controls.Add(this.tabNuevaR);
            this.tabPrincipal.Controls.Add(this.tabVerR);
            this.tabPrincipal.Location = new System.Drawing.Point(12, 27);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(760, 509);
            this.tabPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPrincipal.TabIndex = 1;
            this.tabPrincipal.TabStop = false;
            // 
            // tabInicio
            // 
            this.tabInicio.BackColor = System.Drawing.Color.White;
            this.tabInicio.Controls.Add(this.tableLayoutPanel1);
            this.tabInicio.Location = new System.Drawing.Point(4, 28);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(752, 477);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "Inicio";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(336, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 139);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(336, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 139);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fue fundada en 1985 por David Cook, tuvo un gran crecimiento en los años 1990.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Blockbuster.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(114, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Blockbuster.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(114, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.Controls.Add(this.tableLayoutPanel2);
            this.tabBusqueda.Location = new System.Drawing.Point(4, 28);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusqueda.Size = new System.Drawing.Size(752, 477);
            this.tabBusqueda.TabIndex = 1;
            this.tabBusqueda.Text = "Búsqueda";
            this.tabBusqueda.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbTipoBusqueda, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabInterior, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(740, 501);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de Búsqueda:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTipoBusqueda
            // 
            this.cmbTipoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBusqueda.FormattingEnabled = true;
            this.cmbTipoBusqueda.Items.AddRange(new object[] { "Título", "Género" });
            this.cmbTipoBusqueda.Location = new System.Drawing.Point(151, 51);
            this.cmbTipoBusqueda.Name = "cmbTipoBusqueda";
            this.cmbTipoBusqueda.Size = new System.Drawing.Size(364, 24);
            this.cmbTipoBusqueda.TabIndex = 1;
            this.cmbTipoBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbTipoBusqueda_SelectedIndexChanged);
            // 
            // tabInterior
            // 
            this.tabInterior.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tabInterior.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tableLayoutPanel2.SetColumnSpan(this.tabInterior, 3);
            this.tabInterior.Controls.Add(this.tabTitulo);
            this.tabInterior.Controls.Add(this.tabGenero);
            this.tabInterior.Location = new System.Drawing.Point(3, 78);
            this.tabInterior.Name = "tabInterior";
            this.tabInterior.SelectedIndex = 0;
            this.tabInterior.Size = new System.Drawing.Size(734, 420);
            this.tabInterior.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabInterior.TabIndex = 2;
            this.tabInterior.TabStop = false;
            // 
            // tabTitulo
            // 
            this.tabTitulo.Controls.Add(this.tableLayoutPanel3);
            this.tabTitulo.Location = new System.Drawing.Point(4, 28);
            this.tabTitulo.Name = "tabTitulo";
            this.tabTitulo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTitulo.Size = new System.Drawing.Size(726, 388);
            this.tabTitulo.TabIndex = 0;
            this.tabTitulo.Text = "Título";
            this.tabTitulo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtBusquedaTitulo, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBusquedaTitulo, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgvTitulo, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(714, 376);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Título:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBusquedaTitulo
            // 
            this.txtBusquedaTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusquedaTitulo.Location = new System.Drawing.Point(145, 12);
            this.txtBusquedaTitulo.Name = "txtBusquedaTitulo";
            this.txtBusquedaTitulo.Size = new System.Drawing.Size(351, 22);
            this.txtBusquedaTitulo.TabIndex = 1;
            // 
            // btnBusquedaTitulo
            // 
            this.btnBusquedaTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusquedaTitulo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBusquedaTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaTitulo.Location = new System.Drawing.Point(502, 3);
            this.btnBusquedaTitulo.Name = "btnBusquedaTitulo";
            this.btnBusquedaTitulo.Size = new System.Drawing.Size(209, 31);
            this.btnBusquedaTitulo.TabIndex = 2;
            this.btnBusquedaTitulo.Text = "Buscar";
            this.btnBusquedaTitulo.UseVisualStyleBackColor = false;
            this.btnBusquedaTitulo.Click += new System.EventHandler(this.btnBusquedaTitulo_Click);
            // 
            // dgvTitulo
            // 
            this.dgvTitulo.AllowUserToAddRows = false;
            this.dgvTitulo.AllowUserToDeleteRows = false;
            this.dgvTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTitulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel3.SetColumnSpan(this.dgvTitulo, 3);
            this.dgvTitulo.Location = new System.Drawing.Point(3, 40);
            this.dgvTitulo.Name = "dgvTitulo";
            this.dgvTitulo.ReadOnly = true;
            this.dgvTitulo.Size = new System.Drawing.Size(708, 333);
            this.dgvTitulo.TabIndex = 3;
            // 
            // tabGenero
            // 
            this.tabGenero.Controls.Add(this.tableLayoutPanel4);
            this.tabGenero.Location = new System.Drawing.Point(4, 28);
            this.tabGenero.Name = "tabGenero";
            this.tabGenero.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenero.Size = new System.Drawing.Size(726, 388);
            this.tabGenero.TabIndex = 1;
            this.tabGenero.Text = "Género";
            this.tabGenero.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnBusquedaGenero, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.dgvGenero, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cmbBusquedaGenero, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(714, 382);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Género:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBusquedaGenero
            // 
            this.btnBusquedaGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusquedaGenero.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBusquedaGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaGenero.Location = new System.Drawing.Point(502, 3);
            this.btnBusquedaGenero.Name = "btnBusquedaGenero";
            this.btnBusquedaGenero.Size = new System.Drawing.Size(209, 32);
            this.btnBusquedaGenero.TabIndex = 2;
            this.btnBusquedaGenero.Text = "Buscar";
            this.btnBusquedaGenero.UseVisualStyleBackColor = false;
            this.btnBusquedaGenero.Click += new System.EventHandler(this.btnBusquedaGenero_Click);
            // 
            // dgvGenero
            // 
            this.dgvGenero.AllowUserToAddRows = false;
            this.dgvGenero.AllowUserToDeleteRows = false;
            this.dgvGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel4.SetColumnSpan(this.dgvGenero, 3);
            this.dgvGenero.Location = new System.Drawing.Point(3, 41);
            this.dgvGenero.Name = "dgvGenero";
            this.dgvGenero.ReadOnly = true;
            this.dgvGenero.Size = new System.Drawing.Size(708, 338);
            this.dgvGenero.TabIndex = 3;
            // 
            // cmbBusquedaGenero
            // 
            this.cmbBusquedaGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBusquedaGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusquedaGenero.FormattingEnabled = true;
            this.cmbBusquedaGenero.Location = new System.Drawing.Point(145, 14);
            this.cmbBusquedaGenero.Name = "cmbBusquedaGenero";
            this.cmbBusquedaGenero.Size = new System.Drawing.Size(351, 24);
            this.cmbBusquedaGenero.TabIndex = 4;
            // 
            // tabNuevaP
            // 
            this.tabNuevaP.Controls.Add(this.tableLayoutPanel5);
            this.tabNuevaP.Location = new System.Drawing.Point(4, 28);
            this.tabNuevaP.Name = "tabNuevaP";
            this.tabNuevaP.Size = new System.Drawing.Size(752, 477);
            this.tabNuevaP.TabIndex = 2;
            this.tabNuevaP.Text = "Nueva Pel";
            this.tabNuevaP.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.Controls.Add(this.comboBox3, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.comboBox2, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.comboBox1, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.cmbNDirector, 3, 3);
            this.tableLayoutPanel5.Controls.Add(this.txtNDescripcion, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.nudNStock, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label12, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.label13, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.label14, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.btnLimpiar, 2, 4);
            this.tableLayoutPanel5.Controls.Add(this.btnAgregarNuevo, 3, 4);
            this.tableLayoutPanel5.Controls.Add(this.txtNCodigo, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtNTitulo, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.dtpNEstreno, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.nudNPrecio, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.nudNDuracion, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.cmbNGenero, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.dgvNuevaPelicula, 0, 5);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 7;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(746, 507);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(3, 486);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(143, 24);
            this.comboBox3.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(152, 486);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(217, 24);
            this.comboBox2.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(375, 486);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // cmbNDirector
            // 
            this.cmbNDirector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNDirector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNDirector.FormattingEnabled = true;
            this.cmbNDirector.Location = new System.Drawing.Point(524, 168);
            this.cmbNDirector.Name = "cmbNDirector";
            this.cmbNDirector.Size = new System.Drawing.Size(219, 24);
            this.cmbNDirector.TabIndex = 19;
            // 
            // txtNDescripcion
            // 
            this.txtNDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNDescripcion.Location = new System.Drawing.Point(524, 71);
            this.txtNDescripcion.Name = "txtNDescripcion";
            this.txtNDescripcion.Size = new System.Drawing.Size(219, 22);
            this.txtNDescripcion.TabIndex = 17;
            // 
            // nudNStock
            // 
            this.nudNStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNStock.Location = new System.Drawing.Point(524, 23);
            this.nudNStock.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.nudNStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudNStock.Name = "nudNStock";
            this.nudNStock.Size = new System.Drawing.Size(219, 22);
            this.nudNStock.TabIndex = 16;
            this.nudNStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNStock.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 48);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(3, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 48);
            this.label7.TabIndex = 1;
            this.label7.Text = "Título:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(3, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 48);
            this.label8.TabIndex = 2;
            this.label8.Text = "Estreno:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(3, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 48);
            this.label9.TabIndex = 3;
            this.label9.Text = "Precio:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(3, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 48);
            this.label10.TabIndex = 4;
            this.label10.Text = "Duración:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Location = new System.Drawing.Point(375, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 48);
            this.label11.TabIndex = 5;
            this.label11.Text = "Stock:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Location = new System.Drawing.Point(375, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 48);
            this.label12.TabIndex = 6;
            this.label12.Text = "Descripción:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Location = new System.Drawing.Point(375, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 48);
            this.label13.TabIndex = 7;
            this.label13.Text = "Género:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Location = new System.Drawing.Point(375, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 48);
            this.label14.TabIndex = 8;
            this.label14.Text = "Director:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(375, 195);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(143, 42);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarNuevo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevo.Location = new System.Drawing.Point(524, 195);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(219, 42);
            this.btnAgregarNuevo.TabIndex = 10;
            this.btnAgregarNuevo.Text = "Agregar nuevo";
            this.btnAgregarNuevo.UseVisualStyleBackColor = false;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // txtNCodigo
            // 
            this.txtNCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNCodigo.Location = new System.Drawing.Point(152, 23);
            this.txtNCodigo.Name = "txtNCodigo";
            this.txtNCodigo.Size = new System.Drawing.Size(217, 22);
            this.txtNCodigo.TabIndex = 11;
            // 
            // txtNTitulo
            // 
            this.txtNTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNTitulo.Location = new System.Drawing.Point(152, 71);
            this.txtNTitulo.Name = "txtNTitulo";
            this.txtNTitulo.Size = new System.Drawing.Size(217, 22);
            this.txtNTitulo.TabIndex = 12;
            // 
            // dtpNEstreno
            // 
            this.dtpNEstreno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNEstreno.Location = new System.Drawing.Point(152, 119);
            this.dtpNEstreno.Name = "dtpNEstreno";
            this.dtpNEstreno.Size = new System.Drawing.Size(217, 22);
            this.dtpNEstreno.TabIndex = 13;
            // 
            // nudNPrecio
            // 
            this.nudNPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNPrecio.Location = new System.Drawing.Point(152, 167);
            this.nudNPrecio.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            this.nudNPrecio.Name = "nudNPrecio";
            this.nudNPrecio.Size = new System.Drawing.Size(217, 22);
            this.nudNPrecio.TabIndex = 14;
            this.nudNPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNPrecio.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nudNDuracion
            // 
            this.nudNDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNDuracion.Location = new System.Drawing.Point(152, 215);
            this.nudNDuracion.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            this.nudNDuracion.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            this.nudNDuracion.Name = "nudNDuracion";
            this.nudNDuracion.Size = new System.Drawing.Size(217, 22);
            this.nudNDuracion.TabIndex = 15;
            this.nudNDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNDuracion.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // cmbNGenero
            // 
            this.cmbNGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNGenero.FormattingEnabled = true;
            this.cmbNGenero.Location = new System.Drawing.Point(524, 120);
            this.cmbNGenero.Name = "cmbNGenero";
            this.cmbNGenero.Size = new System.Drawing.Size(219, 24);
            this.cmbNGenero.TabIndex = 18;
            // 
            // dgvNuevaPelicula
            // 
            this.dgvNuevaPelicula.AllowUserToAddRows = false;
            this.dgvNuevaPelicula.AllowUserToDeleteRows = false;
            this.dgvNuevaPelicula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNuevaPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel5.SetColumnSpan(this.dgvNuevaPelicula, 4);
            this.dgvNuevaPelicula.Location = new System.Drawing.Point(3, 243);
            this.dgvNuevaPelicula.Name = "dgvNuevaPelicula";
            this.dgvNuevaPelicula.ReadOnly = true;
            this.dgvNuevaPelicula.Size = new System.Drawing.Size(740, 237);
            this.dgvNuevaPelicula.TabIndex = 20;
            // 
            // tabModP
            // 
            this.tabModP.Location = new System.Drawing.Point(4, 28);
            this.tabModP.Name = "tabModP";
            this.tabModP.Size = new System.Drawing.Size(752, 477);
            this.tabModP.TabIndex = 3;
            this.tabModP.Text = "Modificar Pel";
            this.tabModP.UseVisualStyleBackColor = true;
            // 
            // tabEliminarP
            // 
            this.tabEliminarP.Location = new System.Drawing.Point(4, 28);
            this.tabEliminarP.Name = "tabEliminarP";
            this.tabEliminarP.Size = new System.Drawing.Size(752, 477);
            this.tabEliminarP.TabIndex = 4;
            this.tabEliminarP.Text = "Eliminar Pel";
            this.tabEliminarP.UseVisualStyleBackColor = true;
            // 
            // tabNuevaR
            // 
            this.tabNuevaR.Location = new System.Drawing.Point(4, 28);
            this.tabNuevaR.Name = "tabNuevaR";
            this.tabNuevaR.Size = new System.Drawing.Size(752, 477);
            this.tabNuevaR.TabIndex = 5;
            this.tabNuevaR.Text = "Nueva Ren";
            this.tabNuevaR.UseVisualStyleBackColor = true;
            // 
            // tabVerR
            // 
            this.tabVerR.Location = new System.Drawing.Point(4, 28);
            this.tabVerR.Name = "tabVerR";
            this.tabVerR.Size = new System.Drawing.Size(752, 477);
            this.tabVerR.TabIndex = 6;
            this.tabVerR.Text = "Ver Ren";
            this.tabVerR.UseVisualStyleBackColor = true;
            // 
            // mstMenuSuperior
            // 
            this.mstMenuSuperior.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mstMenuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.btnMenuInicio, this.btnMenuBúsqueda, this.accionesToolStripMenuItem, this.rentaToolStripMenuItem });
            this.mstMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.mstMenuSuperior.Name = "mstMenuSuperior";
            this.mstMenuSuperior.Size = new System.Drawing.Size(784, 24);
            this.mstMenuSuperior.TabIndex = 2;
            this.mstMenuSuperior.Text = "menuStrip1";
            // 
            // btnMenuInicio
            // 
            this.btnMenuInicio.Name = "btnMenuInicio";
            this.btnMenuInicio.Size = new System.Drawing.Size(48, 20);
            this.btnMenuInicio.Text = "Inicio";
            this.btnMenuInicio.Click += new System.EventHandler(this.btnMenuInicio_Click);
            // 
            // btnMenuBúsqueda
            // 
            this.btnMenuBúsqueda.Name = "btnMenuBúsqueda";
            this.btnMenuBúsqueda.Size = new System.Drawing.Size(71, 20);
            this.btnMenuBúsqueda.Text = "Búsqueda";
            this.btnMenuBúsqueda.Click += new System.EventHandler(this.btnMenuBúsqueda_Click);
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.btnMenuNuevaPelicula, this.btnMenuModificarPelicula, this.btnMenuElliminarPelicula });
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // btnMenuNuevaPelicula
            // 
            this.btnMenuNuevaPelicula.Name = "btnMenuNuevaPelicula";
            this.btnMenuNuevaPelicula.Size = new System.Drawing.Size(219, 22);
            this.btnMenuNuevaPelicula.Text = "Crear nueva película";
            this.btnMenuNuevaPelicula.Click += new System.EventHandler(this.btnMenuNuevaPelicula_Click);
            // 
            // btnMenuModificarPelicula
            // 
            this.btnMenuModificarPelicula.AutoToolTip = true;
            this.btnMenuModificarPelicula.Enabled = false;
            this.btnMenuModificarPelicula.Name = "btnMenuModificarPelicula";
            this.btnMenuModificarPelicula.Size = new System.Drawing.Size(219, 22);
            this.btnMenuModificarPelicula.Text = "Modificar película existente";
            this.btnMenuModificarPelicula.ToolTipText = "En desarrollo";
            // 
            // btnMenuElliminarPelicula
            // 
            this.btnMenuElliminarPelicula.AutoToolTip = true;
            this.btnMenuElliminarPelicula.Enabled = false;
            this.btnMenuElliminarPelicula.Name = "btnMenuElliminarPelicula";
            this.btnMenuElliminarPelicula.Size = new System.Drawing.Size(219, 22);
            this.btnMenuElliminarPelicula.Text = "Eliminar película existente";
            this.btnMenuElliminarPelicula.ToolTipText = "En desarrollo";
            // 
            // rentaToolStripMenuItem
            // 
            this.rentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.btnMenuNuevaRenta, this.btnMenuVerRenta });
            this.rentaToolStripMenuItem.Name = "rentaToolStripMenuItem";
            this.rentaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.rentaToolStripMenuItem.Text = "Renta";
            // 
            // btnMenuNuevaRenta
            // 
            this.btnMenuNuevaRenta.AutoToolTip = true;
            this.btnMenuNuevaRenta.Enabled = false;
            this.btnMenuNuevaRenta.Name = "btnMenuNuevaRenta";
            this.btnMenuNuevaRenta.Size = new System.Drawing.Size(180, 22);
            this.btnMenuNuevaRenta.Text = "Añadir nueva renta";
            this.btnMenuNuevaRenta.ToolTipText = "En desarrollo";
            // 
            // btnMenuVerRenta
            // 
            this.btnMenuVerRenta.AutoToolTip = true;
            this.btnMenuVerRenta.Enabled = false;
            this.btnMenuVerRenta.Name = "btnMenuVerRenta";
            this.btnMenuVerRenta.Size = new System.Drawing.Size(180, 22);
            this.btnMenuVerRenta.Text = "Ver rentas existentes";
            this.btnMenuVerRenta.ToolTipText = "En desarrollo";
            // 
            // ttpIncompleto
            // 
            this.ttpIncompleto.IsBalloon = true;
            this.ttpIncompleto.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.ttpIncompleto.ToolTipTitle = "En desarrollo";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.sstBarraInferior);
            this.Controls.Add(this.mstMenuSuperior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstMenuSuperior;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a Blockbuster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.sstBarraInferior.ResumeLayout(false);
            this.sstBarraInferior.PerformLayout();
            this.tabPrincipal.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabBusqueda.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabInterior.ResumeLayout(false);
            this.tabTitulo.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulo)).EndInit();
            this.tabGenero.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).EndInit();
            this.tabNuevaP.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevaPelicula)).EndInit();
            this.mstMenuSuperior.ResumeLayout(false);
            this.mstMenuSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;

        private System.Windows.Forms.ToolTip ttpIncompleto;

        private System.Windows.Forms.ComboBox cmbNDirector;
        private System.Windows.Forms.DataGridView dgvNuevaPelicula;

        private System.Windows.Forms.ComboBox cmbNGenero;

        private System.Windows.Forms.TextBox txtNDescripcion;

        private System.Windows.Forms.NumericUpDown nudNStock;

        private System.Windows.Forms.NumericUpDown nudNDuracion;

        private System.Windows.Forms.NumericUpDown nudNPrecio;

        private System.Windows.Forms.TextBox txtNTitulo;
        private System.Windows.Forms.DateTimePicker dtpNEstreno;

        private System.Windows.Forms.TextBox txtNCodigo;

        private System.Windows.Forms.Button btnAgregarNuevo;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLimpiar;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

        private System.Windows.Forms.DataGridView dgvTitulo;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBusquedaGenero;
        private System.Windows.Forms.ComboBox cmbBusquedaGenero;

        private System.Windows.Forms.DataGridView dgvGenero;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBusquedaTitulo;
        private System.Windows.Forms.Button btnBusquedaTitulo;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoBusqueda;
        private System.Windows.Forms.TabControl tabInterior;
        private System.Windows.Forms.TabPage tabTitulo;
        private System.Windows.Forms.TabPage tabGenero;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.TabPage tabNuevaP;
        private System.Windows.Forms.TabPage tabModP;
        private System.Windows.Forms.TabPage tabEliminarP;
        private System.Windows.Forms.TabPage tabNuevaR;
        private System.Windows.Forms.TabPage tabVerR;

        private System.Windows.Forms.ToolStripMenuItem btnMenuInicio;
        private System.Windows.Forms.ToolStripMenuItem btnMenuBúsqueda;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuNuevaPelicula;
        private System.Windows.Forms.ToolStripMenuItem btnMenuModificarPelicula;
        private System.Windows.Forms.ToolStripMenuItem btnMenuElliminarPelicula;
        private System.Windows.Forms.ToolStripMenuItem rentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuNuevaRenta;
        private System.Windows.Forms.ToolStripMenuItem btnMenuVerRenta;

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.MenuStrip mstMenuSuperior;

        private System.Windows.Forms.ToolStripStatusLabel lblBienvenida;

        private System.Windows.Forms.StatusStrip sstBarraInferior;

        #endregion
    }
}