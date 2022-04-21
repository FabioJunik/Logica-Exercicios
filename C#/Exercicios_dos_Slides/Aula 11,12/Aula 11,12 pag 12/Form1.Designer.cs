namespace Aula_11_12_pag_12
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
            this.components = new System.ComponentModel.Container();
            this.btn_lerNome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.ListBox();
            this.btn_ordenar = new System.Windows.Forms.Button();
            this.txt_qtdNome = new System.Windows.Forms.TextBox();
            this.Quantidade = new System.Windows.Forms.Label();
            this.btn_lerQauntidade = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_lerNome
            // 
            this.btn_lerNome.Location = new System.Drawing.Point(211, 71);
            this.btn_lerNome.Name = "btn_lerNome";
            this.btn_lerNome.Size = new System.Drawing.Size(54, 20);
            this.btn_lerNome.TabIndex = 0;
            this.btn_lerNome.Text = "Ler";
            this.btn_lerNome.UseVisualStyleBackColor = true;
            this.btn_lerNome.Click += new System.EventHandler(this.btn_lerNome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(43, 72);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(162, 20);
            this.txt_nome.TabIndex = 2;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // lb_nome
            // 
            this.lb_nome.FormattingEnabled = true;
            this.lb_nome.Location = new System.Drawing.Point(52, 111);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(153, 121);
            this.lb_nome.TabIndex = 3;
            this.lb_nome.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_ordenar
            // 
            this.btn_ordenar.Location = new System.Drawing.Point(52, 238);
            this.btn_ordenar.Name = "btn_ordenar";
            this.btn_ordenar.Size = new System.Drawing.Size(153, 23);
            this.btn_ordenar.TabIndex = 4;
            this.btn_ordenar.Text = "Ordenar";
            this.btn_ordenar.UseVisualStyleBackColor = true;
            this.btn_ordenar.Click += new System.EventHandler(this.btn_ordenar_Click);
            // 
            // txt_qtdNome
            // 
            this.txt_qtdNome.Location = new System.Drawing.Point(78, 35);
            this.txt_qtdNome.Name = "txt_qtdNome";
            this.txt_qtdNome.Size = new System.Drawing.Size(65, 20);
            this.txt_qtdNome.TabIndex = 7;
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(10, 38);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(62, 13);
            this.Quantidade.TabIndex = 6;
            this.Quantidade.Text = "Quantidade";
            // 
            // btn_lerQauntidade
            // 
            this.btn_lerQauntidade.Location = new System.Drawing.Point(151, 35);
            this.btn_lerQauntidade.Name = "btn_lerQauntidade";
            this.btn_lerQauntidade.Size = new System.Drawing.Size(54, 20);
            this.btn_lerQauntidade.TabIndex = 5;
            this.btn_lerQauntidade.Text = "Ler";
            this.btn_lerQauntidade.UseVisualStyleBackColor = true;
            this.btn_lerQauntidade.Click += new System.EventHandler(this.btn_lerQauntidade_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 278);
            this.Controls.Add(this.txt_qtdNome);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.btn_lerQauntidade);
            this.Controls.Add(this.btn_ordenar);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_lerNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_lerNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.ListBox lb_nome;
        private System.Windows.Forms.Button btn_ordenar;
        private System.Windows.Forms.TextBox txt_qtdNome;
        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.Button btn_lerQauntidade;
        private System.Windows.Forms.Timer timer1;
    }
}

