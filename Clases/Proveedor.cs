using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedisur.Clases
{
    public class Proveedor
    {
        public int ID_proveedor { get; set; }
        public string? RfcProveedor { get; set; }
        public string? NombreProveedor { get; set; }
        public DateTime FechaRegistro { get; set; }

        public string? TipoDeProveedor { get; set; }
        public string? TipoDePago { get; set; }


        public static DataTable MostrarProveedores()
        {

            using SqlConnection conexion = new("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
            SqlDataAdapter da = new ("DT_MostrarProveedor", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }


        public static DataTable MostrarNombreProveedores(string args)
        {

            using SqlConnection conexion = new ("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
            string consulta = "select * from Proveedor where nombreProveedor like '%" + args + "%'";
            SqlDataAdapter da = new (consulta, conexion);

            DataTable dt = new();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }


        public static DataTable MostrarRFCProveedores(string args)
        {

            using SqlConnection conexion = new("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
            string consulta = "select * from Proveedor where RfcProveedor like '%" + args + "%'";
            SqlDataAdapter da = new(consulta, conexion);

            DataTable dt = new();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

    }
}
