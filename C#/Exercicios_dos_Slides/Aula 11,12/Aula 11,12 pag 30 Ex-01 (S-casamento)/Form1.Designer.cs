namespace Aula_11_12_pag_30_Ex_01__S_casamento_
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
            this.txt_homem = new System.Windows.Forms.Label();
            this.txt_mulher = new System.Windows.Forms.Label();
            this.lbl_novoNome = new System.Windows.Forms.Label();
            this.txt_novoNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_sim = new System.Windows.Forms.RadioButton();
            this.rb_nao = new System.Windows.Forms.RadioButton();
            this.txt_nomeMulher = new System.Windows.Forms.TextBox();
            this.txt_nomeHomem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_executar
            // 
            this.btn_executar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_executar.Location = new System.Drawing.Point(130, 182);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(111, 35);
            this.btn_executar.TabIndex = 0;
            this.btn_executar.Text = "Novo Nome";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // txt_homem
            // 
            this.txt_homem.AutoSize = true;
            this.txt_homem.Location = new System.Drawing.Point(19, 36);
            this.txt_homem.Name = "txt_homem";
            this.txt_homem.Size = new System.Drawing.Size(43, 13);
            this.txt_homem.TabIndex = 2;
            this.txt_homem.Text = "Homem";
            // 
            // txt_mulher
            // 
            this.txt_mulher.AutoSize = true;
            this.txt_mulher.Location = new System.Drawing.Point(19, 74);
            this.txt_mulher.Name = "txt_mulher";
            this.txt_mulher.Size = new System.Drawing.Size(39, 13);
            this.txt_mulher.TabIndex = 4;
            this.txt_mulher.Text = "Mulher";
            // 
            // lbl_novoNome
            // 
            this.lbl_novoNome.AutoSize = true;
            this.lbl_novoNome.Location = new System.Drawing.Point(-2, 249);
            this.lbl_novoNome.Name = "lbl_novoNome";
            this.lbl_novoNome.Size = new System.Drawing.Size(64, 13);
            this.lbl_novoNome.TabIndex = 6;
            this.lbl_novoNome.Text = "Novo Nome";
            // 
            // txt_novoNome
            // 
            this.txt_novoNome.Location = new System.Drawing.Point(68, 246);
            this.txt_novoNome.Name = "txt_novoNome";
            this.txt_novoNome.Size = new System.Drawing.Size(254, 20);
            this.txt_novoNome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contrairam o matrinonio?";
            // 
            // rb_sim
            // 
            this.rb_sim.AutoSize = true;
            this.rb_sim.Location = new System.Drawing.Point(98, 141);
            this.rb_sim.Name = "rb_sim";
            this.rb_sim.Size = new System.Drawing.Size(43, 17);
            this.rb_sim.TabIndex = 10;
            this.rb_sim.TabStop = true;
            this.rb_sim.Text = "SIm";
            this.rb_sim.UseVisualStyleBackColor = true;
            this.rb_sim.CheckedChanged += new System.EventHandler(this.rb_sim_CheckedChanged);
            // 
            // rb_nao
            // 
            this.rb_nao.AutoSize = true;
            this.rb_nao.Location = new System.Drawing.Point(147, 141);
            this.rb_nao.Name = "rb_nao";
            this.rb_nao.Size = new System.Drawing.Size(45, 17);
            this.rb_nao.TabIndex = 11;
            this.rb_nao.TabStop = true;
            this.rb_nao.Text = "Não";
            this.rb_nao.UseVisualStyleBackColor = true;
            this.rb_nao.CheckedChanged += new System.EventHandler(this.rb_nao_CheckedChanged);
            // 
            // txt_nomeMulher
            // 
            this.txt_nomeMulher.Location = new System.Drawing.Point(78, 71);
            this.txt_nomeMulher.Name = "txt_nomeMulher";
            this.txt_nomeMulher.Size = new System.Drawing.Size(254, 20);
            this.txt_nomeMulher.TabIndex = 12;
            // 
            // txt_nomeHomem
            // 
            this.txt_nomeHomem.Location = new System.Drawing.Point(78, 36);
            this.txt_nomeHomem.Name = "txt_nomeHomem";
            this.txt_nomeHomem.Size = new System.Drawing.Size(254, 20);
            this.txt_nomeHomem.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 305);
            this.Controls.Add(this.txt_nomeHomem);
            this.Controls.Add(this.txt_nomeMulher);
            this.Controls.Add(this.rb_nao);
            this.Controls.Add(this.rb_sim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_novoNome);
            this.Controls.Add(this.txt_novoNome);
            this.Controls.Add(this.txt_mulher);
            this.Controls.Add(this.txt_homem);
            this.Controls.Add(this.btn_executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Label txt_homem;
        private System.Windows.Forms.Label txt_mulher;
        private System.Windows.Forms.Label lbl_novoNome;
        private System.Windows.Forms.TextBox txt_novoNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_sim;
        private System.Windows.Forms.RadioButton rb_nao;
        private System.Windows.Forms.TextBox txt_nomeMulher;
        private System.Windows.Forms.TextBox txt_nomeHomem;
    }
}

