using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Utils
{
    public class FuncoesError
    {
        public virtual string HandleException(Exception exception)
        {

            string alerta;

            if (exception is DbUpdateException dbUpdateEx)
            {
                if (dbUpdateEx.InnerException != null
                        && dbUpdateEx.InnerException.InnerException != null)
                {
                    if (dbUpdateEx.InnerException.InnerException is SqlException sqlException)
                    {
                        switch (sqlException.Number)
                        {
                            case 2627:
                                return alerta = "Não é possível duplicar o cadastro";
                                break;// Unique constraint error
                           // case 547:   // Constraint check violation
                            //case 2601:  // Duplicated key row error
                                        // Constraint violation exception
                                        // A custom exception of yours for concurrency issues
                            default:
                                return alerta = "erro inesperado";
                                break;
                        }
                    }
                    else
                    {
                        return alerta = "Erro inesperado";
                    }
                }
                else
                {
                    return alerta = "Erro inesperado";
                }
            }
            else
            {
                return alerta = "Erro inesperado";

            }

        }
    }
}
