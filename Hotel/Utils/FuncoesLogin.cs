using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Data;

namespace Hotel.Utils
{
    public class FuncoesLogin
    {
        public Usuarios LoginSistema(string login, string senha)
        {
            Usuarios resultUsuario = new Usuarios();

            using(Data.Server.db_hotelEntities context = new Data.Server.db_hotelEntities())
            {
                resultUsuario = context.tbLogin.Where(i => i.login == login && i.senha == senha && i.status).Select(i => new Usuarios()
                {
                    IdUsuario = i.id_usuario,
                    Login = i.login,
                    Status = i.status
                }).FirstOrDefault();
            }

            return resultUsuario;
        }
    }
}
