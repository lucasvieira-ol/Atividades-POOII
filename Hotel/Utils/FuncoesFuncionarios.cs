using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Data;

namespace Hotel.Utils
{
    public class FuncoesFuncionarios
    {
        public Funcionarios getFuncionario(string CPF)
        {
            Funcionarios resultFuncionario = new Funcionarios();
            using (Data.Server.db_hotelEntities context = new Data.Server.db_hotelEntities())
            {
                resultFuncionario = context.tbFuncionario.Where(i => i.CPF == CPF).Select(i => new Funcionarios()
                {
                    id_funcionario = i.id_funcionario,
                    CPF = i.CPF,
                    nomeFuncionario = i.Nome,
                    dataAdmissao = i.DataContratacao,
                    dataNascimento = i.DataNascimento,
                    status = i.Status
                }).FirstOrDefault();
            }
            return resultFuncionario;
        }
        public void updateFuncionario(Funcionarios alterarFuncionario)
        {
            using (Data.Server.db_hotelEntities context = new Data.Server.db_hotelEntities())
            {
                var resultFuncionario = context.tbFuncionario.Where(i => i.id_funcionario == alterarFuncionario.id_funcionario).FirstOrDefault();

                resultFuncionario.id_funcionario = alterarFuncionario.id_funcionario;
                resultFuncionario.CPF = alterarFuncionario.CPF;
                resultFuncionario.Nome = alterarFuncionario.nomeFuncionario;
                resultFuncionario.DataContratacao = alterarFuncionario.dataAdmissao;
                resultFuncionario.DataNascimento = alterarFuncionario.dataNascimento;
                resultFuncionario.Status = alterarFuncionario.status;

                context.SaveChanges();
            }
        }
        public void criarFuncionario(Funcionarios dadosFuncionario)
        {
            using (Data.Server.db_hotelEntities context = new Data.Server.db_hotelEntities())
            {
                Data.Server.tbFuncionario novoFuncionario = new Data.Server.tbFuncionario()
                {
                    id_funcionario = dadosFuncionario.id_funcionario,
                    CPF = dadosFuncionario.CPF,
                    Nome = dadosFuncionario.nomeFuncionario,
                    DataContratacao = dadosFuncionario.dataAdmissao,
                    DataNascimento = dadosFuncionario.dataNascimento,
                    Status = dadosFuncionario.status
                };
                context.tbFuncionario.Add(novoFuncionario);
                context.SaveChanges();
            }
        }

        public List<Funcionarios> relatorioTodos()
        {
            List<Funcionarios> lstFuncionarios = new List<Funcionarios>();

            using (Data.Server.db_hotelEntities context = new Data.Server.db_hotelEntities())
            {
                var result = context.tbFuncionario.ToList();

                foreach (var item in result)
                {
                    Funcionarios addFuncionario = new Funcionarios()
                    {
                        nomeFuncionario = item.Nome,
                        CPF = item.CPF,
                        dataAdmissao = item.DataContratacao,
                        dataNascimento = item.DataNascimento,
                        status = verificarStatus(item.Status),
                        id_funcionario = item.id_funcionario
                    };

                    lstFuncionarios.Add(addFuncionario);
                }
            }

            return lstFuncionarios;
        }
        public List<Funcionarios> relatorioFerias()
        {
            List<Funcionarios> lstFuncionarios = new List<Funcionarios>();

            using (Data.Server.db_hotelEntities context = new Data.Server.db_hotelEntities())
            {
                var result = context.tbFuncionario.Where(i => i.Status == "F").ToList();

                foreach (var item in result)
                {
                    Funcionarios addFuncionario = new Funcionarios()
                    {
                        nomeFuncionario = item.Nome,
                        CPF = item.CPF,
                        dataAdmissao = item.DataContratacao,
                        dataNascimento = item.DataNascimento,
                        status = verificarStatus(item.Status),
                        id_funcionario = item.id_funcionario
                    };

                    lstFuncionarios.Add(addFuncionario);
                }
            }

            return lstFuncionarios;
        }

        private string verificarStatus(string sigla)
        {

            switch (sigla)
            {
                case "A":
                    return "Ativo";
                    break;

                case "F":
                    return "Férias";
                    break;

                case "S":
                    return  "Suspenso";
                    break;

                case "V":
                    return  "Em Viagem";
                    break;

                case "D":
                    return "Desligado";
                    break;

                default:
                    return "";
                    break;
            }
        }
    }
}
