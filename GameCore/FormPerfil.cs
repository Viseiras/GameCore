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
    public partial class FormPerfil : Form
    {
        public FormPerfil()
        {
            InitializeComponent();
        }

        private void esconder_click(object sender, EventArgs e)
        {
            panelLateral.Visible = false;
            tsMenuCerrado.Visible = true;
        }

        private void desplegar_click(object sender, EventArgs e)
        {
            panelLateral.Visible = true;
            tsMenuCerrado.Visible = false;
        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            label_nombreUsuario.Text = FormaInicioSesion.nombreUsuario;
        }
    }
}
