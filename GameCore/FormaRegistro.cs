using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GameCore
{
    /// <summary>
    /// Clase donde se implementa la funcionalidad para dar de alta al usuario que se registre en la aplicación.
    /// </summary>
    public partial class FormaRegistro : Form
    {
        SQLiteConnection conexion;
        /// <summary>
        /// Constructor de la forma registro
        /// </summary>
        public FormaRegistro()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Método donde se realiza el INSERT del usuario en la Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_registrar_Click(object sender, EventArgs e)
        {
            //variables donde almaceno los datos que introduce el usuario y los paso a minúsculas para introducirlos en la BD
            string nombreUsuario = textBox_nomUsuario.Text;
            nombreUsuario = nombreUsuario.Trim();
            string contraseña = textBox_contraseña.Text;
            contraseña = contraseña.Trim();
            string repetirContraseña = textBox_repetirContraseña.Text;
            repetirContraseña = repetirContraseña.Trim();
            if(string.IsNullOrWhiteSpace(nombreUsuario))
            {
                MessageBox.Show("El nombre no puede estar vacío");
            }
            else
            {
                if(string.IsNullOrEmpty(contraseña)||string.IsNullOrEmpty(repetirContraseña))
                {
                    MessageBox.Show("La contraseña no puede estar vacía");
                }
                else
                {
                    if (contraseña.Equals(repetirContraseña))
                    {
                        //PENDIENTE comprobar si el archivo de la base de datos está en la aplicación
                        try
                        {
                            //iniciamos la conexión con la base de datos al iniciar la forma registro
                            using (conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
                            {
                                conexion.Open();

                                using (SQLiteCommand command = new SQLiteCommand(conexion))
                                {
                                    //si me devuelve false es que no hay usuario con ese nombre, por lo tanto lo inserto en la base de datos
                                    if (!MetodosSqlite.CompruebaUsuario(nombreUsuario))
                                    {
                                        //consulta parametrizada para evitar inyección SQL en la base de datos
                                        command.CommandText = "INSERT INTO usuarios (nombre_usuario,contraseña) VALUES (@nombre, @contraseña)";
                                        command.Parameters.AddWithValue("@nombre", nombreUsuario);
                                        command.Parameters.AddWithValue("@contraseña", contraseña);
                                        command.ExecuteNonQuery();
                                        MessageBox.Show("Has sido registrado en la aplicación");
                                        conexion.Close();
                                        this.DialogResult = DialogResult.OK;
                                    }
                                    //si devuelve true le aviso al usuario de que ya hay un usuario con ese nombre
                                    else
                                    {
                                        MessageBox.Show("Ese usuarios ya existe");
                                    }

                                }

                            }
                        }

                        catch (SQLiteException ex)
                        {
                            // Handle the exception here
                            MessageBox.Show("Error al acceder a la base de datos: " + ex.Message);
                        }
                    }

                    else
                    {
                        //hacer visible la titulo
                        label_aviso_errores.Text = "Las contraseñas no coinciden";
                        label_aviso_errores.Size = new Size(309, 10);
                        label_aviso_errores.TextAlign = ContentAlignment.MiddleCenter;
                        label_aviso_errores.Visible = true;
                    }
                }
               
            }
           

        }  

        /// <summary>
        /// si ya tienes una cuenta el titulo de iniciar sesion te devuelve a la forma de Inicio de Sesion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_iniciar_sesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //boton cancelar cierra la forma
        private void button_cancelar_registro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método para mostrar u ocultar los caracteres introducidos en los checkbox de la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// PictureBox donde al hacer click cierra la forma de Registro y nos lleva a la de Inicio de sesión.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_volverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
