namespace L1_Ex_29
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
            this.bnt_executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnt_executar
            // 
            this.bnt_executar.BackColor = System.Drawing.Color.Red;
            this.bnt_executar.FlatAppearance.BorderSize = 0;
            this.bnt_executar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_executar.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_executar.Location = new System.Drawing.Point(89, 78);
            this.bnt_executar.Name = "bnt_executar";
            this.bnt_executar.Size = new System.Drawing.Size(221, 65);
            this.bnt_executar.TabIndex = 0;
            this.bnt_executar.Text = "Executar";
            this.bnt_executar.UseVisualStyleBackColor = false;
            this.bnt_executar.Click += new System.EventHandler(this.bnt_executar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(389, 219);
            this.Controls.Add(this.bnt_executar);
            this.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnt_executar;
    }
}

