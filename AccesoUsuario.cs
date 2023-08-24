using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Cedisur
{
    public class AccesoUsuario : ConexionSQL
    {
        public bool Login(string user, string contra)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Usuarios where NombreUsuario =@user and Contraseña=@contra ";
                    comando.Parameters.AddWithValue("@user", user);
                    comando.Parameters.AddWithValue("@contra", contra);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
