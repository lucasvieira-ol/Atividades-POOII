
namespace Hotel.Views
{
    partial class Funcionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtAdmissao = new System.Windows.Forms.DateTimePicker();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.textBuscarCPF = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Admissão";
            // 
            // dtAdmissao
            // 
            this.dtAdmissao.Enabled = false;
            this.dtAdmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAdmissao.Location = new System.Drawing.Point(309, 336);
            this.dtAdmissao.Name = "dtAdmissao";
            this.dtAdmissao.Size = new System.Drawing.Size(200, 44);
            this.dtAdmissao.TabIndex = 4;
            // 
            // dtNascimento
            // 
            this.dtNascimento.Enabled = false;
            this.dtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNascimento.Location = new System.Drawing.Point(309, 276);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(200, 44);
            this.dtNascimento.TabIndex = 5;
            // 
            // textNome
            // 
            this.textNome.Enabled = false;
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(184, 143);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(454, 44);
            this.textNome.TabIndex = 6;
            // 
            // textCPF
            // 
            this.textCPF.Culture = new System.Globalization.CultureInfo("en-001");
            this.textCPF.Enabled = false;
            this.textCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCPF.Location = new System.Drawing.Point(185, 210);
            this.textCPF.Mask = "999.999.999-99";
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(244, 44);
            this.textCPF.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(663, 368);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(131, 45);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // textBuscarCPF
            // 
            this.textBuscarCPF.Culture = new System.Globalization.CultureInfo("en-001");
            this.textBuscarCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscarCPF.Location = new System.Drawing.Point(226, 23);
            this.textBuscarCPF.Mask = "999.999.999-99";
            this.textBuscarCPF.Name = "textBuscarCPF";
            this.textBuscarCPF.Size = new System.Drawing.Size(244, 44);
            this.textBuscarCPF.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Buscar CPF";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(507, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 45);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id";
            // 
            // textId
            // 
            this.textId.Enabled = false;
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId.Location = new System.Drawing.Point(184, 88);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(76, 44);
            this.textId.TabIndex = 13;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(644, 22);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(131, 45);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(302, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Enabled = false;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(426, 83);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(212, 45);
            this.comboBoxStatus.TabIndex = 16;
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 436);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBuscarCPF);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.dtAdmissao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtAdmissao;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.MaskedTextBox textCPF;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox textBuscarCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}