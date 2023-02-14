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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace GameCore
{
    /// <summary>
    /// Clase principal de la aplicación donde se muestra la colección de videojuegos del usuario que haya iniciado sesión
    /// </summary>
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

        /// <summary>
        /// Método que abre la forma añadir y se realiza el INSERT del videojuego en su tabla de la Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                                    this.control.Cursor = Cursors.Hand;
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
        /// <summary>
        /// Método que nos lleva a la forma del perfil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Settings_Click(object sender, EventArgs e)
        {
            FormPerfil form = new FormPerfil();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
            if(FormPerfil.darkmode)
            {
                panelLateral.BackColor = Color.FromArgb(34, 34, 34);
                BackColor = Color.FromArgb(34, 34, 34);
                flVistaVacia.BackColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                panelLateral.BackColor= Color.FromArgb(43, 43, 43);
                BackColor = BackColor = Color.FromArgb(235, 235, 235);
                flVistaVacia.BackColor = Color.FromArgb(235, 235, 235);
            }
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
                {
                    conexion.Open();

                    using (SQLiteCommand command = new SQLiteCommand("select avatar from usuarios where id = \"" + MetodosSqlite.pkUsuario + "\"", conexion))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] avatar = (byte[])reader["avatar"];
                                Image imagen;
                                // Convertimos el array de bytes a imagen
                                using (MemoryStream ms = new MemoryStream(avatar))
                                {
                                    //imagen = Image.FromStream(ms);
                                    imagen = (Image)Bitmap.FromStream(ms);


                                }
                                pictureBox_ImagenPerfil.Image = imagen;
                            }
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Handle the exception here
                MessageBox.Show("Error al acceder a la base de datos: " + ex.Message);
            }
            pictureBox_ImagenPerfil.Refresh();
        }

        /// <summary>
        /// Método que nos permite mover el control personalizado de Añadir conforme se van añadiendo videojuegos a la Base de Datos
        /// </summary>
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

        /// <summary>
        /// Método que carga los datos de la vista vacía, se realiza un SELECT a la Base de Datos en función del usuario que ha iniciado sesión y se cargan los videojuegos que haya introducido y están asociados a su cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            int contadorParaAyuda = 0;
                            while (reader.Read())
                            {
                                contadorParaAyuda++;
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
                                this.control.Cursor = Cursors.Hand;
                                control.UpdateData(titulo, imagen);
                                flVistaVacia.Controls.Add(control);

                            }

                            //no hay videojuegos introducidos por el usuario aún por lo que se muestra la ayuda de vista vacía
                            if(contadorParaAyuda == 0)
                            {
                                FormaAyuda ayuda = new FormaAyuda();
                                ayuda.ShowDialog();
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
            
        /// <summary>
        /// Método que permite esconder el panel lateral
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void esconder_click(object sender, EventArgs e)
        {
            flVistaVacia.Location = new Point(48, 29);
            flVistaVacia.Width = flVistaVacia.Width + 60;
            panelLateral.Visible = false;
            tsMenuCerrado.Visible = true;
        }
        /// <summary>
        /// Método que permite desplegar el panel lateral
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void desplegar_click(object sender, EventArgs e)
        {
            flVistaVacia.Location = new Point(198, 29);
            flVistaVacia.Width = flVistaVacia.Width - 60;
            panelLateral.Visible = true;
            tsMenuCerrado.Visible = false;
        }

        /// <summary>
        /// Método que permite cerrar el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_salir_programa_menu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Método que permite cerrar la sesión actual 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaInicioSesion inicioSesion = new FormaInicioSesion();
            inicioSesion.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Método que permite cerrar la sesión actual 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaInicioSesion inicioSesion = new FormaInicioSesion();
            inicioSesion.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Método para buscar un videojuego entre la colección asociada al usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_buscar_Click(object sender, EventArgs e)
        {
            string juego_buscar = textBox_buscar.Text;
            juego_buscar = juego_buscar.ToLower() + "%";
            //limpio los juegos del flowlayout
            flVistaVacia.Controls.Clear();

            try
            {
                using (conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
                {
                    conexion.Open();

                    using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM videojuegos WHERE LOWER(titulo) LIKE \"" + juego_buscar + "\"" + "AND fk_usuario = " + MetodosSqlite.pkUsuario, conexion))
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
                                this.control.Cursor = Cursors.Hand;
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
                MessageBox.Show("Erro al acceder a la base de datos: " + ex.Message);
            }
        }
        /// <summary>
        /// Método donde se ejecuta la acción de buscar cuando se pulsa la tecla enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button_buscar_Click(null, null);
            }
            
        }

        /// <summary>
        /// Método que recarga los datos del FlowLayoutPanel para mostrar todos los videojuegos del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_buscarClick(object sender, EventArgs e)
        {
            //limpio los juegos del flowlayout
            flVistaVacia.Controls.Clear();
            this.FormVistaVacia_Load(null, null);
        }
        /// <summary>
        /// Método que cuando se quita el foco de la pictureBox muestra un texto de placeholder para ayudar al usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_buscar_Leave(object sender, EventArgs e)
        {
            if (textBox_buscar.Text == "")
            {
                textBox_buscar.Text = "Introduce el título de un videojuego";
                textBox_buscar.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// Método que oculta el placeholder cuando se hace click en el pictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_buscar_Enter(object sender, EventArgs e)
        {
            if (textBox_buscar.Text == "Introduce el título de un videojuego")
            {
                textBox_buscar.Text = "";
            }
        }
        /// <summary>
        /// Método que abre la forma de ayuda cuando se hace clic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaAyuda ayuda = new FormaAyuda();
            if(ayuda.ShowDialog()==DialogResult.OK)
            {

            }
        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPerfil form = new FormPerfil();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Ayuda_F1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FormaAyuda ayuda = new FormaAyuda();
                if (ayuda.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void Ayuda_F1_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'F')
            {
                FormaAyuda ayuda = new FormaAyuda();
                if (ayuda.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
        //TODO Arreglar esta wea
      /*  private void ControlPersonalizado_DobleClick(object sender, EventArgs e)
        {
            FormDetalle vistaDetalle = new FormDetalle();
            vistaDetalle.Titulo = ControlVideojuego.titol;
            vistaDetalle.img = ControlVideojuego.img;
            //vistaDetalle.Portada...
            if (vistaDetalle.ShowDialog() == DialogResult.OK)
            {
                flVistaVacia.Refresh();
            }
        }*/
    }
}
