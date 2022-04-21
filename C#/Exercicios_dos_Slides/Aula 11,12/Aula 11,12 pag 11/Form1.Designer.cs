namespace Aula_11_12_pag_11
{
    partial class Form1
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
            this.btn_criarVetor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tamanho = new System.Windows.Forms.TextBox();
            this.lb_geradosUmaVez = new System.Windows.Forms.ListBox();
            this.txt_valorMinimo = new System.Windows.Forms.TextBox();
            this.txt_valorMaximo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maiorValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mediaPares = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_maisGerado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_executar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_criarVetor
            // 
            this.btn_criarVetor.Location = new System.Drawing.Point(163, 128);
            this.btn_criarVetor.Name = "btn_criarVetor";
            this.btn_criarVetor.Size = new System.Drawing.Size(100, 23);
            this.btn_criarVetor.TabIndex = 0;
            this.btn_criarVetor.Text = "Criar Vetor";
            this.btn_criarVetor.UseVisualStyleBackColor = true;
            this.btn_criarVetor.Click += new System.EventHandler(this.btn_criarVetor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tamanho";
            // 
            // txt_tamanho
            // 
            this.txt_tamanho.Location = new System.Drawing.Point(163, 50);
            this.txt_tamanho.Name = "txt_tamanho";
            this.txt_tamanho.Size = new System.Drawing.Size(100, 20);
            this.txt_tamanho.TabIndex = 2;
            // 
            // lb_geradosUmaVez
            // 
            this.lb_geradosUmaVez.FormattingEnabled = true;
            this.lb_geradosUmaVez.Location = new System.Drawing.Point(253, 237);
            this.lb_geradosUmaVez.Name = "lb_geradosUmaVez";
            this.lb_geradosUmaVez.Size = new System.Drawing.Size(120, 95);
            this.lb_geradosUmaVez.TabIndex = 3;
            // 
            // txt_valorMinimo
            // 
            this.txt_valorMinimo.Location = new System.Drawing.Point(163, 76);
            this.txt_valorMinimo.Name = "txt_valorMinimo";
            this.txt_valorMinimo.Size = new System.Drawing.Size(100, 20);
            this.txt_valorMinimo.TabIndex = 4;
            // 
            // txt_valorMaximo
            // 
            this.txt_valorMaximo.Location = new System.Drawing.Point(163, 102);
            this.txt_valorMaximo.Name = "txt_valorMaximo";
            this.txt_valorMaximo.Size = new System.Drawing.Size(100, 20);
            this.txt_valorMaximo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor minimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor maximo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dados do  vetor";
            // 
            // txt_maiorValor
            // 
            this.txt_maiorValor.Location = new System.Drawing.Point(110, 237);
            this.txt_maiorValor.Name = "txt_maiorValor";
            this.txt_maiorValor.ReadOnly = true;
            this.txt_maiorValor.Size = new System.Drawing.Size(97, 20);
            this.txt_maiorValor.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Maior Valor";
            // 
            // txt_mediaPares
            // 
            this.txt_mediaPares.Location = new System.Drawing.Point(110, 276);
            this.txt_mediaPares.Name = "txt_mediaPares";
            this.txt_mediaPares.ReadOnly = true;
            this.txt_mediaPares.Size = new System.Drawing.Size(97, 20);
            this.txt_mediaPares.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Media pares";
            // 
            // txt_maisGerado
            // 
            this.txt_maisGerado.Location = new System.Drawing.Point(136, 317);
            this.txt_maisGerado.Name = "txt_maisGerado";
            this.txt_maisGerado.ReadOnly = true;
            this.txt_maisGerado.Size = new System.Drawing.Size(71, 20);
            this.txt_maisGerado.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor mais gerado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valores gerados uma vez";
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(154, 368);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(100, 28);
            this.btn_executar.TabIndex = 16;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(0, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(400, 14);
            this.label9.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 408);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_maisGerado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_mediaPares);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_maiorValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_valorMaximo);
            this.Controls.Add(this.txt_valorMinimo);
            this.Controls.Add(this.lb_geradosUmaVez);
            this.Controls.Add(this.txt_tamanho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_criarVetor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_criarVetor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tamanho;
        private System.Windows.Forms.ListBox lb_geradosUmaVez;
        private System.Windows.Forms.TextBox txt_valorMinimo;
        private System.Windows.Forms.TextBox txt_valorMaximo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maiorValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mediaPares;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_maisGerado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Label label9;
    }
}

