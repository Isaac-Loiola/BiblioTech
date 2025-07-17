namespace BiblioTechDesk
{
    partial class UscInicio
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            flpDestaque = new FlowLayoutPanel();
            lblAjuda = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblAdquiridos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblsubtitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            flpMaisAdquiridos = new FlowLayoutPanel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // flpDestaque
            // 
            flpDestaque.Location = new Point(0, 82);
            flpDestaque.Name = "flpDestaque";
            flpDestaque.Size = new Size(1054, 401);
            flpDestaque.TabIndex = 0;
            flpDestaque.Paint += flpDestaque_Paint;
            // 
            // lblAjuda
            // 
            lblAjuda.BackColor = Color.Transparent;
            lblAjuda.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblAjuda.ForeColor = Color.FromArgb(69, 69, 69);
            lblAjuda.IsSelectionEnabled = false;
            lblAjuda.Location = new Point(3, 57);
            lblAjuda.Name = "lblAjuda";
            lblAjuda.Size = new Size(161, 19);
            lblAjuda.TabIndex = 3;
            lblAjuda.Text = "Utilize o  email cadastrado.";
            // 
            // lblAdquiridos
            // 
            lblAdquiridos.BackColor = Color.Transparent;
            lblAdquiridos.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblAdquiridos.IsSelectionEnabled = false;
            lblAdquiridos.Location = new Point(3, 489);
            lblAdquiridos.Name = "lblAdquiridos";
            lblAdquiridos.Size = new Size(202, 39);
            lblAdquiridos.TabIndex = 4;
            lblAdquiridos.Text = "Mais Adquiridos";
            // 
            // lblsubtitulo
            // 
            lblsubtitulo.BackColor = Color.Transparent;
            lblsubtitulo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblsubtitulo.ForeColor = Color.FromArgb(69, 69, 69);
            lblsubtitulo.IsSelectionEnabled = false;
            lblsubtitulo.Location = new Point(3, 534);
            lblsubtitulo.Name = "lblsubtitulo";
            lblsubtitulo.Size = new Size(173, 19);
            lblsubtitulo.TabIndex = 3;
            lblsubtitulo.Text = "Livros que estão bombando";
            // 
            // flpMaisAdquiridos
            // 
            flpMaisAdquiridos.Location = new Point(0, 559);
            flpMaisAdquiridos.Name = "flpMaisAdquiridos";
            flpMaisAdquiridos.Size = new Size(1054, 282);
            flpMaisAdquiridos.TabIndex = 5;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.Black;
            guna2HtmlLabel1.IsSelectionEnabled = false;
            guna2HtmlLabel1.Location = new Point(3, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(118, 39);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "Destaque";
            // 
            // UscInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblsubtitulo);
            Controls.Add(lblAdquiridos);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(lblAjuda);
            Controls.Add(flpMaisAdquiridos);
            Controls.Add(flpDestaque);
            Name = "UscInicio";
            Size = new Size(1054, 854);
            Load += UscInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpDestaque;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAjuda;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAdquiridos;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblsubtitulo;
        private FlowLayoutPanel flpMaisAdquiridos;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
