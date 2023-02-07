
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip_menuInferior = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_ajustes = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_esconder = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip_botonFlecha = new System.Windows.Forms.ToolStripButton();
            this.tsMenuCerrado = new System.Windows.Forms.ToolStrip();
            this.tslblDeplegar = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnRegresa = new System.Windows.Forms.ToolStripButton();
            this.label_idioma = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_ajustes_por_defecto = new System.Windows.Forms.Button();
            this.boton_guardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip_menuInferior.SuspendLayout();
            this.tsMenuCerrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip_menuInferior);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label_usuario);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 477);
            this.panel1.TabIndex = 0;
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Location = new System.Drawing.Point(35, 131);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(96, 13);
            this.label_usuario.TabIndex = 1;
            this.label_usuario.Text = "Nombre de usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 81);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip_menuInferior
            // 
            this.toolStrip_menuInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip_menuInferior.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.toolStrip_menuInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStrip_ajustes,
            this.toolStripSeparator1,
            this.toolStrip_esconder,
            this.toolStrip_botonFlecha});
            this.toolStrip_menuInferior.Location = new System.Drawing.Point(0, 452);
            this.toolStrip_menuInferior.Name = "toolStrip_menuInferior";
            this.toolStrip_menuInferior.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip_menuInferior.ShowItemToolTips = false;
            this.toolStrip_menuInferior.Size = new System.Drawing.Size(184, 25);
            this.toolStrip_menuInferior.TabIndex = 3;
            this.toolStrip_menuInferior.Text = "Menu";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::GameCore.Properties.Resources.settings;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStrip_ajustes
            // 
            this.toolStrip_ajustes.AutoToolTip = true;
            this.toolStrip_ajustes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip_ajustes.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.toolStrip_ajustes.Name = "toolStrip_ajustes";
            this.toolStrip_ajustes.Size = new System.Drawing.Size(53, 24);
            this.toolStrip_ajustes.Text = "Ajustes";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip_esconder
            // 
            this.toolStrip_esconder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip_esconder.Name = "toolStrip_esconder";
            this.toolStrip_esconder.Size = new System.Drawing.Size(64, 22);
            this.toolStrip_esconder.Text = "Esconder";
            // 
            // toolStrip_botonFlecha
            // 
            this.toolStrip_botonFlecha.BackgroundImage = global::GameCore.Properties.Resources.settings;
            this.toolStrip_botonFlecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_botonFlecha.Image = global::GameCore.Properties.Resources.hidepanel;
            this.toolStrip_botonFlecha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_botonFlecha.Name = "toolStrip_botonFlecha";
            this.toolStrip_botonFlecha.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_botonFlecha.Text = "toolStripButton3";
            // 
            // tsMenuCerrado
            // 
            this.tsMenuCerrado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMenuCerrado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenuCerrado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblDeplegar,
            this.tsbtnRegresa});
            this.tsMenuCerrado.Location = new System.Drawing.Point(0, 449);
            this.tsMenuCerrado.Name = "tsMenuCerrado";
            this.tsMenuCerrado.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsMenuCerrado.Size = new System.Drawing.Size(812, 25);
            this.tsMenuCerrado.TabIndex = 3;
            this.tsMenuCerrado.Text = "Desplegar ";
            this.tsMenuCerrado.Visible = false;
            // 
            // tslblDeplegar
            // 
            this.tslblDeplegar.Name = "tslblDeplegar";
            this.tslblDeplegar.Size = new System.Drawing.Size(59, 22);
            this.tslblDeplegar.Text = "Desplegar";
            // 
            // tsbtnRegresa
            // 
            this.tsbtnRegresa.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnRegresa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRegresa.Image = global::GameCore.Properties.Resources.showpanel;
            this.tsbtnRegresa.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsbtnRegresa.Name = "tsbtnRegresa";
            this.tsbtnRegresa.Size = new System.Drawing.Size(23, 22);
            // 
            // label_idioma
            // 
            this.label_idioma.AutoSize = true;
            this.label_idioma.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idioma.Location = new System.Drawing.Point(232, 64);
            this.label_idioma.Name = "label_idioma";
            this.label_idioma.Size = new System.Drawing.Size(64, 21);
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
            this.comboBox1.Location = new System.Drawing.Point(315, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // button_ajustes_por_defecto
            // 
            this.button_ajustes_por_defecto.Location = new System.Drawing.Point(520, 418);
            this.button_ajustes_por_defecto.Name = "button_ajustes_por_defecto";
            this.button_ajustes_por_defecto.Size = new System.Drawing.Size(126, 44);
            this.button_ajustes_por_defecto.TabIndex = 6;
            this.button_ajustes_por_defecto.Text = "Ajustes por defecto";
            this.button_ajustes_por_defecto.UseVisualStyleBackColor = true;
            // 
            // boton_guardar
            // 
            this.boton_guardar.Location = new System.Drawing.Point(676, 418);
            this.boton_guardar.Name = "boton_guardar";
            this.boton_guardar.Size = new System.Drawing.Size(124, 44);
            this.boton_guardar.TabIndex = 7;
            this.boton_guardar.Text = "Guardar";
            this.boton_guardar.UseVisualStyleBackColor = true;
            // 
            // FormaPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 474);
            this.Controls.Add(this.boton_guardar);
            this.Controls.Add(this.button_ajustes_por_defecto);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_idioma);
            this.Controls.Add(this.tsMenuCerrado);
            this.Controls.Add(this.panel1);
            this.Name = "FormaPerfil";
            this.Text = "FormaPerfil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip_menuInferior.ResumeLayout(false);
            this.toolStrip_menuInferior.PerformLayout();
            this.tsMenuCerrado.ResumeLayout(false);
            this.tsMenuCerrado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_usuario;
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
    }
}