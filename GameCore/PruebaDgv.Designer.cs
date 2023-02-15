namespace GameCore
{
    partial class PruebaDgv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PruebaDgv));
            this.dgvVideojuegos = new System.Windows.Forms.DataGridView();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.label_vistaLista = new System.Windows.Forms.Label();
            this.label_cerrarSesion = new System.Windows.Forms.Label();
            this.pictureBox_cerrarSesion = new System.Windows.Forms.PictureBox();
            this.label_nombreUsuario = new System.Windows.Forms.Label();
            this.pictureBox_ImagenPerfil = new System.Windows.Forms.PictureBox();
            this.toolStrip__menuInferior = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tslblSettings = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblexit = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menu_VistaVacia = new System.Windows.Forms.MenuStrip();
            this.boton_perfil_menu_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_sistema_menu_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_salir_programa_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Portada = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).BeginInit();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImagenPerfil)).BeginInit();
            this.toolStrip__menuInferior.SuspendLayout();
            this.menu_VistaVacia.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVideojuegos
            // 
            this.dgvVideojuegos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVideojuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideojuegos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Descripcion,
            this.Portada});
            this.dgvVideojuegos.Location = new System.Drawing.Point(271, 73);
            this.dgvVideojuegos.Name = "dgvVideojuegos";
            this.dgvVideojuegos.RowHeadersWidth = 51;
            this.dgvVideojuegos.RowTemplate.Height = 24;
            this.dgvVideojuegos.Size = new System.Drawing.Size(911, 500);
            this.dgvVideojuegos.TabIndex = 0;
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
            this.panelLateral.Location = new System.Drawing.Point(0, 23);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(4);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(255, 563);
            this.panelLateral.TabIndex = 2;
            // 
            // label_vistaLista
            // 
            this.label_vistaLista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_vistaLista.AutoSize = true;
            this.label_vistaLista.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vistaLista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_vistaLista.Location = new System.Drawing.Point(61, 276);
            this.label_vistaLista.MaximumSize = new System.Drawing.Size(100, 100);
            this.label_vistaLista.Name = "label_vistaLista";
            this.label_vistaLista.Size = new System.Drawing.Size(94, 25);
            this.label_vistaLista.TabIndex = 98;
            this.label_vistaLista.Text = "Vista lista";
            this.label_vistaLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_cerrarSesion
            // 
            this.label_cerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_cerrarSesion.AutoSize = true;
            this.label_cerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_cerrarSesion.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cerrarSesion.ForeColor = System.Drawing.Color.White;
            this.label_cerrarSesion.Location = new System.Drawing.Point(76, 476);
            this.label_cerrarSesion.Name = "label_cerrarSesion";
            this.label_cerrarSesion.Size = new System.Drawing.Size(113, 23);
            this.label_cerrarSesion.TabIndex = 97;
            this.label_cerrarSesion.Text = "Cerrar sesión";
            // 
            // pictureBox_cerrarSesion
            // 
            this.pictureBox_cerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox_cerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_cerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_cerrarSesion.Image")));
            this.pictureBox_cerrarSesion.Location = new System.Drawing.Point(12, 458);
            this.pictureBox_cerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_cerrarSesion.Name = "pictureBox_cerrarSesion";
            this.pictureBox_cerrarSesion.Size = new System.Drawing.Size(59, 50);
            this.pictureBox_cerrarSesion.TabIndex = 5;
            this.pictureBox_cerrarSesion.TabStop = false;
            // 
            // label_nombreUsuario
            // 
            this.label_nombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_nombreUsuario.AutoSize = true;
            this.label_nombreUsuario.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_nombreUsuario.Location = new System.Drawing.Point(61, 190);
            this.label_nombreUsuario.MaximumSize = new System.Drawing.Size(100, 100);
            this.label_nombreUsuario.Name = "label_nombreUsuario";
            this.label_nombreUsuario.Size = new System.Drawing.Size(94, 50);
            this.label_nombreUsuario.TabIndex = 0;
            this.label_nombreUsuario.Text = "NombreUsuario";
            this.label_nombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_ImagenPerfil
            // 
            this.pictureBox_ImagenPerfil.Image = global::GameCore.Properties.Resources.foto_perfil_vacia;
            this.pictureBox_ImagenPerfil.Location = new System.Drawing.Point(37, 27);
            this.pictureBox_ImagenPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_ImagenPerfil.Name = "pictureBox_ImagenPerfil";
            this.pictureBox_ImagenPerfil.Size = new System.Drawing.Size(149, 148);
            this.pictureBox_ImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ImagenPerfil.TabIndex = 3;
            this.pictureBox_ImagenPerfil.TabStop = false;
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
            this.toolStrip__menuInferior.Location = new System.Drawing.Point(0, 539);
            this.toolStrip__menuInferior.Name = "toolStrip__menuInferior";
            this.toolStrip__menuInferior.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip__menuInferior.ShowItemToolTips = false;
            this.toolStrip__menuInferior.Size = new System.Drawing.Size(220, 27);
            this.toolStrip__menuInferior.TabIndex = 95;
            this.toolStrip__menuInferior.Text = "Menu";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::GameCore.Properties.Resources.settings;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // tslblSettings
            // 
            this.tslblSettings.AutoToolTip = true;
            this.tslblSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tslblSettings.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tslblSettings.Name = "tslblSettings";
            this.tslblSettings.Size = new System.Drawing.Size(64, 26);
            this.tslblSettings.Text = "Ajustes";
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
            this.tslblexit.Size = new System.Drawing.Size(79, 24);
            this.tslblexit.Text = "Esconder";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.BackgroundImage = global::GameCore.Properties.Resources.settings;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::GameCore.Properties.Resources.hidepanel;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
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
            this.menu_VistaVacia.Size = new System.Drawing.Size(1199, 30);
            this.menu_VistaVacia.TabIndex = 100;
            this.menu_VistaVacia.Text = "menuStrip1";
            // 
            // boton_perfil_menu_strip
            // 
            this.boton_perfil_menu_strip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.ajustesToolStripMenuItem});
            this.boton_perfil_menu_strip.ForeColor = System.Drawing.Color.White;
            this.boton_perfil_menu_strip.Name = "boton_perfil_menu_strip";
            this.boton_perfil_menu_strip.Size = new System.Drawing.Size(56, 24);
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
            this.boton_sistema_menu_strip.Size = new System.Drawing.Size(75, 24);
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
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            // 
            // Portada
            // 
            this.Portada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Portada.HeaderText = "Portada";
            this.Portada.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Portada.MinimumWidth = 6;
            this.Portada.Name = "Portada";
            // 
            // PruebaDgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 585);
            this.Controls.Add(this.menu_VistaVacia);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.dgvVideojuegos);
            this.Name = "PruebaDgv";
            this.Text = "PruebaDgv";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PruebaDgv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImagenPerfil)).EndInit();
            this.toolStrip__menuInferior.ResumeLayout(false);
            this.toolStrip__menuInferior.PerformLayout();
            this.menu_VistaVacia.ResumeLayout(false);
            this.menu_VistaVacia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVideojuegos;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Label label_vistaLista;
        private System.Windows.Forms.Label label_cerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox_cerrarSesion;
        private System.Windows.Forms.Label label_nombreUsuario;
        private System.Windows.Forms.PictureBox pictureBox_ImagenPerfil;
        private System.Windows.Forms.ToolStrip toolStrip__menuInferior;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel tslblSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslblexit;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.MenuStrip menu_VistaVacia;
        private System.Windows.Forms.ToolStripMenuItem boton_perfil_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boton_sistema_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem boton_salir_programa_menu;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewImageColumn Portada;
    }
}