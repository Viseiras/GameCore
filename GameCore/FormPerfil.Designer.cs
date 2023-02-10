
namespace GameCore
{
    partial class FormPerfil
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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.label_miColeccion = new System.Windows.Forms.Label();
            this.toolStrip_menuInferior = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_ajustes = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_esconder = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip_botonFlecha = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.label_nombreUsuario = new System.Windows.Forms.Label();
            this.tsMenuCerrado = new System.Windows.Forms.ToolStrip();
            this.tslblDeplegar = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnRegresa = new System.Windows.Forms.ToolStripButton();
            this.label_idioma = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_ajustes_por_defecto = new System.Windows.Forms.Button();
            this.boton_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_VistaVacia = new System.Windows.Forms.MenuStrip();
            this.boton_perfil_menu_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_sistema_menu_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_salir_programa_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxCambiarFotoPerfil = new System.Windows.Forms.PictureBox();
            this.btnCambiarImagen = new System.Windows.Forms.Button();
            this.toogleBoxCustomDarkMode = new GameCore.ToogleBoxCustom();
            this.panelLateral.SuspendLayout();
            this.toolStrip_menuInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfil)).BeginInit();
            this.tsMenuCerrado.SuspendLayout();
            this.menu_VistaVacia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCambiarFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panelLateral.Controls.Add(this.label_miColeccion);
            this.panelLateral.Controls.Add(this.toolStrip_menuInferior);
            this.panelLateral.Controls.Add(this.pictureBoxFotoPerfil);
            this.panelLateral.Controls.Add(this.label_nombreUsuario);
            this.panelLateral.Location = new System.Drawing.Point(1, 27);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(4);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(245, 561);
            this.panelLateral.TabIndex = 0;
            // 
            // label_miColeccion
            // 
            this.label_miColeccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_miColeccion.AutoSize = true;
            this.label_miColeccion.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_miColeccion.ForeColor = System.Drawing.Color.White;
            this.label_miColeccion.Location = new System.Drawing.Point(66, 232);
            this.label_miColeccion.Name = "label_miColeccion";
            this.label_miColeccion.Size = new System.Drawing.Size(109, 23);
            this.label_miColeccion.TabIndex = 4;
            this.label_miColeccion.Text = "Mi colección";
            // 
            // toolStrip_menuInferior
            // 
            this.toolStrip_menuInferior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip_menuInferior.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_menuInferior.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.toolStrip_menuInferior.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_menuInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStrip_ajustes,
            this.toolStripSeparator1,
            this.toolStrip_esconder,
            this.toolStrip_botonFlecha});
            this.toolStrip_menuInferior.Location = new System.Drawing.Point(0, 530);
            this.toolStrip_menuInferior.Name = "toolStrip_menuInferior";
            this.toolStrip_menuInferior.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip_menuInferior.ShowItemToolTips = false;
            this.toolStrip_menuInferior.Size = new System.Drawing.Size(220, 31);
            this.toolStrip_menuInferior.TabIndex = 3;
            this.toolStrip_menuInferior.Text = "Menu";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::GameCore.Properties.Resources.settings;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStrip_ajustes
            // 
            this.toolStrip_ajustes.AutoToolTip = true;
            this.toolStrip_ajustes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip_ajustes.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStrip_ajustes.Name = "toolStrip_ajustes";
            this.toolStrip_ajustes.Size = new System.Drawing.Size(64, 30);
            this.toolStrip_ajustes.Text = "Ajustes";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStrip_esconder
            // 
            this.toolStrip_esconder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip_esconder.Name = "toolStrip_esconder";
            this.toolStrip_esconder.Size = new System.Drawing.Size(79, 28);
            this.toolStrip_esconder.Text = "Esconder";
            this.toolStrip_esconder.Click += new System.EventHandler(this.esconder_click);
            // 
            // toolStrip_botonFlecha
            // 
            this.toolStrip_botonFlecha.BackgroundImage = global::GameCore.Properties.Resources.settings;
            this.toolStrip_botonFlecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_botonFlecha.Image = global::GameCore.Properties.Resources.hidepanel;
            this.toolStrip_botonFlecha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_botonFlecha.Name = "toolStrip_botonFlecha";
            this.toolStrip_botonFlecha.Size = new System.Drawing.Size(29, 28);
            this.toolStrip_botonFlecha.Text = "toolStripButton3";
            this.toolStrip_botonFlecha.Click += new System.EventHandler(this.esconder_click);
            // 
            // pictureBoxFotoPerfil
            // 
            this.pictureBoxFotoPerfil.Image = global::GameCore.Properties.Resources.foto_perfil_vacia;
            this.pictureBoxFotoPerfil.Location = new System.Drawing.Point(51, 32);
            this.pictureBoxFotoPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFotoPerfil.Name = "pictureBoxFotoPerfil";
            this.pictureBoxFotoPerfil.Size = new System.Drawing.Size(124, 100);
            this.pictureBoxFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFotoPerfil.TabIndex = 2;
            this.pictureBoxFotoPerfil.TabStop = false;
            // 
            // label_nombreUsuario
            // 
            this.label_nombreUsuario.AutoSize = true;
            this.label_nombreUsuario.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombreUsuario.ForeColor = System.Drawing.Color.White;
            this.label_nombreUsuario.Location = new System.Drawing.Point(75, 148);
            this.label_nombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nombreUsuario.MaximumSize = new System.Drawing.Size(100, 100);
            this.label_nombreUsuario.Name = "label_nombreUsuario";
            this.label_nombreUsuario.Size = new System.Drawing.Size(86, 75);
            this.label_nombreUsuario.TabIndex = 1;
            this.label_nombreUsuario.Text = "Nombre de usuario";
            // 
            // tsMenuCerrado
            // 
            this.tsMenuCerrado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsMenuCerrado.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMenuCerrado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenuCerrado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenuCerrado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblDeplegar,
            this.tsbtnRegresa});
            this.tsMenuCerrado.Location = new System.Drawing.Point(0, 552);
            this.tsMenuCerrado.Name = "tsMenuCerrado";
            this.tsMenuCerrado.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsMenuCerrado.Size = new System.Drawing.Size(109, 31);
            this.tsMenuCerrado.TabIndex = 3;
            this.tsMenuCerrado.Text = "Desplegar ";
            this.tsMenuCerrado.Visible = false;
            // 
            // tslblDeplegar
            // 
            this.tslblDeplegar.Name = "tslblDeplegar";
            this.tslblDeplegar.Size = new System.Drawing.Size(77, 28);
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
            this.tsbtnRegresa.Size = new System.Drawing.Size(29, 28);
            this.tsbtnRegresa.Click += new System.EventHandler(this.desplegar_click);
            // 
            // label_idioma
            // 
            this.label_idioma.AutoSize = true;
            this.label_idioma.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idioma.Location = new System.Drawing.Point(298, 112);
            this.label_idioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_idioma.Name = "label_idioma";
            this.label_idioma.Size = new System.Drawing.Size(77, 28);
            this.label_idioma.TabIndex = 4;
            this.label_idioma.Text = "Idioma";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Español",
            "Portugués",
            "Inglés"});
            this.comboBox1.Location = new System.Drawing.Point(463, 112);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // button_ajustes_por_defecto
            // 
            this.button_ajustes_por_defecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ajustes_por_defecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button_ajustes_por_defecto.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajustes_por_defecto.ForeColor = System.Drawing.Color.White;
            this.button_ajustes_por_defecto.Location = new System.Drawing.Point(713, 516);
            this.button_ajustes_por_defecto.Margin = new System.Windows.Forms.Padding(4);
            this.button_ajustes_por_defecto.Name = "button_ajustes_por_defecto";
            this.button_ajustes_por_defecto.Size = new System.Drawing.Size(184, 54);
            this.button_ajustes_por_defecto.TabIndex = 6;
            this.button_ajustes_por_defecto.Text = "Ajustes por defecto";
            this.button_ajustes_por_defecto.UseVisualStyleBackColor = false;
            this.button_ajustes_por_defecto.Click += new System.EventHandler(this.button_ajustes_por_defecto_Click);
            // 
            // boton_guardar
            // 
            this.boton_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.boton_guardar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_guardar.ForeColor = System.Drawing.Color.White;
            this.boton_guardar.Location = new System.Drawing.Point(905, 516);
            this.boton_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.boton_guardar.Name = "boton_guardar";
            this.boton_guardar.Size = new System.Drawing.Size(165, 54);
            this.boton_guardar.TabIndex = 7;
            this.boton_guardar.Text = "Guardar";
            this.boton_guardar.UseVisualStyleBackColor = false;
            this.boton_guardar.Click += new System.EventHandler(this.boton_guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cambiar tema";
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
            this.menu_VistaVacia.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu_VistaVacia.Size = new System.Drawing.Size(1083, 30);
            this.menu_VistaVacia.TabIndex = 10;
            this.menu_VistaVacia.Text = "menuStrip1";
            // 
            // boton_perfil_menu_strip
            // 
            this.boton_perfil_menu_strip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.ajustesToolStripMenuItem});
            this.boton_perfil_menu_strip.ForeColor = System.Drawing.Color.White;
            this.boton_perfil_menu_strip.Name = "boton_perfil_menu_strip";
            this.boton_perfil_menu_strip.Size = new System.Drawing.Size(56, 26);
            this.boton_perfil_menu_strip.Text = "Perfil";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // boton_sistema_menu_strip
            // 
            this.boton_sistema_menu_strip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boton_salir_programa_menu});
            this.boton_sistema_menu_strip.ForeColor = System.Drawing.Color.White;
            this.boton_sistema_menu_strip.Name = "boton_sistema_menu_strip";
            this.boton_sistema_menu_strip.Size = new System.Drawing.Size(75, 26);
            this.boton_sistema_menu_strip.Text = "Sistema";
            // 
            // boton_salir_programa_menu
            // 
            this.boton_salir_programa_menu.Name = "boton_salir_programa_menu";
            this.boton_salir_programa_menu.Size = new System.Drawing.Size(216, 26);
            this.boton_salir_programa_menu.Text = "Salir del programa";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // pictureBoxCambiarFotoPerfil
            // 
            this.pictureBoxCambiarFotoPerfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxCambiarFotoPerfil.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBoxCambiarFotoPerfil.Image = global::GameCore.Properties.Resources.foto_perfil_vacia;
            this.pictureBoxCambiarFotoPerfil.Location = new System.Drawing.Point(859, 59);
            this.pictureBoxCambiarFotoPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCambiarFotoPerfil.Name = "pictureBoxCambiarFotoPerfil";
            this.pictureBoxCambiarFotoPerfil.Size = new System.Drawing.Size(156, 138);
            this.pictureBoxCambiarFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCambiarFotoPerfil.TabIndex = 20;
            this.pictureBoxCambiarFotoPerfil.TabStop = false;
            this.pictureBoxCambiarFotoPerfil.Click += new System.EventHandler(this.pictureBoxFotoPerfil_Click);
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCambiarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCambiarImagen.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarImagen.ForeColor = System.Drawing.Color.White;
            this.btnCambiarImagen.Location = new System.Drawing.Point(884, 205);
            this.btnCambiarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(108, 77);
            this.btnCambiarImagen.TabIndex = 21;
            this.btnCambiarImagen.Text = "Cambiar imagen ";
            this.btnCambiarImagen.UseVisualStyleBackColor = false;
            this.btnCambiarImagen.Click += new System.EventHandler(this.btCambiarImagen_Click);
            // 
            // toogleBoxCustomDarkMode
            // 
            this.toogleBoxCustomDarkMode.AutoSize = true;
            this.toogleBoxCustomDarkMode.Location = new System.Drawing.Point(463, 60);
            this.toogleBoxCustomDarkMode.Margin = new System.Windows.Forms.Padding(4);
            this.toogleBoxCustomDarkMode.MinimumSize = new System.Drawing.Size(60, 27);
            this.toogleBoxCustomDarkMode.Name = "toogleBoxCustomDarkMode";
            this.toogleBoxCustomDarkMode.Size = new System.Drawing.Size(199, 27);
            this.toogleBoxCustomDarkMode.TabIndex = 8;
            this.toogleBoxCustomDarkMode.Text = "toogleBoxCustomDarkMode";
            this.toogleBoxCustomDarkMode.UseVisualStyleBackColor = true;
            this.toogleBoxCustomDarkMode.CheckedChanged += new System.EventHandler(this.toogleBoxCustomDarkMode_CheckedChanged);
            // 
            // FormPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 583);
            this.Controls.Add(this.btnCambiarImagen);
            this.Controls.Add(this.pictureBoxCambiarFotoPerfil);
            this.Controls.Add(this.menu_VistaVacia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toogleBoxCustomDarkMode);
            this.Controls.Add(this.boton_guardar);
            this.Controls.Add(this.button_ajustes_por_defecto);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_idioma);
            this.Controls.Add(this.tsMenuCerrado);
            this.Controls.Add(this.panelLateral);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPerfil";
            this.Text = "FormaPerfil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPerfil_Load_1);
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.toolStrip_menuInferior.ResumeLayout(false);
            this.toolStrip_menuInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfil)).EndInit();
            this.tsMenuCerrado.ResumeLayout(false);
            this.tsMenuCerrado.PerformLayout();
            this.menu_VistaVacia.ResumeLayout(false);
            this.menu_VistaVacia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCambiarFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.PictureBox pictureBoxFotoPerfil;
        private System.Windows.Forms.Label label_nombreUsuario;
        private System.Windows.Forms.ToolStrip toolStrip_menuInferior;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStrip_ajustes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStrip_esconder;
        private System.Windows.Forms.ToolStripButton toolStrip_botonFlecha;
        private System.Windows.Forms.ToolStrip tsMenuCerrado;
        private System.Windows.Forms.ToolStripLabel tslblDeplegar;
        private System.Windows.Forms.ToolStripButton tsbtnRegresa;
        private System.Windows.Forms.Label label_idioma;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_ajustes_por_defecto;
        private System.Windows.Forms.Button boton_guardar;
        private ToogleBoxCustom toogleBoxCustomDarkMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menu_VistaVacia;
        private System.Windows.Forms.ToolStripMenuItem boton_perfil_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boton_sistema_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem boton_salir_programa_menu;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label label_miColeccion;
        private System.Windows.Forms.PictureBox pictureBoxCambiarFotoPerfil;
        private System.Windows.Forms.Button btnCambiarImagen;
    }
}