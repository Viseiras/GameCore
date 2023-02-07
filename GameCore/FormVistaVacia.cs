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
using System.Xml.Linq;

namespace GameCore
{
    
    public partial class FormVistaVacia : Form
    {
        private int cont;
        SQLiteConnection conexion;
        private int pkUsuario;
        FlowLayoutPanel flp;
        ControlPersonalizado control;
        public FormVistaVacia()
        {
            InitializeComponent();

        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            flp = new FlowLayoutPanel();
            PictureBox pb = new PictureBox();
            TextBox tb = new TextBox();

            
            formAñadir form = new formAñadir();
            if (form.ShowDialog() == DialogResult.OK)
            {
                tb.Text = "Titulo del videojuego";
            }

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
            FormPerfil form = new FormPerfil();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        public void MueveAnadir()
        { 
            flp = new FlowLayoutPanel();
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
            
            using (SQLiteConnection conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
            {
                conexion.Open();

                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM videojuegos WHERE fk_usuario = \"" + MetodosSqlite.pkUsuario + "\"", conexion))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Conseguimos los datos de la fila actual
                            string titulo = (string)reader["titulo"];
                            byte[] portada = (byte[])reader["portada"];
                            Image imagen;
                            // Convertimos el array de bytes a imagen
                            using (MemoryStream ms = new MemoryStream(portada))
                            {
                                //imagen = Image.FromStream(ms);
                                imagen = (Image)Bitmap.FromStream(ms);

                                // La mostramos
                                //pictureBox1.Image = imagen;
                            }

                            //ESTE MÉTODO FUNCIONA CUANDO SE AÑADE EL CONTROL PERSONALIZADO DEDSDE EL TOOLBOX
                            //controlPersonalizado1.UpdateData(titulo, imagen);

                            //PREGUNTAR A MIGUEL
                            
                            control = new ControlPersonalizado();
                            flp = new FlowLayoutPanel();
                            flp.Height = 200;
                            flp.Width = 130;
                            control.UpdateData(titulo, imagen);
                            flp.Controls.Add(control);  
                            flVistaVacia.Controls.Add(flp);
                            
                            
                        }
                    }
                }
                MueveAnadir();
            }
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

    //CLASE ENCARGADA DEL CONTROL PERSONALIZADO
    public class ControlPersonalizado : Control
    {
        private PictureBox portada;
        private Label titulo;

        public ControlPersonalizado()
        {
            // INICIAMOS LA IMAGEN
            portada = new PictureBox();
            portada.Width = 200;
            portada.Height = 200;
            //portada.Size = new System.Drawing.Size(200, 200);
            portada.SizeMode = PictureBoxSizeMode.Zoom;
            //portada.Image = Properties.Resources.SUMA;

            // INICIAMOS EL LABEL
            titulo = new Label();
            titulo.BackColor = Color.White;
            titulo.Text = "Titulo";
            titulo.AutoSize = true;

            // LOS AÑADIMOS AL CONTROL PERSONALIZADO
            this.Controls.Add(portada);
            this.Controls.Add(titulo);
        }

        public void UpdateData(string t, Image imagen)
        {
            // SE ACTUALIZA EL CONTROL EN BASE A LOS VALORES PASADOS COMO PARÁMETROS A LA FUNCIÓN
            portada.Image = imagen;
            titulo.Text = t;
        }
    }
}
