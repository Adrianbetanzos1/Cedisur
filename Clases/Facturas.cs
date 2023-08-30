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
    public class Facturas
    {
        public int ID_facturas { get; set; }
        public string FacturaN { get; set; }

        //Datos de provisiones

        public DateTime fechaFactura { get; set; }
        public int diasVencimiento { get; set; }
        public int importe { get; set; }
        public int abono { get; set; }
        public int saldoMXP { get; set; }

       

        //Datos Totales

        public int saldoPendiente { get; set; }
        public int provisionesAportadas { get; set; }


        public DataTable MostrarFactura()
        {

            using SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
            SqlDataAdapter da = new SqlDataAdapter("DT_MostrarFacturasActualizada", conexion);
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
            string consulta = "select * from Factura where FacturaN like '%" + args + "%'";
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);

            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
            
        }


        public static DataTable MostrarID(string args)
        {
            using SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
            string consulta = "select * from Factura where ID_factura like '%" + args + "%'";
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);

            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }








    }
}
