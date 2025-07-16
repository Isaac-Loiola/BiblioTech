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
            lblDestaque = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblAdquiridos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblsubtitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            flpMaisAdquiridos = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpDestaque
            // 
            flpDestaque.Location = new Point(55, 134);
            flpDestaque.Name = "flpDestaque";
            flpDestaque.Padding = new Padding(10);
            flpDestaque.Size = new Size(939, 386);
            flpDestaque.TabIndex = 0;
            // 
            // lblAjuda
            // 
            lblAjuda.BackColor = Color.Transparent;
            lblAjuda.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblAjuda.ForeColor = Color.FromArgb(69, 69, 69);
            lblAjuda.IsSelectionEnabled = false;
            lblAjuda.Location = new Point(55, 109);
            lblAjuda.Name = "lblAjuda";
            lblAjuda.Size = new Size(161, 19);
            lblAjuda.TabIndex = 3;
            lblAjuda.Text = "Utilize o  email cadastrado.";
            // 
            // lblDestaque
            // 
            lblDestaque.BackColor = Color.Transparent;
            lblDestaque.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblDestaque.IsSelectionEnabled = false;
            lblDestaque.Location = new Point(55, 64);
            lblDestaque.Name = "lblDestaque";
            lblDestaque.Size = new Size(118, 39);
            lblDestaque.TabIndex = 4;
            lblDestaque.Text = "Destaque";
            // 
            // lblAdquiridos
            // 
            lblAdquiridos.BackColor = Color.Transparent;
            lblAdquiridos.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblAdquiridos.IsSelectionEnabled = false;
            lblAdquiridos.Location = new Point(55, 539);
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
            lblsubtitulo.Location = new Point(55, 584);
            lblsubtitulo.Name = "lblsubtitulo";
            lblsubtitulo.Size = new Size(173, 19);
            lblsubtitulo.TabIndex = 3;
            lblsubtitulo.Text = "Livros que estão bombando";
            // 
            // flpMaisAdquiridos
            // 
            flpMaisAdquiridos.Location = new Point(55, 609);
            flpMaisAdquiridos.Name = "flpMaisAdquiridos";
            flpMaisAdquiridos.Padding = new Padding(10);
            flpMaisAdquiridos.Size = new Size(939, 232);
            flpMaisAdquiridos.TabIndex = 5;
            // 
            // UscInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flpMaisAdquiridos);
            Controls.Add(lblsubtitulo);
            Controls.Add(lblAjuda);
            Controls.Add(lblAdquiridos);
            Controls.Add(lblDestaque);
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
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDestaque;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAdquiridos;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblsubtitulo;
        private FlowLayoutPanel flpMaisAdquiridos;
    }
}
