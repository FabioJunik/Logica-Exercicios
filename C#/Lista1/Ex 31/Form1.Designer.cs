namespace Ex_31
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
            this.lb_arquivo1 = new System.Windows.Forms.ListBox();
            this.lb_arquivo2 = new System.Windows.Forms.ListBox();
            this.txt_caminho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_caminho = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_arquivo1
            // 
            this.lb_arquivo1.FormattingEnabled = true;
            this.lb_arquivo1.Location = new System.Drawing.Point(37, 214);
            this.lb_arquivo1.Name = "lb_arquivo1";
            this.lb_arquivo1.Size = new System.Drawing.Size(207, 160);
            this.lb_arquivo1.TabIndex = 0;
            // 
            // lb_arquivo2
            // 
            this.lb_arquivo2.FormattingEnabled = true;
            this.lb_arquivo2.Location = new System.Drawing.Point(275, 214);
            this.lb_arquivo2.Name = "lb_arquivo2";
            this.lb_arquivo2.Size = new System.Drawing.Size(201, 160);
            this.lb_arquivo2.TabIndex = 1;
            // 
            // txt_caminho
            // 
            this.txt_caminho.Location = new System.Drawing.Point(104, 29);
            this.txt_caminho.Name = "txt_caminho";
            this.txt_caminho.Size = new System.Drawing.Size(372, 20);
            this.txt_caminho.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Caminho";
            // 
            // btn_caminho
            // 
            this.btn_caminho.Location = new System.Drawing.Point(230, 106);
            this.btn_caminho.Name = "btn_caminho";
            this.btn_caminho.Size = new System.Drawing.Size(86, 39);
            this.btn_caminho.TabIndex = 6;
            this.btn_caminho.Text = "Ler";
            this.btn_caminho.UseVisualStyleBackColor = true;
            this.btn_caminho.Click += new System.EventHandler(this.btn_caminho_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(104, 67);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(372, 20);
            this.txt_nome.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ordem normal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ordem inversa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(503, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_caminho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_caminho);
            this.Controls.Add(this.lb_arquivo2);
            this.Controls.Add(this.lb_arquivo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_arquivo1;
        private System.Windows.Forms.ListBox lb_arquivo2;
        private System.Windows.Forms.TextBox txt_caminho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_caminho;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

