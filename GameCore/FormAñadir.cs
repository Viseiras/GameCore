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
    //Inciamos la clase de el formulario para añadir productos
    public partial class formAñadir : Form
    {
        private SQLiteConnection conexion;
        public Image Foto;
        public String Titulo { set; get; }

        public String Descripcion = " ";
        public string rutaPortada = "";

        public formAñadir()
        {
            InitializeComponent();
        }

        //Abrimos el explorador de archivos para añadir una foto
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

        //Boton que confirma la acción de añadir o cancela insertando la información en el DataGridView del form principal
        private void btnAceptar_Click(object sender, EventArgs e)
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
            }
            catch (Exception)
            {

            }
        }
        //cuando carga el formulario pone el valor del ID del form principal 
        private void formAnadir_Load(object sender, EventArgs e)
        {
        
        }

        //Comprobamos que el nombre no se encuentra vacío 
        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (tbTitulo.Text != "")
                tbTitulo.BackColor = Color.White;
            else
                tbTitulo.BackColor = Color.Red;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

