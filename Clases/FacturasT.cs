using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedisur.Clases
{
    internal class FacturasT
    {
        public int ID_factura { get; set; }
        public int FacturaN { get; set; }
        public int ImportePagoMXP { get; set; }
        public int ImportePagoUSD { get; set; }
        public DateTime FechaPago { get; set; }
        public string? SPEI { get; set; }
        public string? NumCuenta { get; set; }
        public int NumContrato { get; set; }


        


        public DataTable MostrarFacturas()
        {

            using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"))
            {
                SqlDataAdapter da = new SqlDataAdapter("DT_MostrarFacturas", conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new();
                da.Fill(dt);

                return dt;
            }
        }

        public static DataTable MostrarFactura(string args)
        {
            using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"))
            {
                string consulta = "select * from Facturas where FacturaN like '%" + args + "%'";
                SqlDataAdapter da = new(consulta, conexion);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
}
