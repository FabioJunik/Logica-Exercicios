namespace Aula_11_12_pag_21
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
            this.txt_linha = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_linha = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_coluna = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_coluna = new System.Windows.Forms.TextBox();
            this.btn_lerMatriz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_SomaLinha = new System.Windows.Forms.ListBox();
            this.lb_SomaColuna = new System.Windows.Forms.ListBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(335, 387);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(90, 30);
            this.btn_executar.TabIndex = 1;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // txt_linha
            // 
            this.txt_linha.Location = new System.Drawing.Point(61, 98);
            this.txt_linha.Name = "txt_linha";
            this.txt_linha.Size = new System.Drawing.Size(49, 20);
            this.txt_linha.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(241, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(367, 261);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Linha";
            // 
            // lb_linha
            // 
            this.lb_linha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_linha.FormattingEnabled = true;
            this.lb_linha.ItemHeight = 20;
            this.lb_linha.Location = new System.Drawing.Point(12, 284);
            this.lb_linha.Name = "lb_linha";
            this.lb_linha.Size = new System.Drawing.Size(80, 124);
            this.lb_linha.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mostrar Linha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mostrar Coluna";
            // 
            // lb_coluna
            // 
            this.lb_coluna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_coluna.FormattingEnabled = true;
            this.lb_coluna.ItemHeight = 20;
            this.lb_coluna.Location = new System.Drawing.Point(119, 284);
            this.lb_coluna.Name = "lb_coluna";
            this.lb_coluna.Size = new System.Drawing.Size(80, 124);
            this.lb_coluna.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Coluna";
            // 
            // txt_coluna
            // 
            this.txt_coluna.Location = new System.Drawing.Point(156, 98);
            this.txt_coluna.Name = "txt_coluna";
            this.txt_coluna.Size = new System.Drawing.Size(49, 20);
            this.txt_coluna.TabIndex = 10;
            // 
            // btn_lerMatriz
            // 
            this.btn_lerMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lerMatriz.Location = new System.Drawing.Point(26, 27);
            this.btn_lerMatriz.Name = "btn_lerMatriz";
            this.btn_lerMatriz.Size = new System.Drawing.Size(178, 34);
            this.btn_lerMatriz.TabIndex = 12;
            this.btn_lerMatriz.Text = "Ler Matriz";
            this.btn_lerMatriz.UseVisualStyleBackColor = true;
            this.btn_lerMatriz.Click += new System.EventHandler(this.btn_lerMatriz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Soma Coluna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Soma Linha";
            // 
            // lb_SomaLinha
            // 
            this.lb_SomaLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SomaLinha.FormattingEnabled = true;
            this.lb_SomaLinha.ItemHeight = 20;
            this.lb_SomaLinha.Location = new System.Drawing.Point(49, 159);
            this.lb_SomaLinha.Name = "lb_SomaLinha";
            this.lb_SomaLinha.Size = new System.Drawing.Size(128, 24);
            this.lb_SomaLinha.TabIndex = 17;
            // 
            // lb_SomaColuna
            // 
            this.lb_SomaColuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SomaColuna.FormattingEnabled = true;
            this.lb_SomaColuna.ItemHeight = 20;
            this.lb_SomaColuna.Location = new System.Drawing.Point(49, 214);
            this.lb_SomaColuna.Name = "lb_SomaColuna";
            this.lb_SomaColuna.Size = new System.Drawing.Size(128, 24);
            this.lb_SomaColuna.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "0";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "1";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "2";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "3";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "4";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 438);
            this.Controls.Add(this.lb_SomaColuna);
            this.Controls.Add(this.lb_SomaLinha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_lerMatriz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_coluna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_coluna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_linha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_linha);
            this.Controls.Add(this.btn_executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.TextBox txt_linha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_linha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_coluna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_coluna;
        private System.Windows.Forms.Button btn_lerMatriz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lb_SomaLinha;
        private System.Windows.Forms.ListBox lb_SomaColuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

