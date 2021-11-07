using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Views
{
    public partial class ListaHospedes : Form
    {
        public ListaHospedes()
        {
            InitializeComponent();
        }

        private void btnHospedeHoje_Click(object sender, EventArgs e)
        {
            try
            {

                var lstHospede = new Utils.FuncoesHospede().relatorioDiario();

                dataGridLoad(sender, e, lstHospede);
            }
            catch (Exception ex)
            {
                Utils.FuncoesError error = new Utils.FuncoesError();

                MessageBox.Show(error.HandleException(ex));
            }
        }

        private void btnHospedeMes_Click(object sender, EventArgs e)
        {
            try
            {
                var lstHospede = new Utils.FuncoesHospede().relatorioMensal();

                dataGridLoad(sender, e, lstHospede);

            }
            catch (Exception ex)
            {
                Utils.FuncoesError error = new Utils.FuncoesError();

                MessageBox.Show(error.HandleException(ex));
            }

        }

        private void dataGridLoad(object sender, EventArgs e, List<Data.Hospede> lstHospedes)
        {
            dataGridView1.Rows.Clear();

            foreach (var item in lstHospedes)
            {
                dataGridView1.Rows.Add
                    (
                    item.hospedeNome,
                    item.hospedeCPF,
                    item.quarto,
                    item.dataCheckIn,
                    item.dataCheckOut
                    );
            }
        }
    }
}
