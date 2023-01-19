
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
            this.flVistaVacia = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // flVistaVacia
            // 
            this.flVistaVacia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flVistaVacia.AutoScroll = true;
            this.flVistaVacia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flVistaVacia.Location = new System.Drawing.Point(198, 29);
            this.flVistaVacia.Name = "flVistaVacia";
            this.flVistaVacia.Size = new System.Drawing.Size(610, 416);
            this.flVistaVacia.TabIndex = 0;
            // 
            // panelLateral
            // 
            this.panelLateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLateral.Controls.Add(this.btnAnadir);
            this.panelLateral.Location = new System.Drawing.Point(1, 29);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(191, 416);
            this.panelLateral.TabIndex = 1;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(44, 18);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(98, 23);
            this.btnAnadir.TabIndex = 0;
            this.btnAnadir.Text = "Añadir Juego";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // FormVistaVacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(820, 447);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.flVistaVacia);
            this.MinimumSize = new System.Drawing.Size(561, 397);
            this.Name = "FormVistaVacia";
            this.Text = "Vista Vacía ";
            this.panelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flVistaVacia;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnAnadir;
    }
}

