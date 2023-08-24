using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cedisur.Clases
{
    public class Proveedor
    {
        public int ID_proveedor { get; set; }
        public string nombreProveedor { get; set; }

        //Datos de provisiones
        public int FacturaN { get; set; }
        public DateTime fechaFactura { get; set; }
        public int diasVencimiento { get; set; }
        public int importe { get; set; }
        public int abono { get; set; }
        public int saldoMXP { get; set; }

       

        //Datos Totales

        public int saldoPendiente { get; set; }
        public int provisionesAportadas { get; set; }


        public DataTable MostrarProveedores()
        {

            using SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
            SqlDataAdapter da = new SqlDataAdapter("DT_MostrarProveedores", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        public static DataTable Mostrar(string args)
        {
            using SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
            conexion.Open();
            string consulta = "select * from Proveedores where nombreProveedor like '%" + args + "%'";
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);

            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
            
        }


        public static DataTable MostrarID(string args)
        {
            using SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
            string consulta = "select * from Proveedores where ID_proveedor like '%" + args + "%'";
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);

            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }








    }
}
