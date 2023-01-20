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
