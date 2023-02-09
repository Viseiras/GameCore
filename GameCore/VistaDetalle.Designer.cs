namespace GameCore
{
    partial class VistaDetalle
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.textBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Enabled = false;
            this.labelTitulo.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(65, 240);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.MaximumSize = new System.Drawing.Size(151, 81);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(71, 15);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "titulo juego";
            // 
            // pbPortada
            // 
            this.pbPortada.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pbPortada.Enabled = false;
            this.pbPortada.Location = new System.Drawing.Point(25, 20);
            this.pbPortada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(151, 200);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            this.pbPortada.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbPortada_DragDrop);
            this.pbPortada.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbPortada_DragEnter);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Enabled = false;
            this.textBoxDescripcion.Location = new System.Drawing.Point(220, 20);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(225, 201);
            this.textBoxDescripcion.TabIndex = 2;
            this.textBoxDescripcion.Text = "";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(312, 303);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // VistaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 349);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.pbPortada);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VistaDetalle";
            this.Text = "VistaDetalle";
            this.Load += new System.EventHandler(this.VistaDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.RichTextBox textBoxDescripcion;
        private System.Windows.Forms.Button btnEditar;
    }
}