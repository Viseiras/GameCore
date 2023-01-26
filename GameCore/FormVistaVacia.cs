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
    public partial class FormVistaVacia : Form
    {
        private int cont;
        public FormVistaVacia()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = new FlowLayoutPanel();
            PictureBox pb = new PictureBox();
            TextBox tb = new TextBox();

            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "JPG|*.jpg;*.jpeg;*.png;*.gif";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                //Convertimos a Bitmap la imagen para que se muestre visualmente en el PictureBox
                pb.Image = (Image)new Bitmap(opd.FileName);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            tb.Text = "Ejemplo";


            flp.Height = 200;
            flp.Width = 130;
            pb.Width = 120;
            tb.Width = 120;
            pb.Height = 160;
            tb.TextAlign = HorizontalAlignment.Center;
            flp.Controls.Add(pb);
            flp.Controls.Add(tb);


            flVistaVacia.Controls.Add(flp);
            flVistaVacia.Controls.RemoveAt(cont);
            cont++;
            MueveAnadir();
        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

        public void MueveAnadir()
        { 
            FlowLayoutPanel flp = new FlowLayoutPanel();
            PictureBox pb = new PictureBox();
            TextBox tb = new TextBox();
            tb.Text = "Añadir";
            tb.TextAlign = HorizontalAlignment.Center;
            tb.Enabled = false;
            pb.Image = (Image)new Bitmap(@".\\..\\..\\Resources\\SUMA.png"); //C: \Users\ciclosm\Source\Repos\Viseiras\GameCore\GameCore\Resources\SUMA.png

            flp.Height = 200;
            flp.Width = 130;
            pb.Width = 120;
            tb.Width = 120;
            pb.Height = 160;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            flp.Controls.Add(pb);
            flp.Controls.Add(tb);

            flVistaVacia.Controls.Add(flp);
        }

        private void FormVistaVacia_Load(object sender, EventArgs e)
        {
            MueveAnadir();
        }

        private void esconder_click(object sender, EventArgs e)
        {
            flVistaVacia.Location = new Point(1, 29);
            flVistaVacia.Width = 807;
            panelLateral.Visible = false;
            tsMenuCerrado.Visible = true;
        }

        private void desplegar_click(object sender, EventArgs e)
        {
            flVistaVacia.Location = new Point(198, 29);
            flVistaVacia.Width = 610;
            panelLateral.Visible = true;
            tsMenuCerrado.Visible = false;
        }
    }
}
