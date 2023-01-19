namespace GameCore
{
    partial class FormaInicioSesion
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
            this.barra_separadora = new System.Windows.Forms.Label();
            this.label_gameCore = new System.Windows.Forms.Label();
            this.pictureBox_logoAplicacion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logoAplicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // barra_separadora
            // 
            this.barra_separadora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.barra_separadora.Location = new System.Drawing.Point(496, -3);
            this.barra_separadora.Name = "barra_separadora";
            this.barra_separadora.Size = new System.Drawing.Size(10, 598);
            this.barra_separadora.TabIndex = 0;
            // 
            // label_gameCore
            // 
            this.label_gameCore.AutoSize = true;
            this.label_gameCore.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gameCore.Location = new System.Drawing.Point(834, 105);
            this.label_gameCore.Name = "label_gameCore";
            this.label_gameCore.Size = new System.Drawing.Size(211, 34);
            this.label_gameCore.TabIndex = 1;
            this.label_gameCore.Text = "GAME CORE";
            // 
            // pictureBox_logoAplicacion
            // 
            this.pictureBox_logoAplicacion.Image = global::GameCore.Properties.Resources.logo1;
            this.pictureBox_logoAplicacion.Location = new System.Drawing.Point(496, -3);
            this.pictureBox_logoAplicacion.Name = "pictureBox_logoAplicacion";
            this.pictureBox_logoAplicacion.Size = new System.Drawing.Size(332, 269);
            this.pictureBox_logoAplicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logoAplicacion.TabIndex = 2;
            this.pictureBox_logoAplicacion.TabStop = false;
            // 
            // FormaInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 588);
            this.Controls.Add(this.pictureBox_logoAplicacion);
            this.Controls.Add(this.label_gameCore);
            this.Controls.Add(this.barra_separadora);
            this.Name = "FormaInicioSesion";
            this.Text = "FormaInicioSesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logoAplicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label barra_separadora;
        private System.Windows.Forms.Label label_gameCore;
        private System.Windows.Forms.PictureBox pictureBox_logoAplicacion;
    }
}