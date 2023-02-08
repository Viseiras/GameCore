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
    public partial class VistaDetalle : Form
    {
        public String Titulo { get; set; }
        public Image Portada { get; set; }
        public VistaDetalle()
        {
            InitializeComponent();
        }

        private void VistaDetalle_Load(object sender, EventArgs e)
        {
            labelTitulo.Text = Titulo;
            
        }
    }
}
