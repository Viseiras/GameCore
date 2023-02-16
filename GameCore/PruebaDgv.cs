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
    public partial class PruebaDgv : Form
    {
        public PruebaDgv()
        {
            InitializeComponent();
        }

        private void PruebaDgv_Load(object sender, EventArgs e)
        {
            //establecemos el nombre del usuario
            string str = FormaInicioSesion.nombreUsuario;
            string mayus = char.ToUpper(str[0]) + str.Substring(1);
            label_nombreUsuario.Text = mayus;

            string titulo;
            string descripcion;
            int rowid=0;
            dgvVideojuegos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            using (SQLiteConnection conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
            {
                conexion.Open();
                string query = "SELECT titulo, descripcion, portada FROM videojuegos where fk_usuario = " + MetodosSqlite.pkUsuario;
                using (SQLiteCommand command = new SQLiteCommand(query, conexion))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Image imagen;
                            titulo = (string)reader["titulo"];
                            descripcion = (string)reader["descripcion"];
                            byte[] portada = (byte[])reader["portada"];
                            // Convertimos el array de bytes a imagen
                            using (MemoryStream ms = new MemoryStream(portada))
                            {
                                imagen = (Image)Bitmap.FromStream(ms);
                            }
                            string[] campos= new string[2];
                            campos[0]=titulo.ToString();
                            campos[1]=descripcion.ToString();
                            dgvVideojuegos.Rows.Add(campos);
                            dgvVideojuegos.Rows[rowid].Cells[2].Value = imagen;
                            rowid++;
                        }
                    }
                }
                

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

        private void label_vistaLista_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_cerrarSesion_Click(object sender, EventArgs e)
        {

        }
    }
}
