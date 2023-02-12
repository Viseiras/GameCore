

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
            this.label1 = new System.Windows.Forms.Label();
            this.cbDesarrolladores = new System.Windows.Forms.ComboBox();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_añadir_imagen = new System.Windows.Forms.Button();
            this.pictureBoxAnadir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnadir)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(13, 36);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(273, 30);
            this.tbTitulo.TabIndex = 1;
            this.tbTitulo.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(9, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(65, 23);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Titulo*";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(311, 36);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(188, 249);
            this.tbDescripcion.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(310, 5);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(103, 23);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPortada
            // 
            this.lblPortada.AutoSize = true;
            this.lblPortada.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblPortada.Location = new System.Drawing.Point(112, 109);
            this.lblPortada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortada.Name = "lblPortada";
            this.lblPortada.Size = new System.Drawing.Size(77, 23);
            this.lblPortada.TabIndex = 15;
            this.lblPortada.Text = "Portada ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Desarrolladores*";
            // 
            // cbDesarrolladores
            // 
            this.cbDesarrolladores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesarrolladores.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDesarrolladores.FormattingEnabled = true;
            this.cbDesarrolladores.Items.AddRange(new object[] {
            "Nintendo",
            "Playstation",
            "Xbox",
            "Steam"});
            this.cbDesarrolladores.Location = new System.Drawing.Point(311, 333);
            this.cbDesarrolladores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDesarrolladores.Name = "cbDesarrolladores";
            this.cbDesarrolladores.Size = new System.Drawing.Size(188, 31);
            this.cbDesarrolladores.TabIndex = 5;
            // 
            // button_aceptar
            // 
            this.button_aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button_aceptar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aceptar.ForeColor = System.Drawing.Color.White;
            this.button_aceptar.Location = new System.Drawing.Point(411, 516);
            this.button_aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(92, 41);
            this.button_aceptar.TabIndex = 21;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = false;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button_cancelar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.ForeColor = System.Drawing.Color.White;
            this.button_cancelar.Location = new System.Drawing.Point(311, 516);
            this.button_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(92, 41);
            this.button_cancelar.TabIndex = 22;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_añadir_imagen
            // 
            this.button_añadir_imagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_añadir_imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button_añadir_imagen.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_añadir_imagen.ForeColor = System.Drawing.Color.White;
            this.button_añadir_imagen.Location = new System.Drawing.Point(74, 436);
            this.button_añadir_imagen.Margin = new System.Windows.Forms.Padding(4);
            this.button_añadir_imagen.Name = "button_añadir_imagen";
            this.button_añadir_imagen.Size = new System.Drawing.Size(153, 37);
            this.button_añadir_imagen.TabIndex = 23;
            this.button_añadir_imagen.Text = "Añadir imagen";
            this.button_añadir_imagen.UseVisualStyleBackColor = false;
            this.button_añadir_imagen.Click += new System.EventHandler(this.button_añadir_imagenClick);
            // 
            // pictureBoxAnadir
            // 
            this.pictureBoxAnadir.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBoxAnadir.Image = global::GameCore.Properties.Resources.info_drag_drop;
            this.pictureBoxAnadir.Location = new System.Drawing.Point(37, 146);
            this.pictureBoxAnadir.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAnadir.Name = "pictureBoxAnadir";
            this.pictureBoxAnadir.Size = new System.Drawing.Size(218, 282);
            this.pictureBoxAnadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAnadir.TabIndex = 19;
            this.pictureBoxAnadir.TabStop = false;
            this.pictureBoxAnadir.Click += new System.EventHandler(this.btnFoto_Click);
            this.pictureBoxAnadir.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxAnadir_DragDrop);
            this.pictureBoxAnadir.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxAnadir_DragEnter);
            // 
            // formAñadir
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(512, 570);
            this.Controls.Add(this.button_añadir_imagen);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.pictureBoxAnadir);
            this.Controls.Add(this.cbDesarrolladores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPortada);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tbTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(530, 617);
            this.MinimumSize = new System.Drawing.Size(530, 617);
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
        private System.Windows.Forms.PictureBox pictureBoxAnadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDesarrolladores;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_añadir_imagen;
    }
}

