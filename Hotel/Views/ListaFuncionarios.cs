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
    public partial class ListaFuncionarios : Form
    {
        public ListaFuncionarios()
        {
            InitializeComponent();
        }

        private void btnTodosFuncionarios_Click(object sender, EventArgs e)
        {
            try
            {
                var lstFuncionarios = new Utils.FuncoesFuncionarios().relatorioTodos();

                dataGridLoad(sender, e, lstFuncionarios);
            }
            catch (Exception ex)
            {
                Utils.FuncoesError error = new Utils.FuncoesError();

                MessageBox.Show(error.HandleException(ex));
            }
        }

        private void btnFuncionariosFerias_Click(object sender, EventArgs e)
        {
            try
            {
                var lstFuncionarios = new Utils.FuncoesFuncionarios().relatorioFerias();

                dataGridLoad(sender, e, lstFuncionarios);

            }
            catch (Exception ex)
            {
                Utils.FuncoesError error = new Utils.FuncoesError();

                MessageBox.Show(error.HandleException(ex));
            }

        }

        private void dataGridLoad(object sender, EventArgs e, List<Data.Funcionarios> lstFuncionarios)
        {
            dataGridView1.Rows.Clear();

            foreach (var item in lstFuncionarios)
            {
                dataGridView1.Rows.Add
                    (
                    item.nomeFuncionario,
                    item.CPF,
                    item.dataNascimento,
                    item.dataAdmissao,
                    item.status
                    );
            }
        }

    }
}
