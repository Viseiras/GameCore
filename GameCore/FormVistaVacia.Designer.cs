
namespace GameCore
{
    partial class FormVistaVacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVistaVacia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsMenuCerrado = new System.Windows.Forms.ToolStrip();
            this.tslblDeplegar = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnRegresa = new System.Windows.Forms.ToolStripButton();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.toolStrip__menuInferior = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tslblSettings = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblexit = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.label_vistaLista = new System.Windows.Forms.Label();
            this.label_cerrarSesion = new System.Windows.Forms.Label();
            this.pictureBox_cerrarSesion = new System.Windows.Forms.PictureBox();
            this.label_nombreUsuario = new System.Windows.Forms.Label();
            this.pictureBox_ImagenPerfil = new System.Windows.Forms.PictureBox();
            this.menu_VistaVacia = new System.Windows.Forms.MenuStrip();
            this.boton_perfil_menu_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_sistema_menu_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_salir_programa_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.flVistaVacia = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.label_mostrarColeccion = new System.Windows.Forms.Label();
            this.pictureBox_mostrarColeccion = new System.Windows.Forms.PictureBox();
            this.dgvVideojuegos = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Portada = new System.Windows.Forms.DataGridViewImageColumn();
            this.tsMenuCerrado.SuspendLayout();
            this.toolStrip__menuInferior.SuspendLayout();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImagenPerfil)).BeginInit();
            this.menu_VistaVacia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mostrarColeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenuCerrado
            // 
            this.tsMenuCerrado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMenuCerrado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenuCerrado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenuCerrado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblDeplegar,
            this.tsbtnRegresa});
            this.tsMenuCerrado.Location = new System.Drawing.Point(0, 455);
            this.tsMenuCerrado.Name = "tsMenuCerrado";
            this.tsMenuCerrado.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsMenuCerrado.Size = new System.Drawing.Size(837, 27);
            this.tsMenuCerrado.TabIndex = 2;
            this.tsMenuCerrado.Text = "Desplegar ";
            this.tsMenuCerrado.Visible = false;
            // 
            // tslblDeplegar
            // 
            this.tslblDeplegar.Name = "tslblDeplegar";
            this.tslblDeplegar.Size = new System.Drawing.Size(59, 24);
            this.tslblDeplegar.Text = "Desplegar";
            this.tslblDeplegar.Click += new System.EventHandler(this.desplegar_click);
            // 
            // tsbtnRegresa
            // 
            this.tsbtnRegresa.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnRegresa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRegresa.Image = global::GameCore.Properties.Resources.showpanel;
            this.tsbtnRegresa.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsbtnRegresa.Name = "tsbtnRegresa";
            this.tsbtnRegresa.Size = new System.Drawing.Size(24, 24);
            this.tsbtnRegresa.Click += new System.EventHandler(this.desplegar_click);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // toolStrip__menuInferior
            // 
            this.toolStrip__menuInferior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.toolStrip__menuInferior.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip__menuInferior.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.toolStrip__menuInferior.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip__menuInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tslblSettings,
            this.toolStripSeparator1,
            this.tslblexit,
            this.toolStripButton3});
            this.toolStrip__menuInferior.Location = new System.Drawing.Point(0, 431);
            this.toolStrip__menuInferior.Name = "toolStrip__menuInferior";
            this.toolStrip__menuInferior.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip__menuInferior.ShowItemToolTips = false;
            this.toolStrip__menuInferior.Size = new System.Drawing.Size(183, 27);
            this.toolStrip__menuInferior.TabIndex = 6;
            this.toolStrip__menuInferior.Text = "Menu";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::GameCore.Properties.Resources.settings;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.Settings_Click);
            // 
            // tslblSettings
            // 
            this.tslblSettings.AutoToolTip = true;
            this.tslblSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tslblSettings.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tslblSettings.Name = "tslblSettings";
            this.tslblSettings.Size = new System.Drawing.Size(53, 26);
            this.tslblSettings.Text = "Ajustes";
            this.tslblSettings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tslblexit
            // 
            this.tslblexit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tslblexit.Name = "tslblexit";
            this.tslblexit.Size = new System.Drawing.Size(64, 24);
            this.tslblexit.Text = "Esconder";
            this.tslblexit.Click += new System.EventHandler(this.esconder_click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.BackgroundImage = global::GameCore.Properties.Resources.settings;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::GameCore.Properties.Resources.hidepanel;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.esconder_click);
            // 
            // panelLateral
            // 
            this.panelLateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panelLateral.Controls.Add(this.label_vistaLista);
            this.panelLateral.Controls.Add(this.label_cerrarSesion);
            this.panelLateral.Controls.Add(this.pictureBox_cerrarSesion);
            this.panelLateral.Controls.Add(this.label_nombreUsuario);
            this.panelLateral.Controls.Add(this.pictureBox_ImagenPerfil);
            this.panelLateral.Controls.Add(this.toolStrip__menuInferior);
            this.panelLateral.Location = new System.Drawing.Point(0, 22);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(191, 455);
            this.panelLateral.TabIndex = 1;
            // 
            // label_vistaLista
            // 
            this.label_vistaLista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_vistaLista.AutoSize = true;
            this.label_vistaLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_vistaLista.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vistaLista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_vistaLista.Location = new System.Drawing.Point(46, 224);
            this.label_vistaLista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_vistaLista.MaximumSize = new System.Drawing.Size(75, 81);
            this.label_vistaLista.Name = "label_vistaLista";
            this.label_vistaLista.Size = new System.Drawing.Size(44, 40);
            this.label_vistaLista.TabIndex = 1;
            this.label_vistaLista.Text = "Vista lista";
            this.label_vistaLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_vistaLista.Click += new System.EventHandler(this.label_vistaLista_Click);
            // 
            // label_cerrarSesion
            // 
            this.label_cerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_cerrarSesion.AutoSize = true;
            this.label_cerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_cerrarSesion.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cerrarSesion.ForeColor = System.Drawing.Color.White;
            this.label_cerrarSesion.Location = new System.Drawing.Point(57, 384);
            this.label_cerrarSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cerrarSesion.Name = "label_cerrarSesion";
            this.label_cerrarSesion.Size = new System.Drawing.Size(97, 19);
            this.label_cerrarSesion.TabIndex = 7;
            this.label_cerrarSesion.Text = "Cerrar sesión";
            this.label_cerrarSesion.Click += new System.EventHandler(this.label_cerrarSesion_Click);
            // 
            // pictureBox_cerrarSesion
            // 
            this.pictureBox_cerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox_cerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_cerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_cerrarSesion.Image")));
            this.pictureBox_cerrarSesion.Location = new System.Drawing.Point(9, 370);
            this.pictureBox_cerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_cerrarSesion.Name = "pictureBox_cerrarSesion";
            this.pictureBox_cerrarSesion.Size = new System.Drawing.Size(44, 41);
            this.pictureBox_cerrarSesion.TabIndex = 5;
            this.pictureBox_cerrarSesion.TabStop = false;
            this.pictureBox_cerrarSesion.Click += new System.EventHandler(this.pictureBox_cerrarSesion_Click);
            // 
            // label_nombreUsuario
            // 
            this.label_nombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_nombreUsuario.AutoSize = true;
            this.label_nombreUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_nombreUsuario.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_nombreUsuario.Location = new System.Drawing.Point(46, 154);
            this.label_nombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nombreUsuario.MaximumSize = new System.Drawing.Size(75, 81);
            this.label_nombreUsuario.Name = "label_nombreUsuario";
            this.label_nombreUsuario.Size = new System.Drawing.Size(67, 40);
            this.label_nombreUsuario.TabIndex = 0;
            this.label_nombreUsuario.Text = "NombreUsuario";
            this.label_nombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_nombreUsuario.Click += new System.EventHandler(this.label_nombreUsuario_Click);
            // 
            // pictureBox_ImagenPerfil
            // 
            this.pictureBox_ImagenPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_ImagenPerfil.Image = global::GameCore.Properties.Resources.foto_perfil_vacia;
            this.pictureBox_ImagenPerfil.Location = new System.Drawing.Point(28, 22);
            this.pictureBox_ImagenPerfil.Name = "pictureBox_ImagenPerfil";
            this.pictureBox_ImagenPerfil.Size = new System.Drawing.Size(112, 120);
            this.pictureBox_ImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ImagenPerfil.TabIndex = 3;
            this.pictureBox_ImagenPerfil.TabStop = false;
            this.pictureBox_ImagenPerfil.Click += new System.EventHandler(this.Settings_Click);
            // 
            // menu_VistaVacia
            // 
            this.menu_VistaVacia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.menu_VistaVacia.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_VistaVacia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boton_perfil_menu_strip,
            this.boton_sistema_menu_strip,
            this.ayudaToolStripMenuItem});
            this.menu_VistaVacia.Location = new System.Drawing.Point(0, 0);
            this.menu_VistaVacia.Name = "menu_VistaVacia";
            this.menu_VistaVacia.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu_VistaVacia.Size = new System.Drawing.Size(837, 24);
            this.menu_VistaVacia.TabIndex = 99;
            this.menu_VistaVacia.Text = "menuStrip1";
            // 
            // boton_perfil_menu_strip
            // 
            this.boton_perfil_menu_strip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.ajustesToolStripMenuItem});
            this.boton_perfil_menu_strip.ForeColor = System.Drawing.Color.White;
            this.boton_perfil_menu_strip.Name = "boton_perfil_menu_strip";
            this.boton_perfil_menu_strip.Size = new System.Drawing.Size(46, 20);
            this.boton_perfil_menu_strip.Text = "Perfil";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            this.ajustesToolStripMenuItem.Click += new System.EventHandler(this.ajustesToolStripMenuItem_Click);
            // 
            // boton_sistema_menu_strip
            // 
            this.boton_sistema_menu_strip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boton_salir_programa_menu});
            this.boton_sistema_menu_strip.ForeColor = System.Drawing.Color.White;
            this.boton_sistema_menu_strip.Name = "boton_sistema_menu_strip";
            this.boton_sistema_menu_strip.Size = new System.Drawing.Size(60, 20);
            this.boton_sistema_menu_strip.Text = "Sistema";
            // 
            // boton_salir_programa_menu
            // 
            this.boton_salir_programa_menu.Name = "boton_salir_programa_menu";
            this.boton_salir_programa_menu.Size = new System.Drawing.Size(170, 22);
            this.boton_salir_programa_menu.Text = "Salir del programa";
            this.boton_salir_programa_menu.Click += new System.EventHandler(this.boton_salir_programa_menu_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_buscar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_buscar.Location = new System.Drawing.Point(492, 29);
            this.textBox_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(246, 23);
            this.textBox_buscar.TabIndex = 2;
            this.textBox_buscar.TextChanged += new System.EventHandler(this.textBox_buscar_TextChanged);
            this.textBox_buscar.Enter += new System.EventHandler(this.textBox_buscar_Enter);
            this.textBox_buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_buscar_KeyDown);
            this.textBox_buscar.Leave += new System.EventHandler(this.textBox_buscar_Leave);
            // 
            // button_buscar
            // 
            this.button_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_buscar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buscar.ForeColor = System.Drawing.Color.White;
            this.button_buscar.Location = new System.Drawing.Point(748, 24);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(64, 28);
            this.button_buscar.TabIndex = 3;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = false;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // flVistaVacia
            // 
            this.flVistaVacia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flVistaVacia.AutoScroll = true;
            this.flVistaVacia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flVistaVacia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.flVistaVacia.Location = new System.Drawing.Point(197, 60);
            this.flVistaVacia.Name = "flVistaVacia";
            this.flVistaVacia.Size = new System.Drawing.Size(628, 365);
            this.flVistaVacia.TabIndex = 93;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAnadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnadir.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.ForeColor = System.Drawing.Color.White;
            this.btnAnadir.Location = new System.Drawing.Point(718, 440);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(106, 37);
            this.btnAnadir.TabIndex = 4;
            this.btnAnadir.Text = "Añadir Juego";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // label_mostrarColeccion
            // 
            this.label_mostrarColeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_mostrarColeccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_mostrarColeccion.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mostrarColeccion.ForeColor = System.Drawing.Color.Black;
            this.label_mostrarColeccion.Location = new System.Drawing.Point(244, 428);
            this.label_mostrarColeccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_mostrarColeccion.Name = "label_mostrarColeccion";
            this.label_mostrarColeccion.Size = new System.Drawing.Size(188, 28);
            this.label_mostrarColeccion.TabIndex = 5;
            this.label_mostrarColeccion.Text = "Mostrar toda la colección";
            this.label_mostrarColeccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_mostrarColeccion.Click += new System.EventHandler(this.label_mostrarColeccion_Click);
            // 
            // pictureBox_mostrarColeccion
            // 
            this.pictureBox_mostrarColeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_mostrarColeccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_mostrarColeccion.Image = global::GameCore.Properties.Resources.refrescar_icon;
            this.pictureBox_mostrarColeccion.Location = new System.Drawing.Point(196, 427);
            this.pictureBox_mostrarColeccion.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_mostrarColeccion.Name = "pictureBox_mostrarColeccion";
            this.pictureBox_mostrarColeccion.Size = new System.Drawing.Size(44, 41);
            this.pictureBox_mostrarColeccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_mostrarColeccion.TabIndex = 101;
            this.pictureBox_mostrarColeccion.TabStop = false;
            this.pictureBox_mostrarColeccion.Click += new System.EventHandler(this.pictureBox_mostrarColeccion_Click);
            // 
            // dgvVideojuegos
            // 
            this.dgvVideojuegos.AllowUserToAddRows = false;
            this.dgvVideojuegos.AllowUserToDeleteRows = false;
            this.dgvVideojuegos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVideojuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideojuegos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Descripcion,
            this.Portada});
            this.dgvVideojuegos.Location = new System.Drawing.Point(196, 26);
            this.dgvVideojuegos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVideojuegos.Name = "dgvVideojuegos";
            this.dgvVideojuegos.ReadOnly = true;
            this.dgvVideojuegos.RowHeadersWidth = 51;
            this.dgvVideojuegos.RowTemplate.Height = 200;
            this.dgvVideojuegos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVideojuegos.Size = new System.Drawing.Size(630, 451);
            this.dgvVideojuegos.TabIndex = 102;
            this.dgvVideojuegos.Visible = false;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Portada
            // 
            this.Portada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Portada.HeaderText = "Portada";
            this.Portada.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Portada.MinimumWidth = 6;
            this.Portada.Name = "Portada";
            this.Portada.ReadOnly = true;
            // 
            // FormVistaVacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(837, 482);
            this.Controls.Add(this.pictureBox_mostrarColeccion);
            this.Controls.Add(this.label_mostrarColeccion);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.textBox_buscar);
            this.Controls.Add(this.menu_VistaVacia);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.flVistaVacia);
            this.Controls.Add(this.tsMenuCerrado);
            this.Controls.Add(this.dgvVideojuegos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_VistaVacia;
            this.MinimumSize = new System.Drawing.Size(560, 392);
            this.Name = "FormVistaVacia";
            this.Text = "Game Core";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVistaVacia_Load);
            this.tsMenuCerrado.ResumeLayout(false);
            this.tsMenuCerrado.PerformLayout();
            this.toolStrip__menuInferior.ResumeLayout(false);
            this.toolStrip__menuInferior.PerformLayout();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImagenPerfil)).EndInit();
            this.menu_VistaVacia.ResumeLayout(false);
            this.menu_VistaVacia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mostrarColeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsMenuCerrado;
        private System.Windows.Forms.ToolStripLabel tslblDeplegar;
        private System.Windows.Forms.ToolStripButton tsbtnRegresa;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.ToolStrip toolStrip__menuInferior;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel tslblSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslblexit;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.PictureBox pictureBox_ImagenPerfil;
        private System.Windows.Forms.Label label_nombreUsuario;
        private System.Windows.Forms.MenuStrip menu_VistaVacia;
        private System.Windows.Forms.ToolStripMenuItem boton_perfil_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem boton_sistema_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem boton_salir_programa_menu;
        private System.Windows.Forms.PictureBox pictureBox_cerrarSesion;
        private System.Windows.Forms.Label label_cerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Label label_vistaLista;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.FlowLayoutPanel flVistaVacia;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Label label_mostrarColeccion;
        private System.Windows.Forms.PictureBox pictureBox_mostrarColeccion;
        private System.Windows.Forms.DataGridView dgvVideojuegos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewImageColumn Portada;
    }
}

