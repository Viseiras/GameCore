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
        private int cont=0;
        SQLiteConnection conexion;
        private int pkUsuario;
        FlowLayoutPanel flp;
        ControlVideojuego control;
        public FormVistaVacia()
        {
            InitializeComponent();

        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            formAñadir form = new formAñadir();
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    flVistaVacia.Controls.RemoveAt(cont-1);
                    cont--;
                    using (SQLiteConnection conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
                    {
                        conexion.Open();

                        using (SQLiteCommand command = new SQLiteCommand("select * from videojuegos where fk_usuario = \"" + MetodosSqlite.pkUsuario + "\" order by id desc limit 1", conexion))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                if(reader.Read())
                                {
                                    flVistaVacia.Refresh();
                                    // Conseguimos los datos de la fila actual
                                    var titulo = (string)reader["titulo"];
                                    byte[] portada = (byte[])reader["portada"];
                                    var id = reader["id"];
                                    Image imagen;
                                    // Convertimos el array de bytes a imagen
                                    using (MemoryStream ms = new MemoryStream(portada))
                                    {
                                        //imagen = Image.FromStream(ms);
                                        imagen = (Image)Bitmap.FromStream(ms);


                                    }

                                    control = new ControlVideojuego();
                                    control.Size = new Size(200, 200);
                                    //ver por qué no funciona el margin
                                    //control.Margin = new Padding(0,-15,0,0);
                                    control.UpdateData(titulo, imagen);
                                    flVistaVacia.Controls.Add(control);
                                    cont++;
                                }
                                    
                              
                            }
                        }
                        MueveAnadir();
                    }
                }
                catch (SQLiteException ex)
                {
                    // Handle the exception here
                    MessageBox.Show("Error al acceder a la base de datos: " + ex.Message);
                }
            }
            
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            FormPerfil form = new FormPerfil();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
            if(FormPerfil.darkmode)
            {
                BackColor = Color.DarkGray;
                flVistaVacia.BackColor = Color.LightBlue;
            }
            else
            {
                BackColor= Color.White;
                flVistaVacia.BackColor = Color.LightCyan;
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
            cont++;
        }

        private void FormVistaVacia_Load(object sender, EventArgs e)
        {
            label_nombreUsuario.Text = FormaInicioSesion.nombreUsuario;
            try
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
                                cont++;
                                // Conseguimos los datos de la fila actual
                                string titulo = (string)reader["titulo"];
                                byte[] portada = (byte[])reader["portada"];
                                Image imagen;
                                // Convertimos el array de bytes a imagen
                                using (MemoryStream ms = new MemoryStream(portada))
                                {
                                    //imagen = Image.FromStream(ms);
                                    imagen = (Image)Bitmap.FromStream(ms);


                                }

                                control = new ControlVideojuego();
                                control.Size = new Size(200, 200);
                                control.UpdateData(titulo, imagen);
                                flVistaVacia.Controls.Add(control);

                            }
                        }
                    }
                    MueveAnadir();
                }
            }
            
            catch (SQLiteException ex)
            {
                // Handle the exception here
                MessageBox.Show("Error al acceder a la base de datos: " + ex.Message);
            }


            //PORCION DE CODIGO ENCARGADA DE CARGAR LA IMAGEN DE PERFIL QUE HAYA ESTABLECIDO EL USUARIO
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
                {
                    conexion.Open();

                    using (SQLiteCommand command = new SQLiteCommand("SELECT avatar FROM usuarios WHERE nombre_usuario = \"" + FormaInicioSesion.nombreUsuario + "\"", conexion))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //si el lector no está vacío es que hay imagen, por lo tanto la actualizo
                                if (reader["avatar"] != DBNull.Value)
                                {
                                    byte[] portada = (byte[])reader["avatar"];
                                    Image Foto;
                                    // Convertimos el array de bytes a imagen
                                    using (MemoryStream ms = new MemoryStream(portada))
                                    {
                                        Foto = (Image)Bitmap.FromStream(ms);
                                        pictureBox_ImagenPerfil.Image = Foto;
                                    }
                                }

                            }

                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Handle the exception here
                MessageBox.Show("Erro al acceder a la base de datos: " + ex.Message);
            }

        }
            

        private void esconder_click(object sender, EventArgs e)
        {
            flVistaVacia.Location = new Point(48, 29);
            flVistaVacia.Width = flVistaVacia.Width + 60;
            panelLateral.Visible = false;
            tsMenuCerrado.Visible = true;
        }

        private void desplegar_click(object sender, EventArgs e)
        {
            flVistaVacia.Location = new Point(198, 29);
            flVistaVacia.Width = flVistaVacia.Width - 60;
            panelLateral.Visible = true;
            tsMenuCerrado.Visible = false;
        }

        private void boton_salir_programa_menu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ControlPersonalizado_DobleClick(object sender, EventArgs e)
        {
            VistaDetalle vistaDetalle = new VistaDetalle();
           // vistaDetalle.Titulo = this.titulo.Text;
            //vistaDetalle.Portada...
            if (vistaDetalle.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void label_cerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
