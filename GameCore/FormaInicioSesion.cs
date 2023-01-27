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
    public partial class FormaInicioSesion : Form
    {
        public FormaInicioSesion()
        {
            InitializeComponent();
            //comprobación para cambiar el color de las letras a blanco si hay una imagen de fondo
            if(this.BackgroundImage!=null)
            {
                label_Inicio_Sesion.ForeColor = Color.White;
                label_nombreUsuario.ForeColor = Color.White;
                label_Contraseña.ForeColor = Color.White;
                label_no_tienes_cuenta.ForeColor = Color.White;
            }
        }

        private void button_registrarse_Click(object sender, EventArgs e)
        {
            FormaRegistro formaRegistro = new FormaRegistro();
            if(formaRegistro.ShowDialog()==DialogResult.OK)
            {

            }
        }

        private void button_registrar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBox_nombreUsuario.Text;
            string contraseña = textBox_Contraseña.Text;
            //si existe el  usuario en la base de datos
            if(MetodosSqlite.CompruebaUsuario(nombreUsuario))
            {
                //compruebo si la contraseña introducida es correcta
                if (MetodosSqlite.CompruebaContraseña(nombreUsuario).Equals(contraseña))
                {
                    //vamos a la forma de vista vacia
                    MessageBox.Show("Has iniciado sesión");
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

            
        }
    }
}
