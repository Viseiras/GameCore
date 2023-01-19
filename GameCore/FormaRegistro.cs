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
    public partial class FormaRegistro : Form
    {
        public FormaRegistro()
        {
            InitializeComponent();

            //iniciamos la conexión con la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection("Data Source=usuarios.db"))
            {
                conexion.Open();
                
            }
        }

        private void button_registrar_Click(object sender, EventArgs e)
        {
            //string sql = "INSERT INTO usuarios (nombre_usuario,password) VALUES " + textBox_nomUsuario.Text + 
            //commit
            
        }
    }
}
