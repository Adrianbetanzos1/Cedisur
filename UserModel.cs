using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cedisur
{
    public class UserModel
    {
        readonly AccesoUsuario AccesoUsuario = new ();
        public bool LoginUser(string user, string contra)
        {
            return AccesoUsuario.Login(user, contra);
        }


    }
}
