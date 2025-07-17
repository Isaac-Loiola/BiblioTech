namespace BiblioTechDesk
{
    partial class UscReservar
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
            lblDisponiveis = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSubtitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            flpLivros = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblDisponiveis
            // 
            lblDisponiveis.BackColor = Color.Transparent;
            lblDisponiveis.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblDisponiveis.ForeColor = Color.Black;
            lblDisponiveis.IsSelectionEnabled = false;
            lblDisponiveis.Location = new Point(3, 12);
            lblDisponiveis.Name = "lblDisponiveis";
            lblDisponiveis.Size = new Size(143, 39);
            lblDisponiveis.TabIndex = 6;
            lblDisponiveis.Text = "Disponíveis";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSubtitulo.ForeColor = Color.FromArgb(69, 69, 69);
            lblSubtitulo.IsSelectionEnabled = false;
            lblSubtitulo.Location = new Point(3, 57);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(165, 19);
            lblSubtitulo.TabIndex = 5;
            lblSubtitulo.Text = "Todos os livros disponiveis";
            // 
            // flpLivros
            // 
            flpLivros.AutoScroll = true;
            flpLivros.Location = new Point(0, 82);
            flpLivros.Name = "flpLivros";
            flpLivros.Size = new Size(1054, 758);
            flpLivros.TabIndex = 4;
            // 
            // UscReservar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblDisponiveis);
            Controls.Add(lblSubtitulo);
            Controls.Add(flpLivros);
            Name = "UscReservar";
            Size = new Size(1054, 854);
            Load += UscReservar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblDisponiveis;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitulo;
        private FlowLayoutPanel flpLivros;
    }
}
