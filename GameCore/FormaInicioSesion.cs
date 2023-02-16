using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCore
{
    /// <summary>
    /// Forma de Inicio de sesión donde se muestra el logo de la app, información y funcionalidad para iniciar sesión o registrarse
    /// </summary>
    public partial class FormaInicioSesion : Form
    {
        /// <summary>
        /// atributo public para conseguir el nombre de usuario y poder utilizarlo en la clase MetodosSqlite
        /// </summary>
        public static string nombreUsuario;
        /// <summary>
        /// comprobación para cambiar el color de las letras a blanco si hay una imagen de fondo
        /// </summary>
        public FormaInicioSesion()
        {
            InitializeComponent();
      
            if (this.BackgroundImage != null)
            {
                label_Inicio_Sesion.ForeColor = Color.White;
                label_nombreUsuario.ForeColor = Color.White;
                label_Contraseña.ForeColor = Color.White;
                label_no_tienes_cuenta.ForeColor = Color.White;
            }
        }
        /// <summary>
        /// boton encargado de abrir la forma para registrarse en la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_registrarse_Click(object sender, EventArgs e)
        {
            FormaRegistro fRegistro = new FormaRegistro();
            if (fRegistro.ShowDialog()==DialogResult.OK)
            {

            }
                
            
        }
        /// <summary>
        /// Método para iniciar sesión cuando se haga clic en el botón. Se comprueba el nombre y la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_iniciarSesion(object sender, EventArgs e)
        {
            nombreUsuario = textBox_nombreUsuario.Text.Trim();
            string contraseña = textBox_Contraseña.Text.Trim();
            //si existe el  usuario en la base de datos
            if (MetodosSqlite.CompruebaUsuario(nombreUsuario))
            {
                //compruebo si la contraseña introducida es correcta
                if (MetodosSqlite.CompruebaContraseña(nombreUsuario).Equals(contraseña))
                {
                    //vamos a la forma de vista vacia
                    MetodosSqlite.GetPkUsuario();
                    this.Hide();
                    FormVistaVacia formVistaVacia = new FormVistaVacia();
                    formVistaVacia.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("La contraseña introducida no es correcta");
                }
            }
            //el usuario no existe en la BD
            else
            {
                MessageBox.Show("El nombre de usuario que has introducido no es correcto");
            }

            /* DESCOMENTAR PARA DESACTIVAR EL INICIO DE SESION
            this.Hide();
            FormVistaVacia formVistaVacia = new FormVistaVacia();
            formVistaVacia.ShowDialog();
            this.Close();*/
        }
        /// <summary>
        /// Método que al pulsar enter en el textbox de contraseña se inicie sesión.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void textBox_Contraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button_iniciarSesion(null, null);
            }
        }
        /// <summary>
        /// Método que al pulsar enter en el textbox de usuario se inicie sesión.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void textBox_nombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button_iniciarSesion(null, null);
            }
            
        }

        private void FormaInicioSesion_Load(object sender, EventArgs e)
        {
            textBox_Contraseña.UseSystemPasswordChar=true;
        }
    }
}