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
    public partial class ControlVideojuego : Control
    {
        private PictureBox portada;
        private Label titulo;

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

            // LOS AÑADIMOS AL CONTROL PERSONALIZADO
            this.Controls.Add(portada);
            this.Controls.Add(titulo);

            //SE CREA UN EVENTO PARA EL DOBLE CLICK
            portada.DoubleClick += ControlPersonalizado_DobleClick;
        }

        public void UpdateData(string t, Image imagen)
        {
            // SE ACTUALIZA EL CONTROL EN BASE A LOS VALORES PASADOS COMO PARÁMETROS A LA FUNCIÓN
            portada.Image = imagen;
            titulo.Text = t;
        }

        private void ControlPersonalizado_DobleClick(object sender, EventArgs e)
        {
            VistaDetalle vistaDetalle = new VistaDetalle();
            vistaDetalle.Titulo = this.titulo.Text;
            //vistaDetalle.Portada...
            if (vistaDetalle.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

    }
}
