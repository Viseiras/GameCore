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
    /// <summary>
    /// Clase que permite visualizar toda la información perteneciente al videojuego 
    /// </summary>
    public partial class VistaDetalle : Form
    {
        public String Titulo { get; set; }
        public VistaDetalle()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método que carga la información detallada del videojuego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VistaDetalle_Load(object sender, EventArgs e)
        {
            //para que cambie el nombre de la forma al título del juego
            this.Text = Titulo;

            //gestionamos los colores en base al modo oscuro
            if (FormPerfil.darkmode)
            {
                BackColor = Color.DarkGray;
            }
            else
            {
                BackColor = Color.White;
            }
            labelTitulo.Text = Titulo;
            pbPortada.AllowDrop = true;

            //leemos la información del videojuego para mostrar sus detalles (descripción, portada etc..)
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
                {
                    conexion.Open();

                    using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM videojuegos WHERE fk_usuario = \"" + MetodosSqlite.pkUsuario + "\"and titulo = \""+Titulo+"\"", conexion))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Conseguimos los datos de la fila actual
                                string descripcion = (string)reader["descripcion"];
                                byte[] portada = (byte[])reader["portada"];
                                Image imagen;
                                // Convertimos el array de bytes a imagen
                                using (MemoryStream ms = new MemoryStream(portada))
                                {
                                    //imagen = Image.FromStream(ms);
                                    imagen = (Image)Bitmap.FromStream(ms);


                                }
                                pbPortada.Image = imagen;
                                textBoxDescripcion.Text = descripcion;
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
        }
        /// <summary>
        /// Método que permite arrastrar una imagen al pictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbPortada_DragDrop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                string[] fileNames = data as string[];
                if(fileNames.Length> 0)
                {
                    pbPortada.Image = Image.FromFile(fileNames[0]);
                }
            }
        }

        private void pbPortada_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pbPortada.Enabled = true;
            textBoxDescripcion.Enabled = true; 
            labelTitulo.Enabled = true; 
        }
        /// <summary>
        /// Método que elimina el videojuego de la Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quieres eliminar este videojuego?") == DialogResult.OK)
            {
                //iniciamos la operación de borrado del videojuego en la BD
                try
                {
                    using (SQLiteConnection conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
                    {
                        conexion.Open();

                        using (SQLiteCommand command = new SQLiteCommand("DELETE FROM videojuegos WHERE fk_usuario = \"" + MetodosSqlite.pkUsuario + "\"and titulo = \"" + Titulo + "\"", conexion))
                        {
                            command.ExecuteNonQuery();
                            
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    // Handle the exception here
                    MessageBox.Show("Error al acceder a la base de datos: " + ex.Message);
                }

            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {

        }
    }
}
