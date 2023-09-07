using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.ComponentModel.Design.Serialization;

namespace CedisurB
{
    public abstract class ConexionSQL
    {
        private readonly string conexionSql;
        
        public ConexionSQL()
        {
            conexionSql = "Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true";
        }


        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexionSql);
        }

       
    }
}
