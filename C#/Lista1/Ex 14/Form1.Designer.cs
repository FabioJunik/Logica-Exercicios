namespace Ex_14
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
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_lerNota = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_qNotas = new System.Windows.Forms.TextBox();
            this.btn_qNotas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_lNormal = new System.Windows.Forms.Button();
            this.btn_lInversa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nota
            // 
            this.txt_nota.Location = new System.Drawing.Point(72, 16);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(88, 20);
            this.txt_nota.TabIndex = 0;
            this.txt_nota.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota";
            // 
            // btn_lerNota
            // 
            this.btn_lerNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lerNota.Location = new System.Drawing.Point(72, 42);
            this.btn_lerNota.Name = "btn_lerNota";
            this.btn_lerNota.Size = new System.Drawing.Size(88, 27);
            this.btn_lerNota.TabIndex = 2;
            this.btn_lerNota.Text = "Ler Nota";
            this.btn_lerNota.UseVisualStyleBackColor = true;
            this.btn_lerNota.Click += new System.EventHandler(this.btn_lerNota_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(102, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(89, 164);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidades de Notas que foram lidas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_qNotas
            // 
            this.txt_qNotas.Location = new System.Drawing.Point(205, 47);
            this.txt_qNotas.Name = "txt_qNotas";
            this.txt_qNotas.ReadOnly = true;
            this.txt_qNotas.Size = new System.Drawing.Size(75, 20);
            this.txt_qNotas.TabIndex = 5;
            // 
            // btn_qNotas
            // 
            this.btn_qNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qNotas.Location = new System.Drawing.Point(286, 42);
            this.btn_qNotas.Name = "btn_qNotas";
            this.btn_qNotas.Size = new System.Drawing.Size(76, 27);
            this.btn_qNotas.TabIndex = 6;
            this.btn_qNotas.Text = "Exibir";
            this.btn_qNotas.UseVisualStyleBackColor = true;
            this.btn_qNotas.Click += new System.EventHandler(this.btn_qNotas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order de normal";
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(279, 127);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(89, 164);
            this.listBox2.TabIndex = 8;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Order inversa";
            // 
            // btn_lNormal
            // 
            this.btn_lNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lNormal.Location = new System.Drawing.Point(103, 297);
            this.btn_lNormal.Name = "btn_lNormal";
            this.btn_lNormal.Size = new System.Drawing.Size(88, 27);
            this.btn_lNormal.TabIndex = 10;
            this.btn_lNormal.Text = "Exibir";
            this.btn_lNormal.UseVisualStyleBackColor = true;
            this.btn_lNormal.Click += new System.EventHandler(this.btn_lNormal_Click);
            // 
            // btn_lInversa
            // 
            this.btn_lInversa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lInversa.Location = new System.Drawing.Point(279, 298);
            this.btn_lInversa.Name = "btn_lInversa";
            this.btn_lInversa.Size = new System.Drawing.Size(89, 27);
            this.btn_lInversa.TabIndex = 11;
            this.btn_lInversa.Text = "Exibir";
            this.btn_lInversa.UseVisualStyleBackColor = true;
            this.btn_lInversa.Click += new System.EventHandler(this.btn_lInversa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 338);
            this.Controls.Add(this.btn_lInversa);
            this.Controls.Add(this.btn_lNormal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_qNotas);
            this.Controls.Add(this.txt_qNotas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_lerNota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nota);
            this.Name = "Form1";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_lerNota;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_qNotas;
        private System.Windows.Forms.Button btn_qNotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_lNormal;
        private System.Windows.Forms.Button btn_lInversa;
    }
}

