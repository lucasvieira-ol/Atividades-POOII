using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data
{
   public class Hospede
    {
        public int id_reserva { get; set; }
        public string hospedeCPF { get; set; }
        public string hospedeNome { get; set; }
        public string quarto { get; set; }
        public DateTime dataCheckIn { get; set; }
        public DateTime dataCheckOut { get; set; }
    }
}
