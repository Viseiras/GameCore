using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    //clase estática hecha para facilitar la utilización de métodos de SQLite en las demás formas del proyecto
    internal static class MetodosSqlite
    {
        //metodo que devuelve true o false en función del parámetro que se le pase, perteneciente a un nombre de usuario en la BD
        public static bool CompruebaUsuario(string nombre)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(@"Data Source=.\..\..\BaseDeDatos\gamecore.db"))
            {
                conexion.Open();
                //abrimos un dataReader para leer datos de la BD
                SQLiteDataReader lector;
                //creamos la sentencia o comando, llamado select
                SQLiteCommand select = conexion.CreateCommand();
                //le asignamos la consulta
                select.CommandText = "SELECT * FROM usuarios WHERE nombre_usuario = \"" + nombre + "\"";
                lector = select.ExecuteReader();

                //si el lector detecta un usuario devuelve true
                if(lector.Read())
                { return true; }
                //si no devuelvo false
                return false;
            }
        }
        public static string CompruebaContraseña(string usuario)
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
                return resultado;
            }
        }

    }
}
