namespace lista2_Ex05
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
            this.lb_listaPalavra = new System.Windows.Forms.ListBox();
            this.btn_ler = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_listaPalavra
            // 
            this.lb_listaPalavra.FormattingEnabled = true;
            this.lb_listaPalavra.Location = new System.Drawing.Point(12, 23);
            this.lb_listaPalavra.Name = "lb_listaPalavra";
            this.lb_listaPalavra.Size = new System.Drawing.Size(134, 290);
            this.lb_listaPalavra.TabIndex = 0;
            // 
            // btn_ler
            // 
            this.btn_ler.Location = new System.Drawing.Point(12, 325);
            this.btn_ler.Name = "btn_ler";
            this.btn_ler.Size = new System.Drawing.Size(134, 44);
            this.btn_ler.TabIndex = 1;
            this.btn_ler.Text = "Começar";
            this.btn_ler.UseVisualStyleBackColor = true;
            this.btn_ler.Click += new System.EventHandler(this.btn_ler_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(152, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 346);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ler);
            this.Controls.Add(this.lb_listaPalavra);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_listaPalavra;
        private System.Windows.Forms.Button btn_ler;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

