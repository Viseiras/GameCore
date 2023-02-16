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

namespace GameCore
{
    /// <summary>
    /// Clase encargada de añadir videojuegos a la base de datos y mostrarlos en el FlowLayoutPanel
    /// </summary>
    public partial class formAñadir : Form
    {
        private SQLiteConnection conexion;
        public Image Foto;
        public String Titulo { set; get; }

        public String Descripcion = "";
        public string rutaPortada = "";

        public formAñadir()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Abrimos el explorador de archivos para añadir una foto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFoto_Click(object sender, EventArgs e)
        {
            //Creamos el objeto OpenFileDialog para abrir el explorador de archivos con su filtro para que sean esos 4 tipos de imagenes (los gif se quedan con el primer frame)
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "JPG|*.jpg;*.jpeg;*.png;*.gif";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                //Convertimos a Bitmap la imagen para que se muestre visualmente en el PictureBox
                Foto = (Image)new Bitmap(opd.FileName);
                pictureBoxAnadir.Image = new Bitmap(opd.FileName);
                rutaPortada = opd.FileName;
            }
        }
        /// <summary>
        /// cuando carga el formulario pone el valor del ID del form principal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formAnadir_Load(object sender, EventArgs e)
        {
            languajeChanger();
            pictureBoxAnadir.AllowDrop = true;
            if (FormPerfil.darkmode)
            {
                BackColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                BackColor = Color.FromArgb(235, 235, 235);
            }
        }

        /// <summary>
        /// Comprobamos que el nombre no se encuentra vacío 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (tbTitulo.Text != "")
                tbTitulo.BackColor = Color.White;
            else
                tbTitulo.BackColor = Color.Red;
        }
        /// <summary>
        /// Boton de cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// Método que nos sirve para añadir la imagen al picture box cuando se agrega mediante drag and drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAnadir_DragDrop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                string[] fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    rutaPortada= fileNames[0];
                    pictureBoxAnadir.Image = Image.FromFile(fileNames[0]);
                }
            }
        }

        private void pictureBoxAnadir_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            if(cbDesarrolladores.SelectedIndex!=-1)
            {
                try
                {
                    /*
                 * INSERTAR EN LA BD EL VIDEOJUEGO, ESTRUCTURA DE LA TABLA
                 * TABLE videojuegos (id INTEGER PRIMARY KEY AUTOINCREMENT, titulo TEXT, descripcion TEXT, desarrolladores TEXT, 
                 * portada BLOB, fk_usuario INTEGER, FOREIGN KEY (fk_usuario) REFERENCES usuarios(id))*/


                    using (conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
                    {
                        conexion.Open();
                        byte[] portada = System.IO.File.ReadAllBytes(rutaPortada);

                        //INSERTAMOS LOS DATOS DEL VIDEOJUEGO EN LA BASE DE DATOS
                        using (SQLiteCommand command = new SQLiteCommand("INSERT INTO videojuegos (titulo,descripcion,desarrolladores,portada,fk_usuario) VALUES (@titulo,@descripcion,@desarrolladores,@portada,@fk_usuario)", conexion))
                        {
                            command.Parameters.AddWithValue("@titulo", tbTitulo.Text);
                            command.Parameters.AddWithValue("@descripcion", tbDescripcion.Text);
                            command.Parameters.AddWithValue("@desarrolladores", cbDesarrolladores.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@portada", portada);
                            command.Parameters.AddWithValue("@fk_usuario", MetodosSqlite.pkUsuario);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Juego insertado en la BD.");
                        }
                    }
                    this.DialogResult = DialogResult.OK;
                }
                catch (SQLiteException ex)
                {
                    // Handle the exception here
                    MessageBox.Show("Erro al acceder a la base de datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un desarrollador");
            }
           
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button_añadir_imagenClick(object sender, EventArgs e)
        {
            //Creamos el objeto OpenFileDialog para abrir el explorador de archivos con su filtro para que sean esos 4 tipos de imagenes (los gif se quedan con el primer frame)
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "JPG|*.jpg;*.jpeg;*.png;*.gif";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                //Convertimos a Bitmap la imagen para que se muestre visualmente en el PictureBox
                Foto = (Image)new Bitmap(opd.FileName);
                pictureBoxAnadir.Image = new Bitmap(opd.FileName);
                rutaPortada = opd.FileName;
            }
        }
        /// <summary>
        /// Método que sirve para cambiar el idioma de la vista en base a qué idioma ha establecido el usuarios
        /// </summary>
        public void languajeChanger()
        {
            //0 = español
            if (FormPerfil.idIdioma == 0)
            {
                lblTitulo.Text = "Titulo*";
                lblDescripcion.Text = "Descripción*";
                labelDesarrolladores.Text = "Desarrolladores*";
                lblPortada.Text = "Portada*";
                button_añadir_imagen.Text = "Añadir imagen";
                button_cancelar.Text = "Cancelar";
                button_aceptar.Text = "Aceptar";
            }
            //1 = portugués
            else if (FormPerfil.idIdioma == 1)
            {
                lblTitulo.Text = "Nome*";
                lblDescripcion.Text = "Descrição";
                labelDesarrolladores.Text = "Desenvolvedores*";
                lblPortada.Text = "Arte de capa*";
                button_añadir_imagen.Text = "Adicionar imagem";
                button_cancelar.Text = "Cancelar";
                button_aceptar.Text = "Aceitar";
            }
            //2 = inglés
            else if (FormPerfil.idIdioma == 2)
            {
                lblTitulo.Text = "Title*";
                lblDescripcion.Text = "Description*";
                labelDesarrolladores.Text = "Developers*";
                lblPortada.Text = "Cover*";
                button_añadir_imagen.Text = "Add image";
                button_cancelar.Text = "Cancel";
                button_aceptar.Text = "Accept";
            }
        }
    }
}

