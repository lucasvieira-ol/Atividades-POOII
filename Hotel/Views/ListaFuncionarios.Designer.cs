
namespace Hotel.Views
{
    partial class ListaFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FuncionarioNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospedeCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioDataAdmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFuncionariosFerias = new System.Windows.Forms.Button();
            this.btnTodosFuncionarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FuncionarioNome,
            this.hospedeCPF,
            this.funcionarioDataNascimento,
            this.funcionarioDataAdmissao,
            this.funcionarioStatus});
            this.dataGridView1.Location = new System.Drawing.Point(43, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(970, 479);
            this.dataGridView1.TabIndex = 0;
            // 
            // FuncionarioNome
            // 
            this.FuncionarioNome.HeaderText = "Funcionario";
            this.FuncionarioNome.Name = "FuncionarioNome";
            this.FuncionarioNome.ReadOnly = true;
            this.FuncionarioNome.Width = 280;
            // 
            // hospedeCPF
            // 
            this.hospedeCPF.HeaderText = "CPF";
            this.hospedeCPF.Name = "hospedeCPF";
            this.hospedeCPF.ReadOnly = true;
            this.hospedeCPF.Width = 200;
            // 
            // funcionarioDataNascimento
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.funcionarioDataNascimento.DefaultCellStyle = dataGridViewCellStyle1;
            this.funcionarioDataNascimento.HeaderText = "Data Nascimento";
            this.funcionarioDataNascimento.Name = "funcionarioDataNascimento";
            this.funcionarioDataNascimento.ReadOnly = true;
            this.funcionarioDataNascimento.Width = 150;
            // 
            // funcionarioDataAdmissao
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.funcionarioDataAdmissao.DefaultCellStyle = dataGridViewCellStyle2;
            this.funcionarioDataAdmissao.HeaderText = "Data Admissão";
            this.funcionarioDataAdmissao.Name = "funcionarioDataAdmissao";
            this.funcionarioDataAdmissao.ReadOnly = true;
            this.funcionarioDataAdmissao.Width = 150;
            // 
            // funcionarioStatus
            // 
            this.funcionarioStatus.HeaderText = "Status";
            this.funcionarioStatus.Name = "funcionarioStatus";
            this.funcionarioStatus.ReadOnly = true;
            this.funcionarioStatus.Width = 150;
            // 
            // btnFuncionariosFerias
            // 
            this.btnFuncionariosFerias.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionariosFerias.Location = new System.Drawing.Point(627, 15);
            this.btnFuncionariosFerias.Name = "btnFuncionariosFerias";
            this.btnFuncionariosFerias.Size = new System.Drawing.Size(210, 50);
            this.btnFuncionariosFerias.TabIndex = 1;
            this.btnFuncionariosFerias.Text = "Férias";
            this.btnFuncionariosFerias.UseVisualStyleBackColor = true;
            this.btnFuncionariosFerias.Click += new System.EventHandler(this.btnFuncionariosFerias_Click);
            // 
            // btnTodosFuncionarios
            // 
            this.btnTodosFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosFuncionarios.Location = new System.Drawing.Point(391, 15);
            this.btnTodosFuncionarios.Name = "btnTodosFuncionarios";
            this.btnTodosFuncionarios.Size = new System.Drawing.Size(210, 50);
            this.btnTodosFuncionarios.TabIndex = 2;
            this.btnTodosFuncionarios.Text = "Todos";
            this.btnTodosFuncionarios.UseVisualStyleBackColor = true;
            this.btnTodosFuncionarios.Click += new System.EventHandler(this.btnTodosFuncionarios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultar Funcionarios";
            // 
            // ListaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTodosFuncionarios);
            this.Controls.Add(this.btnFuncionariosFerias);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListaFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFuncionariosFerias;
        private System.Windows.Forms.Button btnTodosFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionarioNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospedeCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionarioDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionarioDataAdmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionarioStatus;
    }
}