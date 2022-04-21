namespace Aula_11_12_pag_24__matriz_transposta_
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
            this.btn_executar = new System.Windows.Forms.Button();
            this.lb_matriz = new System.Windows.Forms.ListBox();
            this.lb_matrizTransposta = new System.Windows.Forms.ListBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_criarMatriz = new System.Windows.Forms.Button();
            this.txt_linha = new System.Windows.Forms.TextBox();
            this.txt_coluna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_lerValor = new System.Windows.Forms.Button();
            this.lbl_posicao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_executar
            // 
            this.btn_executar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_executar.Location = new System.Drawing.Point(123, 310);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(95, 37);
            this.btn_executar.TabIndex = 0;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // lb_matriz
            // 
            this.lb_matriz.FormattingEnabled = true;
            this.lb_matriz.Location = new System.Drawing.Point(24, 155);
            this.lb_matriz.Name = "lb_matriz";
            this.lb_matriz.Size = new System.Drawing.Size(137, 134);
            this.lb_matriz.TabIndex = 1;
            // 
            // lb_matrizTransposta
            // 
            this.lb_matrizTransposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matrizTransposta.FormattingEnabled = true;
            this.lb_matrizTransposta.ItemHeight = 24;
            this.lb_matrizTransposta.Location = new System.Drawing.Point(183, 155);
            this.lb_matrizTransposta.Name = "lb_matrizTransposta";
            this.lb_matrizTransposta.Size = new System.Drawing.Size(148, 124);
            this.lb_matrizTransposta.TabIndex = 2;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(233, 73);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(79, 20);
            this.txt_valor.TabIndex = 3;
            // 
            // btn_criarMatriz
            // 
            this.btn_criarMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criarMatriz.Location = new System.Drawing.Point(24, 100);
            this.btn_criarMatriz.Name = "btn_criarMatriz";
            this.btn_criarMatriz.Size = new System.Drawing.Size(112, 24);
            this.btn_criarMatriz.TabIndex = 4;
            this.btn_criarMatriz.Text = "Criar Matriz";
            this.btn_criarMatriz.UseVisualStyleBackColor = true;
            this.btn_criarMatriz.Click += new System.EventHandler(this.btn_criarMatriz_Click);
            // 
            // txt_linha
            // 
            this.txt_linha.Location = new System.Drawing.Point(24, 73);
            this.txt_linha.Name = "txt_linha";
            this.txt_linha.Size = new System.Drawing.Size(53, 20);
            this.txt_linha.TabIndex = 5;
            // 
            // txt_coluna
            // 
            this.txt_coluna.Location = new System.Drawing.Point(83, 73);
            this.txt_coluna.Name = "txt_coluna";
            this.txt_coluna.Size = new System.Drawing.Size(53, 20);
            this.txt_coluna.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Linha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Coluna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor";
            // 
            // btn_lerValor
            // 
            this.btn_lerValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lerValor.Location = new System.Drawing.Point(233, 99);
            this.btn_lerValor.Name = "btn_lerValor";
            this.btn_lerValor.Size = new System.Drawing.Size(79, 23);
            this.btn_lerValor.TabIndex = 10;
            this.btn_lerValor.Text = "Ler Valor";
            this.btn_lerValor.UseVisualStyleBackColor = true;
            this.btn_lerValor.Click += new System.EventHandler(this.btn_lerValor_Click);
            // 
            // lbl_posicao
            // 
            this.lbl_posicao.AutoSize = true;
            this.lbl_posicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_posicao.Location = new System.Drawing.Point(146, 9);
            this.lbl_posicao.Name = "lbl_posicao";
            this.lbl_posicao.Size = new System.Drawing.Size(82, 24);
            this.lbl_posicao.TabIndex = 11;
            this.lbl_posicao.Text = "Posição:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 368);
            this.Controls.Add(this.lbl_posicao);
            this.Controls.Add(this.btn_lerValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_coluna);
            this.Controls.Add(this.txt_linha);
            this.Controls.Add(this.btn_criarMatriz);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lb_matrizTransposta);
            this.Controls.Add(this.lb_matriz);
            this.Controls.Add(this.btn_executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.ListBox lb_matriz;
        private System.Windows.Forms.ListBox lb_matrizTransposta;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button btn_criarMatriz;
        private System.Windows.Forms.TextBox txt_linha;
        private System.Windows.Forms.TextBox txt_coluna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_lerValor;
        private System.Windows.Forms.Label lbl_posicao;
    }
}

