using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCore
{
    /// <summary>
    /// clase estática hecha para facilitar la utilización de métodos de SQLite en las demás formas del proyecto
    /// </summary>
    internal static class MetodosSqlite
    {
        public static int pkUsuario;
        /// <summary>
        /// metodo que devuelve true o false en función del parámetro que se le pase, perteneciente a un nombre de usuario en la BD
        /// </summary>
        /// <param name="nombre">Nombre del usuario del que se le quiere validar la contraseña</param>
        /// <returns></returns>
        public static bool CompruebaUsuario(string nombre)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
                {
                    conexion.Open();
                    //abrimos un dataReader para leer datos de la BD
                    SQLiteDataReader lector;
                    //creamos la sentencia o comando, llamado select
                    SQLiteCommand select = conexion.CreateCommand();
                    //le asignamos la consulta
                    select.CommandText = "SELECT * FROM usuarios WHERE LOWER(nombre_usuario) = \"" + nombre.ToLower() + "\"";
                    lector = select.ExecuteReader();

                    //si el lector detecta un usuario devuelve true
                    if (lector.Read())
                    {
                        lector.Dispose();
                        return true;
                    }
                    //si no devuelvo false
                    lector.Dispose();
                    return false;
                }
            }
            
            catch (SQLiteException ex)
            {
                // Handle the exception here
                MessageBox.Show("Error al acceder a la base de datos: " + ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Método que nos sirve para comprobar la contraseña asociada al usuario
        /// </summary>
        /// <param name="usuario">Se comprueba la contraseña perteneciente al nombre de usuario pasado como parámetro</param>
        /// <returns>devuelve un string con la contraseña de la base de datos</returns>
        public static string CompruebaContraseña(string usuario)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
                {
                    conexion.Open();
                    SQLiteDataReader lector;
                    SQLiteCommand select = conexion.CreateCommand();
                    select.CommandText = "SELECT contraseña FROM usuarios WHERE nombre_usuario = \"" + usuario + "\"";
                    lector = select.ExecuteReader();
                    string resultado = "";
                    if (lector.Read())
                    {
                        resultado = lector["contraseña"].ToString();

                    }
                    lector.Dispose();
                    return resultado;
                }
            }
            
            catch (SQLiteException ex)
            {
                // Handle the exception here
                MessageBox.Show("Error al acceder a la base de datos: " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// método que modifica la variable pkUsuario para almacenar la PrimaryKey del usuario en cuestión
        /// </summary>
        public static void GetPkUsuario()
        {
            //FormaInicioSesion inicioSesion = new FormaInicioSesion();
            string usuario = FormaInicioSesion.nombreUsuario;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
                {
                    conexion.Open();
                    SQLiteDataReader lector;
                    SQLiteCommand select = conexion.CreateCommand();
                    select.CommandText = "SELECT id FROM usuarios WHERE nombre_usuario = \"" + usuario + "\"";
                    lector = select.ExecuteReader();
                    int resultado = 0;
                    if (lector.Read())
                    {
                        resultado = lector.GetInt32(0);

                    }
                    lector.Dispose();
                    pkUsuario = resultado;
                }
            }
            
            catch (SQLiteException ex)
            {
                // Handle the exception here
                MessageBox.Show("Error al acceder a la base de datos: " + ex.Message);
            }
        }

    }
}
