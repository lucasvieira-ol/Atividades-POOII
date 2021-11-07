
namespace Hotel.Views
{
    partial class Hospede
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
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.dtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textQuarto = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCPF
            // 
            this.textCPF.Culture = new System.Globalization.CultureInfo("en-001");
            this.textCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCPF.Location = new System.Drawing.Point(181, 62);
            this.textCPF.Mask = "999.999.999-99";
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(244, 44);
            this.textCPF.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "CPF";
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(181, 128);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(454, 44);
            this.textNome.TabIndex = 18;
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckIn.Location = new System.Drawing.Point(306, 251);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(200, 44);
            this.dtCheckIn.TabIndex = 17;
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckOut.Location = new System.Drawing.Point(306, 311);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(200, 44);
            this.dtCheckOut.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data CheckOut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data CheckIn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // textQuarto
            // 
            this.textQuarto.Culture = new System.Globalization.CultureInfo("en-001");
            this.textQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuarto.Location = new System.Drawing.Point(181, 191);
            this.textQuarto.Mask = "999";
            this.textQuarto.Name = "textQuarto";
            this.textQuarto.Size = new System.Drawing.Size(63, 44);
            this.textQuarto.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "Quarto";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(593, 376);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(131, 45);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Hospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textQuarto);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hospede";
            this.Text = "Hospede";
            this.Load += new System.EventHandler(this.Hospede_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.DateTimePicker dtCheckIn;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textQuarto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
    }
}