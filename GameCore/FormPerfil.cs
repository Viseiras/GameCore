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
        public static bool darkmode = false;
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
            if (darkmode == true)
            {
                toogleBoxCustomDarkMode.Checked = true;
                darkModeChanger();
            }
                
        }   


        public void darkModeChanger()
        {
            if (darkmode == false)
            {
                darkmode = true;
                BackColor = Color.DarkGray;
            }
            else if (darkmode == true)
            {
                darkmode = false;
                BackColor = Color.White;
            }
        }

        private void button_ajustes_por_defecto_Click(object sender, EventArgs e)
        {
            toogleBoxCustomDarkMode.Checked = false;
        }

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
        }

        private void toogleBoxCustomDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            darkModeChanger();
        }
    }
}
