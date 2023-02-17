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
    /// Control Personalizado encargado de almacenar la portada y el titulo del videojuego. Este control es básicamente el videojuego que se añade al FlowLayoutPanel
    /// </summary>
    public partial class ControlVideojuego : Control
    {
        private PictureBox portada;
        private Label titulo;
        /// <summary>
        /// Constructor del control personalizado
        /// </summary>
        public ControlVideojuego()
        {
            // INICIAMOS LA IMAGEN
            portada = new PictureBox();
            portada.Width = 200;
            portada.Height = 200;
            portada.SizeMode = PictureBoxSizeMode.Zoom;
            //portada.Image = Properties.Resources.SUMA;

            // INICIAMOS EL LABEL
            titulo = new Label();
            titulo.Text = "Titulo";
            titulo.Width = 200;
            titulo.Font = new Font("Nirmala UI", 10, FontStyle.Bold);


            //para mostrar el texto debajo de la portada
            titulo.Left = portada.Left;
            titulo.Top = portada.Bottom;
            titulo.Dock = DockStyle.Bottom;
            portada.Dock = DockStyle.Bottom;
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            if(FormPerfil.darkmode) 
            {
                titulo.ForeColor = Color.White;
            }
            else
            {
                titulo.ForeColor = Color.Black;
            }

            // LOS AÑADIMOS AL CONTROL PERSONALIZADO
            this.Controls.Add(portada);
            this.Controls.Add(titulo);

            //SE CREA UN EVENTO PARA EL DOBLE CLICK
            portada.Click += ControlPersonalizado_DobleClick;
        }

        /// <summary>
        /// Método al que se le pasan dos parámetros, titulo y portada y sirve para actualizar los datos del control personalizado y así ir mostrando los videojuegos de la BD
        /// </summary>
        /// <param name="t">titulo del videojuego</param>
        /// <param name="imagen">portada del videojuego</param>
        public void ActualizarDatos(string t, Image imagen)
        {
            // SE ACTUALIZA EL CONTROL EN BASE A LOS VALORES PASADOS COMO PARÁMETROS A LA FUNCIÓN
            portada.Image = imagen;
            titulo.Text = t;
        }
        /// <summary>
        /// Método que abre la vista detallada del videojuego cuando se hace click sobre él
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlPersonalizado_DobleClick(object sender, EventArgs e)
        {
            FormDetalle vistaDetalle = new FormDetalle();
            vistaDetalle.Titulo = this.titulo.Text;
            //vistaDetalle.Portada...
            if (vistaDetalle.ShowDialog() == DialogResult.OK)
            {

            }
        }

    }
}
