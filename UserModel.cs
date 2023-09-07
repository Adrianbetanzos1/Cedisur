using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CedisurB
{
    public class UserModel
    {
        readonly AccesoUsuario AccesoUsuario = new AccesoUsuario();
        public bool LoginUser(string user, string contra)
        {
            return AccesoUsuario.Login(user, contra);
        }


    }
}
