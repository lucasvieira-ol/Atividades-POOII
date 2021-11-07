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
    public partial class Hospede : Form
    {
        public Hospede()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textCPF.Text) && textCPF.Text.Length == 14)
            {
                try
                {
                    Data.Hospede novoHospede = new Data.Hospede()
                    { 
                       hospedeNome = textNome.Text,
                       hospedeCPF = textCPF.Text,
                       dataCheckIn = dtCheckIn.Value,
                       dataCheckOut = dtCheckOut.Value,
                       quarto = textQuarto.Text
                    };

                    Utils.FuncoesHospede novaReserva = new Utils.FuncoesHospede();

                    novaReserva.criarHospede(novoHospede);
                    MessageBox.Show("Reserva crada com êxito");
                    limparCampos();

                }
                catch (Exception ex)
                {
                    Utils.FuncoesError lidarErro = new Utils.FuncoesError();

                    MessageBox.Show(lidarErro.HandleException(ex));
                }
            }
            else
            {
                MessageBox.Show("CPF inserido inválido");
            }
        }

        private void limparCampos()
        {
            textNome.Text = null;
            textCPF.Text = null;
            textQuarto.Text = null;
            dtCheckIn.Value = DateTime.Now;
            dtCheckOut.Value = DateTime.Now;
        }

        private void Hospede_Load(object sender, EventArgs e)
        {
            dtCheckIn.Format = DateTimePickerFormat.Custom;
            dtCheckIn.CustomFormat = "dd/MM/yyyy";

            dtCheckOut.Format = DateTimePickerFormat.Custom;
            dtCheckOut.CustomFormat = "dd/MM/yyyy";

        }

    }
}
