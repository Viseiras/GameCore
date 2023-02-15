using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
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
            dgvVideojuegos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            using (SQLiteConnection conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
            {
                conexion.Open();
                string query = "SELECT titulo, descripcion, portada FROM videojuegos where fk_usuario = 1";

                // Create a DataTable to hold the data
                DataTable dataTable = new DataTable();

                // Use a DataAdapter to fill the DataTable with data from the database
                using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, conexion))
                {
                    dataAdapter.Fill(dataTable);
                }

                // Set the DataSource property of the DataGridView to the DataTable
                dgvVideojuegos.DataSource = dataTable;
            }

        }
    }
}
