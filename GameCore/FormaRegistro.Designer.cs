﻿namespace GameCore
{
    partial class FormaRegistro
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
            this.label_nombreUsuario = new System.Windows.Forms.Label();
            this.label_contraseña = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nomUsuario = new System.Windows.Forms.TextBox();
            this.textBox_contraseña = new System.Windows.Forms.TextBox();
            this.textBox_repetirContraseña = new System.Windows.Forms.TextBox();
            this.label_repetirContraseña = new System.Windows.Forms.Label();
            this.checkBox_mostrarContraseña = new System.Windows.Forms.CheckBox();
            this.button_registrar = new System.Windows.Forms.Button();
            this.button_cancelar_registro = new System.Windows.Forms.Button();
            this.label_yaTienesCuenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_nombreUsuario
            // 
            this.label_nombreUsuario.AutoSize = true;
            this.label_nombreUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_nombreUsuario.Location = new System.Drawing.Point(57, 101);
            this.label_nombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nombreUsuario.Name = "label_nombreUsuario";
            this.label_nombreUsuario.Size = new System.Drawing.Size(164, 23);
            this.label_nombreUsuario.TabIndex = 0;
            this.label_nombreUsuario.Text = "Nombre de usuario";
            // 
            // label_contraseña
            // 
            this.label_contraseña.AutoSize = true;
            this.label_contraseña.Location = new System.Drawing.Point(58, 210);
            this.label_contraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_contraseña.Name = "label_contraseña";
            this.label_contraseña.Size = new System.Drawing.Size(99, 23);
            this.label_contraseña.TabIndex = 1;
            this.label_contraseña.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(97, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crear cuenta";
            // 
            // textBox_nomUsuario
            // 
            this.textBox_nomUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_nomUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_nomUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_nomUsuario.Location = new System.Drawing.Point(61, 127);
            this.textBox_nomUsuario.MaxLength = 15;
            this.textBox_nomUsuario.Multiline = true;
            this.textBox_nomUsuario.Name = "textBox_nomUsuario";
            this.textBox_nomUsuario.Size = new System.Drawing.Size(300, 24);
            this.textBox_nomUsuario.TabIndex = 1;
            // 
            // textBox_contraseña
            // 
            this.textBox_contraseña.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_contraseña.Location = new System.Drawing.Point(61, 236);
            this.textBox_contraseña.Multiline = true;
            this.textBox_contraseña.Name = "textBox_contraseña";
            this.textBox_contraseña.PasswordChar = '*';
            this.textBox_contraseña.Size = new System.Drawing.Size(300, 23);
            this.textBox_contraseña.TabIndex = 2;
            // 
            // textBox_repetirContraseña
            // 
            this.textBox_repetirContraseña.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_repetirContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_repetirContraseña.Location = new System.Drawing.Point(61, 342);
            this.textBox_repetirContraseña.Multiline = true;
            this.textBox_repetirContraseña.Name = "textBox_repetirContraseña";
            this.textBox_repetirContraseña.PasswordChar = '*';
            this.textBox_repetirContraseña.Size = new System.Drawing.Size(300, 25);
            this.textBox_repetirContraseña.TabIndex = 3;
            // 
            // label_repetirContraseña
            // 
            this.label_repetirContraseña.AutoSize = true;
            this.label_repetirContraseña.Location = new System.Drawing.Point(57, 316);
            this.label_repetirContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_repetirContraseña.Name = "label_repetirContraseña";
            this.label_repetirContraseña.Size = new System.Drawing.Size(99, 23);
            this.label_repetirContraseña.TabIndex = 5;
            this.label_repetirContraseña.Text = "Contraseña";
            // 
            // checkBox_mostrarContraseña
            // 
            this.checkBox_mostrarContraseña.AutoSize = true;
            this.checkBox_mostrarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_mostrarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_mostrarContraseña.Location = new System.Drawing.Point(176, 388);
            this.checkBox_mostrarContraseña.Name = "checkBox_mostrarContraseña";
            this.checkBox_mostrarContraseña.Size = new System.Drawing.Size(185, 27);
            this.checkBox_mostrarContraseña.TabIndex = 7;
            this.checkBox_mostrarContraseña.Text = "Mostrar Contraseña";
            this.checkBox_mostrarContraseña.UseVisualStyleBackColor = true;
            // 
            // button_registrar
            // 
            this.button_registrar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_registrar.FlatAppearance.BorderSize = 0;
            this.button_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registrar.ForeColor = System.Drawing.Color.White;
            this.button_registrar.Location = new System.Drawing.Point(52, 455);
            this.button_registrar.Name = "button_registrar";
            this.button_registrar.Size = new System.Drawing.Size(309, 56);
            this.button_registrar.TabIndex = 8;
            this.button_registrar.Text = "REGISTRAR";
            this.button_registrar.UseVisualStyleBackColor = false;
            this.button_registrar.Click += new System.EventHandler(this.button_registrar_Click);
            // 
            // button_cancelar_registro
            // 
            this.button_cancelar_registro.BackColor = System.Drawing.Color.White;
            this.button_cancelar_registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancelar_registro.FlatAppearance.BorderSize = 0;
            this.button_cancelar_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelar_registro.ForeColor = System.Drawing.Color.Turquoise;
            this.button_cancelar_registro.Location = new System.Drawing.Point(52, 533);
            this.button_cancelar_registro.Name = "button_cancelar_registro";
            this.button_cancelar_registro.Size = new System.Drawing.Size(309, 56);
            this.button_cancelar_registro.TabIndex = 9;
            this.button_cancelar_registro.Text = "CANCELAR";
            this.button_cancelar_registro.UseVisualStyleBackColor = false;
            // 
            // label_yaTienesCuenta
            // 
            this.label_yaTienesCuenta.AutoSize = true;
            this.label_yaTienesCuenta.Location = new System.Drawing.Point(118, 629);
            this.label_yaTienesCuenta.Name = "label_yaTienesCuenta";
            this.label_yaTienesCuenta.Size = new System.Drawing.Size(171, 23);
            this.label_yaTienesCuenta.TabIndex = 10;
            this.label_yaTienesCuenta.Text = "Ya tengo una cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(147, 662);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Inicia sesión";
            // 
            // FormaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_yaTienesCuenta);
            this.Controls.Add(this.button_cancelar_registro);
            this.Controls.Add(this.button_registrar);
            this.Controls.Add(this.checkBox_mostrarContraseña);
            this.Controls.Add(this.textBox_repetirContraseña);
            this.Controls.Add(this.label_repetirContraseña);
            this.Controls.Add(this.textBox_contraseña);
            this.Controls.Add(this.textBox_nomUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_contraseña);
            this.Controls.Add(this.label_nombreUsuario);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormaRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaInicioSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nombreUsuario;
        private System.Windows.Forms.Label label_contraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nomUsuario;
        private System.Windows.Forms.TextBox textBox_contraseña;
        private System.Windows.Forms.TextBox textBox_repetirContraseña;
        private System.Windows.Forms.Label label_repetirContraseña;
        private System.Windows.Forms.CheckBox checkBox_mostrarContraseña;
        private System.Windows.Forms.Button button_registrar;
        private System.Windows.Forms.Button button_cancelar_registro;
        private System.Windows.Forms.Label label_yaTienesCuenta;
        private System.Windows.Forms.Label label1;
    }
}