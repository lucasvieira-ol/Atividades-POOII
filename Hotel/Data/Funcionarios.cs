using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data
{
    public class Funcionarios
    {
        public int id_funcionario { get; set; }
        public string CPF { get; set; }
        public string nomeFuncionario { get; set; }
        public DateTime dataNascimento { get; set; }
        public DateTime dataAdmissao { get; set; }
        public string status { get; set; }
    }
}
