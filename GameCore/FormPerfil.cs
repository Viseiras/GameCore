using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace GameCore
{
    /// <summary>
    /// Clase donde se muestra la información personal perteneciente al usuario que haya iniciado sesión.
    /// </summary>
    public partial class FormPerfil : Form
    {
        public Image Foto;
        public string rutaPortada = "";

        public static bool darkmode = false;
        public FormPerfil()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para esconder el panel lateral
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void esconder_click(object sender, EventArgs e)
        {
            panelLateral.Visible = false;
            tsMenuCerrado.Visible = true;
        }

        /// <summary>
        /// Método para desplegar el panel lateral
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void desplegar_click(object sender, EventArgs e)
        {
            panelLateral.Visible = true;
            tsMenuCerrado.Visible = false;
        }

        /// <summary>
        /// Método para cambiar el modo oscuro de la aplicación
        /// </summary>
        public void darkModeChanger()
        {
            if (darkmode == false)
            {
                darkmode = true;
                panelLateral.BackColor= Color.FromArgb(34, 34, 34);
                BackColor = Color.FromArgb(64, 64, 64);
            }
            else if (darkmode == true)
            {
                darkmode = false;
                panelLateral.BackColor = Color.FromArgb(43, 43, 43);
                BackColor = Color.FromArgb(235, 235, 235);
            }
        }

        /// <summary>
        /// Método donde se devuelven los ajustes a sus valores por defecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ajustes_por_defecto_Click(object sender, EventArgs e)
        {
            toogleBoxCustomDarkMode.Checked = false;
        }

        /// <summary>
        /// Método para aceptar los cambios realizados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_guardar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Método para alternar entre el modo oscuro y el modo dia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toogleBoxCustomDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            darkModeChanger();
        }

        /// <summary>
        /// Método que nos permite cambiar la imagen de perfil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxFotoPerfil_Click(object sender, EventArgs e)
        {
            CambiarImagen();
        }

        /// <summary>
        /// Método que nos permite cambiar la imagen de perfil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCambiarImagen_Click(object sender, EventArgs e)
        {
            CambiarImagen();
        }

        /// <summary>
        /// Método que nos permite cambiar la imagen de perfil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CambiarImagen()
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "JPG|*.jpg;*.jpeg;*.png;*.gif";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                //Convertimos a Bitmap la imagen para que se muestre visualmente en el PictureBox
                Foto = (Image)new Bitmap(opd.FileName);
                pictureBoxCambiarFotoPerfil.Image = new Bitmap(opd.FileName);
                pictureBoxFotoPerfil.Image = new Bitmap(opd.FileName);
                rutaPortada = opd.FileName;
                try
                {
                    using (SQLiteConnection conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
                    {
                        conexion.Open();
                        byte[] portada = System.IO.File.ReadAllBytes(rutaPortada);

                        using (SQLiteCommand command = new SQLiteCommand("UPDATE usuarios SET avatar = @imagen WHERE nombre_usuario = \"" + FormaInicioSesion.nombreUsuario + "\"", conexion))
                        {
                            command.Parameters.AddWithValue("@imagen", portada);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Foto de perfil cambiada");
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    // Handle the exception here
                    MessageBox.Show("Erro al acceder a la base de datos: " + ex.Message);
                }
            }

        }

        /// <summary>
        /// Método en el que se cargan los ajustes realizados por el usuario, como su foto de perfil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPerfil_Load_1(object sender, EventArgs e)
        {
            label_nombreUsuario.Text = FormaInicioSesion.nombreUsuario;

            if (darkmode == true)
            {
                toogleBoxCustomDarkMode.Checked = true;
                darkModeChanger();
            }

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
                                    // Convertimos el array de bytes a imagen
                                    using (MemoryStream ms = new MemoryStream(portada))
                                    {
                                        Foto = (Image)Bitmap.FromStream(ms);
                                        pictureBoxCambiarFotoPerfil.Image = Foto;
                                        pictureBoxFotoPerfil.Image = Foto;
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
    }
}
