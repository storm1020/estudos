namespace FormParaEstudo
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
            this.btnWinform = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.wpfUserControl1 = new FormParaEstudo.wpfUserControl();
            this.SuspendLayout();
            // 
            // btnWinform
            // 
            this.btnWinform.Location = new System.Drawing.Point(563, 28);
            this.btnWinform.Name = "btnWinform";
            this.btnWinform.Size = new System.Drawing.Size(169, 59);
            this.btnWinform.TabIndex = 1;
            this.btnWinform.Text = "WinForms Btn";
            this.btnWinform.UseVisualStyleBackColor = true;
            this.btnWinform.Click += new System.EventHandler(this.btnWinform_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(29, 28);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(515, 314);
            this.elementHost1.TabIndex = 2;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.wpfUserControl1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.btnWinform);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnWinform;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private FormParaEstudo.wpfUserControl wpfUserControl1;
    }
}

