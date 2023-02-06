namespace aula60
{
    partial class F_Principal
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
            this.btn_texto = new System.Windows.Forms.Button();
            this.lb_texto = new System.Windows.Forms.Label();
            this.tb_texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_texto
            // 
            this.btn_texto.BackColor = System.Drawing.Color.Black;
            this.btn_texto.Font = new System.Drawing.Font("Gill Sans MT", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_texto.Location = new System.Drawing.Point(26, 63);
            this.btn_texto.Margin = new System.Windows.Forms.Padding(6);
            this.btn_texto.Name = "btn_texto";
            this.btn_texto.Size = new System.Drawing.Size(214, 69);
            this.btn_texto.TabIndex = 0;
            this.btn_texto.Text = "OK";
            this.btn_texto.UseVisualStyleBackColor = false;
            this.btn_texto.Click += new System.EventHandler(this.btn_texto_Click);
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.ForeColor = System.Drawing.Color.Black;
            this.lb_texto.Location = new System.Drawing.Point(12, 138);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(244, 26);
            this.lb_texto.TabIndex = 1;
            this.lb_texto.Text = "www.corinthians.com.br";
            this.lb_texto.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_texto
            // 
            this.tb_texto.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_texto.Location = new System.Drawing.Point(26, 22);
            this.tb_texto.Name = "tb_texto";
            this.tb_texto.Size = new System.Drawing.Size(214, 32);
            this.tb_texto.TabIndex = 2;
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 749);
            this.Controls.Add(this.tb_texto);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.btn_texto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "F_Principal";
            this.Text = "Curso de C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_texto;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.TextBox tb_texto;
    }
}

