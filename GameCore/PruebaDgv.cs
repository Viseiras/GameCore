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

        }
    }
}
