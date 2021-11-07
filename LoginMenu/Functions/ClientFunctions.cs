using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMenu.Functions
{
    public class ClientFunctions
    {
        public bool handleLogin(string login, string password)
        {
            db_atividade2Entities context = new db_atividade2Entities();

            var user = context.CLIENTE.Where(i => i.usuario == login && i.senha == password).FirstOrDefault();

            if (user != null)
            {
                user.dataAcesso = DateTime.Now;
                context.SaveChanges();

                return true;
            }
            else
                return false;

        }

        public string createUser(string name, string user, string email, string password)
        {
            db_atividade2Entities context = new db_atividade2Entities();

            var verifyDuplicate = context.CLIENTE.Where(i => i.email == email || i.usuario == user).FirstOrDefault();

            if (verifyDuplicate != null)
            {
                if (verifyDuplicate.email == email)
                    return "E-mail já cadastrado";

                if (verifyDuplicate.usuario == user)
                    return "Usuário já cadastrado";
            }

            CLIENTE createUser = new CLIENTE()
            {
                Nome = name,
                usuario = user,
                email = email,
                senha = password,
                dataCadastro = DateTime.Now,
                dataAcesso = null
            };

            context.CLIENTE.Add(createUser);

            context.SaveChanges();
            
            return "Usuário Cadastrado";
        }

    }
}
