using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameCore
{
    /// <summary>
    /// Clase que permite visualizar toda la información perteneciente al videojuego 
    /// </summary>
    public partial class FormDetalle : Form
    {
        /// <summary>
        /// Atributo titulo
        /// </summary>
        public String Titulo { get; set; }
        private bool modoedicion = false;
        private bool fotomodificada = false;
        private string rutaPortada;
        private byte[] portadaAnterior;
        /// <summary>
        /// Constructor de la forma detalle
        /// </summary>
        public FormDetalle()
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
            tbTitulo.Text = Titulo;
            CambiarIdioma();
            //gestionamos los colores en base al modo oscuro
            darkModeChanger();
            labelTitulo.Text = Titulo;
            pbPortada.AllowDrop = true;

            //leemos la información del videojuego para mostrar sus detalles (descripción, portada etc..)
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
                {
                    conexion.Open();

                    using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM videojuegos WHERE fk_usuario = \"" + MetodosSqlite.pkUsuario + "\"and titulo = \"" + Titulo + "\"", conexion))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Conseguimos los datos de la fila actual
                                string descripcion = (string)reader["descripcion"];
                                byte[] portada = (byte[])reader["portada"];
                                this.portadaAnterior = portada;
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
                if (fileNames.Length > 0)
                {
                    pbPortada.Image = Image.FromFile(fileNames[0]);
                    fotomodificada = true;
                }
            }
        }

        private void pbPortada_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            fotomodificada = true;
        }
        /// <summary>
        /// Se activa el modo de edición cuando se hace click en el botón de editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (modoedicion == false)
            {
                modoedicion = true;
                pbPortada.Enabled = true;
                pbPortada.Cursor = Cursors.Hand;
                textBoxDescripcion.Enabled = true;
                labelTitulo.Enabled = true;
                labelTitulo.Cursor = Cursors.Hand;
                lblModoEdicion.Visible = true;
                btnCancelar.Visible = true;
                Guardar.Visible = true;
                btnEliminar.Visible = false;
                btnCancelar.Visible = true;
                labelTitulo.Visible = false;
                tbTitulo.Visible = true;

            }
        }
        /// <summary>
        /// Método que elimina el videojuego de la Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Estás seguro que quieres eliminar este videojuego?", "Eliminar", MessageBoxButtons.YesNoCancel);
            if (confirmacion == DialogResult.Yes)
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
                            //cargamos la anterior forma tras eliminar el videojuego
                            FormVistaVacia previousForm = (FormVistaVacia)Application.OpenForms[Application.OpenForms.Count - 2];
                            previousForm.CargarDatos();
                            this.DialogResult = DialogResult.OK;
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
        /// <summary>
        /// Cuando se hace doble click en la portada se abre el OpenFileDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbPortada_DoubleClick(object sender, EventArgs e)
        {
            //Creamos el objeto OpenFileDialog para abrir el explorador de archivos con su filtro para que sean esos 4 tipos de imagenes (los gif se quedan con el primer frame)
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "JPG|*.jpg;*.jpeg;*.png;*.gif";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                //Convertimos a Bitmap la imagen para que se muestre visualmente en el PictureBox
                Image Foto = (Image)new Bitmap(opd.FileName);
                pbPortada.Image = new Bitmap(opd.FileName);
                rutaPortada = opd.FileName;
                fotomodificada = true;
            }
        }
        /// <summary>
        /// Boton cancelar para salir del modo edición, se cambia lo que se muestra al usuario 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (modoedicion == true)
            {
                modoedicion = false;
                pbPortada.Enabled = false;
                textBoxDescripcion.Enabled = false;
                labelTitulo.Enabled = false;
                lblModoEdicion.Visible = false;
                btnCancelar.Visible = false;
                Guardar.Visible = false;
                btnEliminar.Visible = true;
                btnCancelar.Visible = false;
                labelTitulo.Visible = true;
                tbTitulo.Visible = false;
            }
        }
        /// <summary>
        /// Cuando se hace clic en el botón guardar se realiza un UPDATE en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Guardar_Click(object sender, EventArgs e)
        {
            if (modoedicion == true)
            {
                modoedicion = false;
                pbPortada.Enabled = false;
                textBoxDescripcion.Enabled = false;
                labelTitulo.Enabled = false;
                lblModoEdicion.Visible = false;
                btnCancelar.Visible = false;
                Guardar.Visible = false;
                btnEliminar.Visible = true;
                btnCancelar.Visible = false;
                labelTitulo.Visible = true;
                tbTitulo.Visible = false;
            }

            if (string.IsNullOrEmpty(tbTitulo.Text))
            {
                if (FormPerfil.idIdioma == 0)
                {
                    MessageBox.Show("El titulo no puede estar vacío");
                }
                else if (FormPerfil.idIdioma == 1)
                {
                    MessageBox.Show("O título não pode estar vazio");
                }
                else if (FormPerfil.idIdioma == 2)
                {
                    MessageBox.Show("Title can't be empty");
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxDescripcion.Text))
                {
                    if (FormPerfil.idIdioma == 0)
                    {
                        MessageBox.Show("La descripción no puede estar vacío");
                    }
                    else if (FormPerfil.idIdioma == 1)
                    {
                        MessageBox.Show("A descrição não pode estar vazia");
                    }
                    else if (FormPerfil.idIdioma == 2)
                    {
                        MessageBox.Show("Description can't be empty");
                    }
                }
                else
                {
                    try
                    {
                        using (SQLiteConnection conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
                        {
                            byte[] portada;
                            conexion.Open();
                            if (fotomodificada)
                            {
                                portada = System.IO.File.ReadAllBytes(rutaPortada);
                            }
                            else
                            {
                                portada = portadaAnterior;
                            }
                            using (SQLiteCommand command = new SQLiteCommand("UPDATE videojuegos SET titulo = @titulo, portada = @portada, descripcion = @descripcion WHERE titulo = \"" + labelTitulo.Text + "\"", conexion))
                            {
                                command.Parameters.AddWithValue("@titulo", tbTitulo.Text);
                                command.Parameters.AddWithValue("@portada", portada);
                                command.Parameters.AddWithValue("@descripcion", textBoxDescripcion.Text);
                                command.ExecuteNonQuery();
                                FormVistaVacia previousForm = (FormVistaVacia)Application.OpenForms[Application.OpenForms.Count - 2];
                                previousForm.CargarDatos();
                            }
                        }

                        //Mandamos un mensaje para que sepa que se ha actualizado en la base de datos
                        if (FormPerfil.idIdioma == 0)
                        {
                            MessageBox.Show("Se ha actualizado el juego");
                        }
                        else if (FormPerfil.idIdioma == 1)
                        {
                            MessageBox.Show("Jogo inserido no banco de dados");
                        }
                        else if (FormPerfil.idIdioma == 2)
                        {
                            MessageBox.Show("Game inserted into the database");
                        }
                        //Cerramos la forma Detalle una vez guardado
                        this.DialogResult = DialogResult.OK;

                    }
                    catch (SQLiteException ex)
                    {
                        // Handle the exception here
                        if (FormPerfil.idIdioma == 0)
                        {
                            MessageBox.Show("Error al acceder a la base de datos: " + ex.Message);
                        }
                        else if (FormPerfil.idIdioma == 1)
                        {
                            MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                        }
                        else if (FormPerfil.idIdioma == 2)
                        {
                            MessageBox.Show("Unable accessing the database: " + ex.Message);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Funcion para cambiar el idioma de la aplicacion en base al idioma que haya seleccionado el usuario 
        /// </summary>
        public void CambiarIdioma()
        {
            if (FormPerfil.idIdioma == 0)
            {
                lblModoEdicion.Text = "Estás editando";
                btnCancelar.Text = "Cancelar";
                btnEditar.Text = "Editar";
                Guardar.Text = "Guardar";
                btnEliminar.Text = "Eliminar";

            }
            else if (FormPerfil.idIdioma == 1)
            {
                lblModoEdicion.Text = "Voçe está editando";
                btnCancelar.Text = "Cancelar";
                btnEditar.Text = "Editar";
                Guardar.Text = "Manter";
                btnEliminar.Text = "Eliminar";
            }
            else if (FormPerfil.idIdioma == 2)
            {
                lblModoEdicion.Text = "You are editing";
                btnCancelar.Text = "Cancel";
                btnEditar.Text = "Edit";
                Guardar.Text = "Save";
                btnEliminar.Text = "Delete";
            }
        }

        private void darkModeChanger()
        {
            if (FormPerfil.darkmode)
            {
                BackColor = Color.FromArgb(64, 64, 64);
                lblModoEdicion.ForeColor = Color.White;
                labelTitulo.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.FromArgb(235, 235, 235);
                lblModoEdicion.ForeColor = Color.Black;
                labelTitulo.ForeColor = Color.Black;
            }
        }
    }
}
