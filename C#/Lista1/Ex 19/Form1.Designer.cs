namespace Ex_19
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
            this.txt_caminho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_video = new System.Windows.Forms.TextBox();
            this.txt_image = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_caminho
            // 
            this.txt_caminho.Location = new System.Drawing.Point(141, 26);
            this.txt_caminho.Name = "txt_caminho";
            this.txt_caminho.Size = new System.Drawing.Size(330, 20);
            this.txt_caminho.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade de video";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_video
            // 
            this.txt_video.Location = new System.Drawing.Point(166, 65);
            this.txt_video.Name = "txt_video";
            this.txt_video.ReadOnly = true;
            this.txt_video.Size = new System.Drawing.Size(58, 20);
            this.txt_video.TabIndex = 2;
            // 
            // txt_image
            // 
            this.txt_image.Location = new System.Drawing.Point(413, 69);
            this.txt_image.Name = "txt_image";
            this.txt_image.ReadOnly = true;
            this.txt_image.Size = new System.Drawing.Size(58, 20);
            this.txt_image.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade de imagem";
            // 
            // btn_verificar
            // 
            this.btn_verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verificar.Location = new System.Drawing.Point(199, 100);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(99, 34);
            this.btn_verificar.TabIndex = 5;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Caminho da pasta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 142);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_image);
            this.Controls.Add(this.txt_video);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_caminho);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_caminho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_video;
        private System.Windows.Forms.TextBox txt_image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Label label3;
    }
}

