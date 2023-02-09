namespace Componentes
{
    partial class F_Veiculos
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
            this.tb_lista1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_lista1
            // 
            this.tb_lista1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_lista1.Location = new System.Drawing.Point(12, 12);
            this.tb_lista1.Multiline = true;
            this.tb_lista1.Name = "tb_lista1";
            this.tb_lista1.Size = new System.Drawing.Size(260, 237);
            this.tb_lista1.TabIndex = 0;
            // 
            // F_Veiculos
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tb_lista1);
            this.Name = "F_Veiculos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Veiculos_FormClosed);
            this.Load += new System.EventHandler(this.F_Veiculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tb_lista;
        private System.Windows.Forms.TextBox tb_lista1;
    }
}