namespace Aula_11_12_pag_30____Ex_02_03
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
            this.txt_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.btn_executar = new System.Windows.Forms.Button();
            this.btn_criptografar = new System.Windows.Forms.Button();
            this.btn_virus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_text
            // 
            this.txt_text.Location = new System.Drawing.Point(132, 35);
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(291, 20);
            this.txt_text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome/Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado";
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(148, 266);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(291, 20);
            this.txt_resultado.TabIndex = 2;
            // 
            // btn_executar
            // 
            this.btn_executar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_executar.Location = new System.Drawing.Point(94, 211);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(100, 31);
            this.btn_executar.TabIndex = 4;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // btn_criptografar
            // 
            this.btn_criptografar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criptografar.Location = new System.Drawing.Point(223, 211);
            this.btn_criptografar.Name = "btn_criptografar";
            this.btn_criptografar.Size = new System.Drawing.Size(100, 31);
            this.btn_criptografar.TabIndex = 5;
            this.btn_criptografar.Text = "Criptografar";
            this.btn_criptografar.UseVisualStyleBackColor = true;
            this.btn_criptografar.Click += new System.EventHandler(this.btn_criptografar_Click);
            // 
            // btn_virus
            // 
            this.btn_virus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_virus.Location = new System.Drawing.Point(339, 211);
            this.btn_virus.Name = "btn_virus";
            this.btn_virus.Size = new System.Drawing.Size(100, 31);
            this.btn_virus.TabIndex = 6;
            this.btn_virus.Text = "Virus";
            this.btn_virus.UseVisualStyleBackColor = true;
            this.btn_virus.Click += new System.EventHandler(this.btn_virus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 398);
            this.Controls.Add(this.btn_virus);
            this.Controls.Add(this.btn_criptografar);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Button btn_criptografar;
        private System.Windows.Forms.Button btn_virus;
    }
}

