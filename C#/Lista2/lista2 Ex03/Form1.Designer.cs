namespace lista2_Ex03
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.btn_executar = new System.Windows.Forms.Button();
            this.lbl_extenceDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(84, 39);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(146, 20);
            this.txt_data.TabIndex = 1;
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(124, 128);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(106, 31);
            this.btn_executar.TabIndex = 5;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // lbl_extenceDate
            // 
            this.lbl_extenceDate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_extenceDate.Location = new System.Drawing.Point(12, 79);
            this.lbl_extenceDate.Name = "lbl_extenceDate";
            this.lbl_extenceDate.Size = new System.Drawing.Size(348, 32);
            this.lbl_extenceDate.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 202);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.lbl_extenceDate);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Label lbl_extenceDate;
    }
}

