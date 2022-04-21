namespace Ex
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_frase = new System.Windows.Forms.TextBox();
            this.btn_criptografar = new System.Windows.Forms.Button();
            this.btn_descriptografar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            // 
            // txt_frase
            // 
            this.txt_frase.Location = new System.Drawing.Point(68, 25);
            this.txt_frase.Name = "txt_frase";
            this.txt_frase.Size = new System.Drawing.Size(177, 20);
            this.txt_frase.TabIndex = 1;
            // 
            // btn_criptografar
            // 
            this.btn_criptografar.Location = new System.Drawing.Point(31, 108);
            this.btn_criptografar.Name = "btn_criptografar";
            this.btn_criptografar.Size = new System.Drawing.Size(111, 23);
            this.btn_criptografar.TabIndex = 2;
            this.btn_criptografar.Text = "criptografar";
            this.btn_criptografar.UseVisualStyleBackColor = true;
            this.btn_criptografar.Click += new System.EventHandler(this.btn_criptografar_Click);
            // 
            // btn_descriptografar
            // 
            this.btn_descriptografar.Location = new System.Drawing.Point(160, 108);
            this.btn_descriptografar.Name = "btn_descriptografar";
            this.btn_descriptografar.Size = new System.Drawing.Size(133, 23);
            this.btn_descriptografar.TabIndex = 3;
            this.btn_descriptografar.Text = "descriptografar";
            this.btn_descriptografar.UseVisualStyleBackColor = true;
            this.btn_descriptografar.Click += new System.EventHandler(this.btn_descriptografar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 154);
            this.Controls.Add(this.btn_descriptografar);
            this.Controls.Add(this.btn_criptografar);
            this.Controls.Add(this.txt_frase);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_frase;
        private System.Windows.Forms.Button btn_criptografar;
        private System.Windows.Forms.Button btn_descriptografar;
    }
}

