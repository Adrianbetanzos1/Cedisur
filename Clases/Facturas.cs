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
        public string? FacturaN { get; set; }

        //Datos de provisiones

        public DateTime FechaFactura { get; set; }
        public int DiasVencimiento { get; set; }
        public int Importe { get; set; }
        public int Abono { get; set; }
        public int SaldoMXP { get; set; }

       

        //Datos Totales

        public int SaldoPendiente { get; set; }
        public int ProvisionesAportadas { get; set; }


        public static DataTable MostrarFactura()
        {

            using SqlConnection conexion = new ("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
            SqlDataAdapter da = new ("DT_MostrarFacturasActualizada", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        public static DataTable Mostrar(string args)
        {
            using SqlConnection conexion = new("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
            conexion.Open();
            string consulta = "select * from Factura where FacturaN like '%" + args + "%'";
            SqlDataAdapter da = new(consulta, conexion);

            DataTable dt = new();
            da.Fill(dt);
            conexion.Close();
            return dt;
            
        }


        public static DataTable MostrarIDProveedor(string args)
        {
            using SqlConnection conexion = new ("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true");
            string consulta = "select * from Factura where ID_proveedor like '%" + args + "%'";
            SqlDataAdapter da = new(consulta, conexion);

            DataTable dt = new();
            da.Fill(dt);
            conexion.Close();
            return dt;
        }








    }
}
