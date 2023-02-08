namespace Componentes
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_adicione = new System.Windows.Forms.Button();
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.tb_lista = new System.Windows.Forms.TextBox();
            this.lb_digite = new System.Windows.Forms.Label();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(12, 286);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(181, 23);
            this.btn_limpar.TabIndex = 1;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_adicione
            // 
            this.btn_adicione.Location = new System.Drawing.Point(118, 25);
            this.btn_adicione.Name = "btn_adicione";
            this.btn_adicione.Size = new System.Drawing.Size(75, 23);
            this.btn_adicione.TabIndex = 2;
            this.btn_adicione.Text = "Adicionar";
            this.btn_adicione.UseVisualStyleBackColor = true;
            this.btn_adicione.Click += new System.EventHandler(this.btn_adicione_Click);
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_veiculo.Location = new System.Drawing.Point(12, 25);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(100, 20);
            this.tb_veiculo.TabIndex = 3;
            // 
            // tb_lista
            // 
            this.tb_lista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lista.Location = new System.Drawing.Point(12, 51);
            this.tb_lista.Multiline = true;
            this.tb_lista.Name = "tb_lista";
            this.tb_lista.ReadOnly = true;
            this.tb_lista.Size = new System.Drawing.Size(181, 229);
            this.tb_lista.TabIndex = 4;
            // 
            // lb_digite
            // 
            this.lb_digite.AutoSize = true;
            this.lb_digite.Location = new System.Drawing.Point(12, 9);
            this.lb_digite.Name = "lb_digite";
            this.lb_digite.Size = new System.Drawing.Size(93, 13);
            this.lb_digite.TabIndex = 5;
            this.lb_digite.Text = "Digite um veículo:";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(15, 315);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(178, 23);
            this.btn_mostrar.TabIndex = 6;
            this.btn_mostrar.Text = "Mostrar Veículos";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 346);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.lb_digite);
            this.Controls.Add(this.tb_lista);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.btn_adicione);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_adicione;
        private System.Windows.Forms.TextBox tb_veiculo;
        private System.Windows.Forms.TextBox tb_lista;
        private System.Windows.Forms.Label lb_digite;
        private System.Windows.Forms.Button btn_mostrar;
    }
}

