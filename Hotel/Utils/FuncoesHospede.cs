using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Data;

namespace Hotel.Utils
{
    public class FuncoesHospede
    {
        public void criarHospede(Hospede hospede)
        {
            using (Data.Server.db_hotelEntities context = new Data.Server.db_hotelEntities())
            {
                Data.Server.tbHospede reserva = new Data.Server.tbHospede()
                {
                    CPF = hospede.hospedeCPF,
                    Nome = hospede.hospedeNome,
                    DataCheckIn = hospede.dataCheckIn,
                    DataCheckOut = hospede.dataCheckOut,
                    Quarto = hospede.quarto
                };

                context.tbHospede.Add(reserva);
                context.SaveChanges();
            }
        }

        public List<Hospede> relatorioMensal()
        {
            List<Hospede> lstHospedes = new List<Hospede>();

            using (Data.Server.db_hotelEntities context = new Data.Server.db_hotelEntities())
            {
                var Month = DateTime.Now.Month;
                var year = DateTime.Now.Year;

                var result = context.tbHospede.Where(i => i.DataCheckOut.Month == Month && i.DataCheckOut.Year == year).ToList();

                foreach (var item in result)
                {
                    Hospede addHospede = new Hospede()
                    {
                        dataCheckIn = item.DataCheckIn,
                        dataCheckOut = item.DataCheckOut,
                        hospedeCPF = item.CPF,
                        hospedeNome = item.Nome,
                        quarto = item.Quarto,
                        id_reserva = item.id_reserva
                    };

                    lstHospedes.Add(addHospede);
                }
            }

            return lstHospedes;
        }
        public List<Hospede> relatorioDiario()
        {
            List<Hospede> lstHospedes = new List<Hospede>();

            using (Data.Server.db_hotelEntities context = new Data.Server.db_hotelEntities())
            {
                var result = context.tbHospede.Where(i => i.DataCheckOut >= DateTime.Now).ToList();

                foreach (var item in result)
                {
                    Hospede addHospede = new Hospede()
                    {
                        dataCheckIn = item.DataCheckIn,
                        dataCheckOut = item.DataCheckOut,
                        hospedeCPF = item.CPF,
                        hospedeNome = item.Nome,
                        quarto = item.Quarto,
                        id_reserva = item.id_reserva
                    };

                    lstHospedes.Add(addHospede);
                }
            }

            return lstHospedes;
        }

    }
}

