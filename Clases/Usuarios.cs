using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedisur.Clases
{
    public class Usuarios
    {
        public int ID_usuario { get; set; }
        public string? NombreCompleto { get; set; }
        public string? NombreUsuario { get; set; }
        public  string? Contraseña { get; set; }
        public string?   Nivel_seguridad { get; set; }

        
        public static DataTable MostrarUsuario()
        {

            using SqlConnection conexion = new("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
            SqlDataAdapter da = new("DT_MostrarUsuarios", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        public DataTable MostrarUsuariosNombre(string args)
        {

            using SqlConnection conexion = new("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
            string consulta = "select * from Usuarios where NombreCompleto like '%" + args + "%'";
            SqlDataAdapter da = new(consulta, conexion);

            DataTable dt = new();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

    }
}
