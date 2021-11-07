﻿
namespace Hotel.Views
{
    partial class ListaHospedes
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
            this.btnHospedeMes = new System.Windows.Forms.Button();
            this.btnHospedeHoje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hospedeNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospedeCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospedeQuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospedeDataCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospedeDataCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hospedeNome,
            this.hospedeCPF,
            this.hospedeQuarto,
            this.hospedeDataCheckIn,
            this.hospedeDataCheckOut});
            this.dataGridView1.Location = new System.Drawing.Point(43, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(970, 479);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnHospedeMes
            // 
            this.btnHospedeMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospedeMes.Location = new System.Drawing.Point(616, 15);
            this.btnHospedeMes.Name = "btnHospedeMes";
            this.btnHospedeMes.Size = new System.Drawing.Size(210, 50);
            this.btnHospedeMes.TabIndex = 1;
            this.btnHospedeMes.Text = "Mês Atual";
            this.btnHospedeMes.UseVisualStyleBackColor = true;
            this.btnHospedeMes.Click += new System.EventHandler(this.btnHospedeMes_Click);
            // 
            // btnHospedeHoje
            // 
            this.btnHospedeHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospedeHoje.Location = new System.Drawing.Point(353, 16);
            this.btnHospedeHoje.Name = "btnHospedeHoje";
            this.btnHospedeHoje.Size = new System.Drawing.Size(210, 50);
            this.btnHospedeHoje.TabIndex = 2;
            this.btnHospedeHoje.Text = "Hoje";
            this.btnHospedeHoje.UseVisualStyleBackColor = true;
            this.btnHospedeHoje.Click += new System.EventHandler(this.btnHospedeHoje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultar Hospedes";
            // 
            // hospedeNome
            // 
            this.hospedeNome.HeaderText = "Hospede";
            this.hospedeNome.Name = "hospedeNome";
            this.hospedeNome.ReadOnly = true;
            this.hospedeNome.Width = 280;
            // 
            // hospedeCPF
            // 
            this.hospedeCPF.HeaderText = "CPF";
            this.hospedeCPF.Name = "hospedeCPF";
            this.hospedeCPF.ReadOnly = true;
            this.hospedeCPF.Width = 200;
            // 
            // hospedeQuarto
            // 
            this.hospedeQuarto.HeaderText = "Quarto";
            this.hospedeQuarto.Name = "hospedeQuarto";
            this.hospedeQuarto.ReadOnly = true;
            this.hospedeQuarto.Width = 150;
            // 
            // hospedeDataCheckIn
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.hospedeDataCheckIn.DefaultCellStyle = dataGridViewCellStyle1;
            this.hospedeDataCheckIn.HeaderText = "Data CheckIn";
            this.hospedeDataCheckIn.Name = "hospedeDataCheckIn";
            this.hospedeDataCheckIn.ReadOnly = true;
            this.hospedeDataCheckIn.Width = 150;
            // 
            // hospedeDataCheckOut
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.hospedeDataCheckOut.DefaultCellStyle = dataGridViewCellStyle2;
            this.hospedeDataCheckOut.HeaderText = "Data CheckOut";
            this.hospedeDataCheckOut.Name = "hospedeDataCheckOut";
            this.hospedeDataCheckOut.ReadOnly = true;
            this.hospedeDataCheckOut.Width = 150;
            // 
            // ListaHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHospedeHoje);
            this.Controls.Add(this.btnHospedeMes);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaHospedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListaHospedes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHospedeMes;
        private System.Windows.Forms.Button btnHospedeHoje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospedeNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospedeCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospedeQuarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospedeDataCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospedeDataCheckOut;
    }
}