namespace Ex_08__Domingos_
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_valores = new System.Windows.Forms.Button();
            this.btn_impares = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(72, 108);
            this.listBox1.TabIndex = 0;
            // 
            // btn_valores
            // 
            this.btn_valores.Location = new System.Drawing.Point(90, 95);
            this.btn_valores.Name = "btn_valores";
            this.btn_valores.Size = new System.Drawing.Size(72, 35);
            this.btn_valores.TabIndex = 1;
            this.btn_valores.Text = "Valores";
            this.btn_valores.UseVisualStyleBackColor = true;
            this.btn_valores.Click += new System.EventHandler(this.btn_valores_Click);
            // 
            // btn_impares
            // 
            this.btn_impares.Location = new System.Drawing.Point(294, 95);
            this.btn_impares.Name = "btn_impares";
            this.btn_impares.Size = new System.Drawing.Size(72, 35);
            this.btn_impares.TabIndex = 3;
            this.btn_impares.Text = "Ímpares";
            this.btn_impares.UseVisualStyleBackColor = true;
            this.btn_impares.Click += new System.EventHandler(this.btn_impares_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(216, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(72, 108);
            this.listBox2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 170);
            this.Controls.Add(this.btn_impares);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btn_valores);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_valores;
        private System.Windows.Forms.Button btn_impares;
        private System.Windows.Forms.ListBox listBox2;
    }
}

