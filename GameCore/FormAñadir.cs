using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    //Inciamos la clase de el formulario para añadir productos
    public partial class formAñadir : Form
    {
        public Image Foto;
        public String Titulo { set; get; }

        public String Descripcion = " ";
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
            }
        }

        //Boton que confirma la acción de añadir o cancela insertando la información en el DataGridView del form principal
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                //Sacamos todos los campos de los textbox y demás cajas para guardarlos como atributos y así poder usarlos en el datagridview
                Titulo = tbTitulo.Text;
                Descripcion = tbDescripcion.Text;
                //Si estos dos campos están llenos (son los obligatorios no numerales) deja aceptar la operación. 
                if (Titulo != "")
                {
                    this.DialogResult = DialogResult.OK;
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

