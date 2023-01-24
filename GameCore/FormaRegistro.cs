using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GameCore
{
    public partial class FormaRegistro : Form
    {
        SQLiteConnection conexion;
        public FormaRegistro()
        {
            InitializeComponent();
            SQLiteConnection.CreateFile("gamecore.db");
            
        }

        private void FormaRegistro_Load(object sender, EventArgs e)
        {

        }

        private void button_registrar_Click(object sender, EventArgs e)
        {
            bool validarUsuario = false;

            string nombreUsuario = textBox_nomUsuario.Text;
            string contraseña = textBox_contraseña.Text;
            string repetirContraseña = textBox_repetirContraseña.Text;
            if(contraseña.Equals(repetirContraseña))
            {

                //iniciamos la conexión con la base de datos al iniciar la forma registro
                using (conexion = new SQLiteConnection(@"Data Source=.\BaseDeDatos\gamecore.db")) 
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand(conexion))
                    {
                        //consulta parametrizada para evitar inyección SQL en la base de datos
                        command.CommandText = "INSERT INTO usuarios (usuario,contraseña) VALUES (@nombre, @contraseña)";
                        command.Parameters.AddWithValue("@nombre", nombreUsuario);
                        command.Parameters.AddWithValue("@contraseña", contraseña);
                        command.ExecuteNonQuery();
                    }

                }      
               
            }
            else
            {
                //hacer visible la label
                label_aviso_errores.Text = "Las contraseñas no coinciden";
                label_aviso_errores.Size = new Size(309, 10);
                label_aviso_errores.TextAlign = ContentAlignment.MiddleCenter;
                label_aviso_errores.Visible = true;
            }

        }  

        //si ya tienes una cuenta el label de iniciar sesion te devuelve a la forma de Inicio de Sesion
        private void label_iniciar_sesion_Click(object sender, EventArgs e)
        {
            FormaInicioSesion formaInicioSesion = new FormaInicioSesion();
            if (formaInicioSesion.ShowDialog() == DialogResult.OK)
            {

            }
        }

        //boton cancelar oculta la forma
        private void button_cancelar_registro_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBox_mostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_mostrarContraseña.Checked)
            {
                textBox_contraseña.UseSystemPasswordChar = true;
                textBox_repetirContraseña.UseSystemPasswordChar = true;
                
            }
            else
            {
                textBox_contraseña.UseSystemPasswordChar = false;
                textBox_repetirContraseña.UseSystemPasswordChar = false;
            }
        }
    }
}
