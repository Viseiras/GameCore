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
    /// esta forma simplemente aloja una pictureBox donde se muestra una imagen con una pequeña guía para el usuario nuevo
    /// </summary>
    public partial class FormaAyuda : Form
    {
        /// <summary>
        /// Constructor de la Forma Ayuda
        /// </summary>
        public FormaAyuda()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boton para cerrar la ventana del tutorial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
