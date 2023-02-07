

namespace GameCore
{
    partial class formAñadir
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
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPortada = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pictureBoxAnadir = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDesarrolladores = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnadir)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(37, 38);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(273, 22);
            this.tbTitulo.TabIndex = 1;
            this.tbTitulo.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(33, 18);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(45, 16);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Titulo*";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(353, 38);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(139, 230);
            this.tbDescripcion.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(349, 18);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPortada
            // 
            this.lblPortada.AutoSize = true;
            this.lblPortada.Location = new System.Drawing.Point(33, 66);
            this.lblPortada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortada.Name = "lblPortada";
            this.lblPortada.Size = new System.Drawing.Size(58, 16);
            this.lblPortada.TabIndex = 15;
            this.lblPortada.Text = "Portada ";
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(128, 426);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(100, 28);
            this.btnFoto.TabIndex = 6;
            this.btnFoto.Text = "Añadir Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(252, 514);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pictureBoxAnadir
            // 
            this.pictureBoxAnadir.Location = new System.Drawing.Point(37, 86);
            this.pictureBoxAnadir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxAnadir.Name = "pictureBoxAnadir";
            this.pictureBoxAnadir.Size = new System.Drawing.Size(275, 332);
            this.pictureBoxAnadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnadir.TabIndex = 19;
            this.pictureBoxAnadir.TabStop = false;
            this.pictureBoxAnadir.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(71, 294);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Desarrolladores*";
            // 
            // cbDesarrolladores
            // 
            this.cbDesarrolladores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesarrolladores.FormattingEnabled = true;
            this.cbDesarrolladores.Items.AddRange(new object[] {
            "Nintendo",
            "Playstation",
            "Xbox",
            "Steam"});
            this.cbDesarrolladores.Location = new System.Drawing.Point(353, 314);
            this.cbDesarrolladores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDesarrolladores.Name = "cbDesarrolladores";
            this.cbDesarrolladores.Size = new System.Drawing.Size(133, 24);
            this.cbDesarrolladores.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(388, 514);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // formAñadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(513, 572);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBoxAnadir);
            this.Controls.Add(this.cbDesarrolladores);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPortada);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(531, 619);
            this.MinimumSize = new System.Drawing.Size(531, 619);
            this.Name = "formAñadir";
            this.Text = "Añadir un nuevo Juego";
            this.Load += new System.EventHandler(this.formAnadir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnadir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPortada;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pictureBoxAnadir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDesarrolladores;
        private System.Windows.Forms.Button btnCancelar;
    }
}

