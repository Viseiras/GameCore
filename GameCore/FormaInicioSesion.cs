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

        
    }
}
