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
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(87, 296);
            this.labelTitulo.MaximumSize = new System.Drawing.Size(201, 100);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(90, 20);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "titulo juego";
            // 
            // pbPortada
            // 
            this.pbPortada.Location = new System.Drawing.Point(35, 25);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(201, 246);
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(294, 25);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(299, 246);
            this.textBoxDescripcion.TabIndex = 2;
            this.textBoxDescripcion.Text = "";
            // 
            // VistaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 429);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.pbPortada);
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
    }
}