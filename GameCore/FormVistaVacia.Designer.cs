﻿
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
            this.tsMenuCerrado = new System.Windows.Forms.ToolStrip();
            this.tslblDeplegar = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnRegresa = new System.Windows.Forms.ToolStripButton();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.toolStrip__menuInferior = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tslblSettings = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblexit = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.label_cerrarSesion = new System.Windows.Forms.Label();
            this.pictureBox_cerrarSesion = new System.Windows.Forms.PictureBox();
            this.label_nombreUsuario = new System.Windows.Forms.Label();
            this.pictureBox_ImagenPerfil = new System.Windows.Forms.PictureBox();
            this.flVistaVacia = new System.Windows.Forms.FlowLayoutPanel();
            this.menu_VistaVacia = new System.Windows.Forms.MenuStrip();
            this.boton_perfil_menu_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_sistema_menu_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.boton_salir_programa_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.pictureBox_buscar = new System.Windows.Forms.PictureBox();
            this.label__mostrar_coleccion = new System.Windows.Forms.Label();
            this.tsMenuCerrado.SuspendLayout();
            this.toolStrip__menuInferior.SuspendLayout();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImagenPerfil)).BeginInit();
            this.menu_VistaVacia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_buscar)).BeginInit();
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
            this.tsMenuCerrado.Location = new System.Drawing.Point(0, 566);
            this.tsMenuCerrado.Name = "tsMenuCerrado";
            this.tsMenuCerrado.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsMenuCerrado.Size = new System.Drawing.Size(1116, 27);
            this.tsMenuCerrado.TabIndex = 2;
            this.tsMenuCerrado.Text = "Desplegar ";
            this.tsMenuCerrado.Visible = false;
            // 
            // tslblDeplegar
            // 
            this.tslblDeplegar.Name = "tslblDeplegar";
            this.tslblDeplegar.Size = new System.Drawing.Size(77, 24);
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
            this.tsbtnRegresa.Size = new System.Drawing.Size(29, 24);
            this.tsbtnRegresa.Click += new System.EventHandler(this.desplegar_click);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAnadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnadir.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.ForeColor = System.Drawing.Color.White;
            this.btnAnadir.Location = new System.Drawing.Point(958, 541);
            this.btnAnadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(142, 46);
            this.btnAnadir.TabIndex = 4;
            this.btnAnadir.Text = "Añadir Juego";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
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
            this.toolStrip__menuInferior.Location = new System.Drawing.Point(0, 537);
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
            this.toolStripButton1.Click += new System.EventHandler(this.Settings_Click);
            // 
            // tslblSettings
            // 
            this.tslblSettings.AutoToolTip = true;
            this.tslblSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tslblSettings.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tslblSettings.Name = "tslblSettings";
            this.tslblSettings.Size = new System.Drawing.Size(64, 26);
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
            this.tslblexit.Size = new System.Drawing.Size(79, 24);
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
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.esconder_click);
            // 
            // panelLateral
            // 
            this.panelLateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panelLateral.Controls.Add(this.label_cerrarSesion);
            this.panelLateral.Controls.Add(this.pictureBox_cerrarSesion);
            this.panelLateral.Controls.Add(this.label_nombreUsuario);
            this.panelLateral.Controls.Add(this.pictureBox_ImagenPerfil);
            this.panelLateral.Controls.Add(this.toolStrip__menuInferior);
            this.panelLateral.Location = new System.Drawing.Point(0, 27);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(4);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(255, 560);
            this.panelLateral.TabIndex = 1;
            // 
            // label_cerrarSesion
            // 
            this.label_cerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_cerrarSesion.AutoSize = true;
            this.label_cerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_cerrarSesion.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cerrarSesion.ForeColor = System.Drawing.Color.White;
            this.label_cerrarSesion.Location = new System.Drawing.Point(76, 473);
            this.label_cerrarSesion.Name = "label_cerrarSesion";
            this.label_cerrarSesion.Size = new System.Drawing.Size(113, 23);
            this.label_cerrarSesion.TabIndex = 97;
            this.label_cerrarSesion.Text = "Cerrar sesión";
            this.label_cerrarSesion.Click += new System.EventHandler(this.label_cerrarSesion_Click);
            // 
            // pictureBox_cerrarSesion
            // 
            this.pictureBox_cerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox_cerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_cerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_cerrarSesion.Image")));
            this.pictureBox_cerrarSesion.Location = new System.Drawing.Point(12, 456);
            this.pictureBox_cerrarSesion.Name = "pictureBox_cerrarSesion";
            this.pictureBox_cerrarSesion.Size = new System.Drawing.Size(58, 50);
            this.pictureBox_cerrarSesion.TabIndex = 5;
            this.pictureBox_cerrarSesion.TabStop = false;
            this.pictureBox_cerrarSesion.Click += new System.EventHandler(this.pictureBox_cerrarSesion_Click);
            // 
            // label_nombreUsuario
            // 
            this.label_nombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_nombreUsuario.AutoSize = true;
            this.label_nombreUsuario.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_nombreUsuario.Location = new System.Drawing.Point(62, 190);
            this.label_nombreUsuario.MaximumSize = new System.Drawing.Size(100, 100);
            this.label_nombreUsuario.Name = "label_nombreUsuario";
            this.label_nombreUsuario.Size = new System.Drawing.Size(94, 50);
            this.label_nombreUsuario.TabIndex = 98;
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
            this.pictureBox_ImagenPerfil.Click += new System.EventHandler(this.Settings_Click);
            // 
            // flVistaVacia
            // 
            this.flVistaVacia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flVistaVacia.AutoScroll = true;
            this.flVistaVacia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flVistaVacia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.flVistaVacia.Location = new System.Drawing.Point(263, 74);
            this.flVistaVacia.Margin = new System.Windows.Forms.Padding(4);
            this.flVistaVacia.Name = "flVistaVacia";
            this.flVistaVacia.Size = new System.Drawing.Size(837, 449);
            this.flVistaVacia.TabIndex = 93;
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
            this.menu_VistaVacia.Size = new System.Drawing.Size(1116, 28);
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
            this.boton_perfil_menu_strip.Size = new System.Drawing.Size(56, 24);
            this.boton_perfil_menu_strip.Text = "Perfil";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            this.ajustesToolStripMenuItem.Click += new System.EventHandler(this.ajustesToolStripMenuItem_Click);
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
            this.boton_salir_programa_menu.Click += new System.EventHandler(this.boton_salir_programa_menu_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_buscar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_buscar.Location = new System.Drawing.Point(656, 36);
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(326, 27);
            this.textBox_buscar.TabIndex = 1;
            this.textBox_buscar.Text = "Introduce el título de un videojuego";
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
            this.button_buscar.Location = new System.Drawing.Point(997, 30);
            this.button_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(86, 35);
            this.button_buscar.TabIndex = 2;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = false;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // pictureBox_buscar
            // 
            this.pictureBox_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_buscar.Image = global::GameCore.Properties.Resources.refrescar_icon;
            this.pictureBox_buscar.Location = new System.Drawing.Point(263, 530);
            this.pictureBox_buscar.Name = "pictureBox_buscar";
            this.pictureBox_buscar.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_buscar.TabIndex = 8;
            this.pictureBox_buscar.TabStop = false;
            this.pictureBox_buscar.Click += new System.EventHandler(this.pictureBox_buscarClick);
            // 
            // label__mostrar_coleccion
            // 
            this.label__mostrar_coleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label__mostrar_coleccion.AutoSize = true;
            this.label__mostrar_coleccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label__mostrar_coleccion.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label__mostrar_coleccion.Location = new System.Drawing.Point(319, 547);
            this.label__mostrar_coleccion.Name = "label__mostrar_coleccion";
            this.label__mostrar_coleccion.Size = new System.Drawing.Size(212, 23);
            this.label__mostrar_coleccion.TabIndex = 3;
            this.label__mostrar_coleccion.Text = "Mostrar toda la colección";
            // 
            // FormVistaVacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1116, 593);
            this.Controls.Add(this.label__mostrar_coleccion);
            this.Controls.Add(this.pictureBox_buscar);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.textBox_buscar);
            this.Controls.Add(this.menu_VistaVacia);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.flVistaVacia);
            this.Controls.Add(this.tsMenuCerrado);
            this.MainMenuStrip = this.menu_VistaVacia;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(741, 477);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsMenuCerrado;
        private System.Windows.Forms.ToolStripLabel tslblDeplegar;
        private System.Windows.Forms.ToolStripButton tsbtnRegresa;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.ToolStrip toolStrip__menuInferior;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel tslblSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslblexit;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.PictureBox pictureBox_ImagenPerfil;
        private System.Windows.Forms.FlowLayoutPanel flVistaVacia;
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
        private System.Windows.Forms.PictureBox pictureBox_buscar;
        private System.Windows.Forms.Label label__mostrar_coleccion;
    }
}

