using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCore
{
    public partial class FormVistaVacia : Form
    {
        private int cont;
        SQLiteConnection conexion;
        private int pkUsuario;
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
            tb.Text = "Titulo del videojuego";


            flp.Height = 200;
            flp.Width = 130;
            pb.Width = 120;
            tb.Width = 120;
            pb.Height = 160;
            tb.TextAlign = HorizontalAlignment.Center;
            flp.Controls.Add(pb);
            flp.Controls.Add(tb);

            /*
             * INSERTAR EN LA BD EL VIDEOJUEGO, ESTRUCTURA DE LA TABLA
             * TABLE videojuegos (id INTEGER PRIMARY KEY AUTOINCREMENT, titulo TEXT, descripcion TEXT, desarrolladores TEXT, 
             * portada BLOB, fk_usuario INTEGER, FOREIGN KEY (fk_usuario) REFERENCES usuarios(id))
             

            using (conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
            {
                conexion.Open();

                byte[] portada = System.IO.File.ReadAllBytes(opd.FileName);

                //INSERTAMOS LOS DATOS DEL VIDEOJUEGO EN LA BASE DE DATOS
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO videojuegos (titulo,descripcion,desarrolladores,portada,fk_usuario) VALUES (@titulo,@descripcion,@desarrolladores,@portada,@fk_usuario)", conexion))
                {
                    command.Parameters.AddWithValue("@titulo", "Titulo juego");
                    command.Parameters.AddWithValue("@descripcion", "Descripcion de prueba del videojuego");
                    command.Parameters.AddWithValue("@desarrolladores", "Nintendo");
                    command.Parameters.AddWithValue("@portada", imageBytes);
                    command.Parameters.AddWithValue("@fk_usuario", MetodosSqlite.GetPkUsuario());
                    //command.Parameters.AddWithValue("@fk_usuario", 1);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Juego insertado en la BD.");
                }
            }*/


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
            pb.Image = (Image)new Bitmap(@".\\..\\..\\Resources\\SUMA.png");

            flp.Height = 200;
            flp.Width = 130;
            pb.Width = 120;
            tb.Width = 120;
            pb.Height = 160;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            flp.Controls.Add(pb);
            flp.Controls.Add(tb);

            flVistaVacia.Controls.Add(flp);
            pb.DoubleClick += btnAnadir_Click;
        }

        private void FormVistaVacia_Load(object sender, EventArgs e)
        {
            MueveAnadir();
        }

        private void esconder_click(object sender, EventArgs e)
        {
            flVistaVacia.Location = new Point(48, 29);
            flVistaVacia.Width = 763;
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
