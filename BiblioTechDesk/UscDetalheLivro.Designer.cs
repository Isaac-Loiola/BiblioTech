namespace BiblioTechDesk
{
    partial class UscDetalheLivro
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UscDetalheLivro));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            picCapaLivro = new Guna.UI2.WinForms.Guna2PictureBox();
            lblExibicaoNomeAutor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSobreLivro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnReservar = new Guna.UI2.WinForms.Guna2Button();
            lblDescricao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnDetalhes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblEditora = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblNomeEditora = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblAutor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblNomeAutor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblDimensao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblGenero = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblPublicacao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblDataPublicacao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblValorDimensao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblValorDescricao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            picDivisao = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCapaLivro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDivisao).BeginInit();
            SuspendLayout();
            // 
            // picCapaLivro
            // 
            picCapaLivro.BorderRadius = 10;
            picCapaLivro.CustomizableEdges = customizableEdges1;
            picCapaLivro.Image = (Image)resources.GetObject("picCapaLivro.Image");
            picCapaLivro.ImageRotate = 0F;
            picCapaLivro.Location = new Point(3, 201);
            picCapaLivro.Name = "picCapaLivro";
            picCapaLivro.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picCapaLivro.Size = new Size(274, 415);
            picCapaLivro.SizeMode = PictureBoxSizeMode.StretchImage;
            picCapaLivro.TabIndex = 0;
            picCapaLivro.TabStop = false;
            // 
            // lblExibicaoNomeAutor
            // 
            lblExibicaoNomeAutor.BackColor = Color.Transparent;
            lblExibicaoNomeAutor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblExibicaoNomeAutor.ForeColor = Color.Black;
            lblExibicaoNomeAutor.IsSelectionEnabled = false;
            lblExibicaoNomeAutor.Location = new Point(3, 176);
            lblExibicaoNomeAutor.Name = "lblExibicaoNomeAutor";
            lblExibicaoNomeAutor.Size = new Size(118, 23);
            lblExibicaoNomeAutor.TabIndex = 6;
            lblExibicaoNomeAutor.Text = "Nome do Autor";
            // 
            // lblSobreLivro
            // 
            lblSobreLivro.BackColor = Color.Transparent;
            lblSobreLivro.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblSobreLivro.ForeColor = Color.Black;
            lblSobreLivro.IsSelectionEnabled = false;
            lblSobreLivro.Location = new Point(3, 12);
            lblSobreLivro.Name = "lblSobreLivro";
            lblSobreLivro.Size = new Size(164, 39);
            lblSobreLivro.TabIndex = 7;
            lblSobreLivro.Text = "Sobre o Livro";
            lblSobreLivro.Click += lblSobreLivro_Click;
            // 
            // btnReservar
            // 
            btnReservar.BorderRadius = 10;
            btnReservar.CustomizableEdges = customizableEdges3;
            btnReservar.DisabledState.BorderColor = Color.DarkGray;
            btnReservar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReservar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReservar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReservar.FillColor = Color.Black;
            btnReservar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnReservar.ForeColor = Color.White;
            btnReservar.Location = new Point(41, 622);
            btnReservar.Name = "btnReservar";
            btnReservar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnReservar.Size = new Size(189, 29);
            btnReservar.TabIndex = 22;
            btnReservar.Text = "Reservar";
            // 
            // lblDescricao
            // 
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblDescricao.ForeColor = Color.Black;
            lblDescricao.IsSelectionEnabled = false;
            lblDescricao.Location = new Point(417, 101);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(121, 39);
            lblDescricao.TabIndex = 25;
            lblDescricao.Text = "Descrição";
            // 
            // btnDetalhes
            // 
            btnDetalhes.BackColor = Color.Transparent;
            btnDetalhes.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            btnDetalhes.ForeColor = Color.Black;
            btnDetalhes.IsSelectionEnabled = false;
            btnDetalhes.Location = new Point(417, 527);
            btnDetalhes.Name = "btnDetalhes";
            btnDetalhes.Size = new Size(109, 39);
            btnDetalhes.TabIndex = 25;
            btnDetalhes.Text = "Detalhes";
            // 
            // lblEditora
            // 
            lblEditora.BackColor = Color.Transparent;
            lblEditora.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEditora.ForeColor = Color.Black;
            lblEditora.IsSelectionEnabled = false;
            lblEditora.Location = new Point(417, 572);
            lblEditora.Name = "lblEditora";
            lblEditora.Size = new Size(59, 23);
            lblEditora.TabIndex = 26;
            lblEditora.Text = "Editora: ";
            // 
            // lblNomeEditora
            // 
            lblNomeEditora.BackColor = Color.Transparent;
            lblNomeEditora.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNomeEditora.ForeColor = Color.FromArgb(69, 69, 69);
            lblNomeEditora.IsSelectionEnabled = false;
            lblNomeEditora.Location = new Point(482, 572);
            lblNomeEditora.Name = "lblNomeEditora";
            lblNomeEditora.Size = new Size(124, 23);
            lblNomeEditora.TabIndex = 26;
            lblNomeEditora.Text = "nome da editora";
            // 
            // lblAutor
            // 
            lblAutor.BackColor = Color.Transparent;
            lblAutor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAutor.ForeColor = Color.Black;
            lblAutor.IsSelectionEnabled = false;
            lblAutor.Location = new Point(417, 614);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(49, 23);
            lblAutor.TabIndex = 26;
            lblAutor.Text = "Autor:";
            // 
            // lblNomeAutor
            // 
            lblNomeAutor.BackColor = Color.Transparent;
            lblNomeAutor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNomeAutor.ForeColor = Color.FromArgb(69, 69, 69);
            lblNomeAutor.IsSelectionEnabled = false;
            lblNomeAutor.Location = new Point(472, 614);
            lblNomeAutor.Name = "lblNomeAutor";
            lblNomeAutor.Size = new Size(112, 23);
            lblNomeAutor.TabIndex = 26;
            lblNomeAutor.Text = "nome do autor";
            // 
            // lblDimensao
            // 
            lblDimensao.BackColor = Color.Transparent;
            lblDimensao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDimensao.ForeColor = Color.Black;
            lblDimensao.IsSelectionEnabled = false;
            lblDimensao.Location = new Point(418, 658);
            lblDimensao.Name = "lblDimensao";
            lblDimensao.Size = new Size(79, 23);
            lblDimensao.TabIndex = 26;
            lblDimensao.Text = "Dimensão:";
            // 
            // lblGenero
            // 
            lblGenero.BackColor = Color.Transparent;
            lblGenero.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblGenero.ForeColor = Color.Black;
            lblGenero.IsSelectionEnabled = false;
            lblGenero.Location = new Point(417, 702);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(61, 23);
            lblGenero.TabIndex = 26;
            lblGenero.Text = "Género:";
            // 
            // guna2HtmlLabel9
            // 
            guna2HtmlLabel9.BackColor = Color.Transparent;
            guna2HtmlLabel9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            guna2HtmlLabel9.ForeColor = Color.FromArgb(69, 69, 69);
            guna2HtmlLabel9.IsSelectionEnabled = false;
            guna2HtmlLabel9.Location = new Point(484, 702);
            guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            guna2HtmlLabel9.Size = new Size(126, 23);
            guna2HtmlLabel9.TabIndex = 26;
            guna2HtmlLabel9.Text = "nome do género";
            // 
            // lblPublicacao
            // 
            lblPublicacao.BackColor = Color.Transparent;
            lblPublicacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPublicacao.ForeColor = Color.Black;
            lblPublicacao.IsSelectionEnabled = false;
            lblPublicacao.Location = new Point(417, 749);
            lblPublicacao.Name = "lblPublicacao";
            lblPublicacao.Size = new Size(145, 23);
            lblPublicacao.TabIndex = 26;
            lblPublicacao.Text = "Data de Publicação:";
            // 
            // lblDataPublicacao
            // 
            lblDataPublicacao.BackColor = Color.Transparent;
            lblDataPublicacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDataPublicacao.ForeColor = Color.FromArgb(69, 69, 69);
            lblDataPublicacao.IsSelectionEnabled = false;
            lblDataPublicacao.Location = new Point(568, 749);
            lblDataPublicacao.Name = "lblDataPublicacao";
            lblDataPublicacao.Size = new Size(141, 23);
            lblDataPublicacao.TabIndex = 26;
            lblDataPublicacao.Text = "data de publicação";
            // 
            // lblValorDimensao
            // 
            lblValorDimensao.BackColor = Color.Transparent;
            lblValorDimensao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblValorDimensao.ForeColor = Color.FromArgb(69, 69, 69);
            lblValorDimensao.IsSelectionEnabled = false;
            lblValorDimensao.Location = new Point(503, 658);
            lblValorDimensao.Name = "lblValorDimensao";
            lblValorDimensao.Size = new Size(134, 23);
            lblValorDimensao.TabIndex = 27;
            lblValorDimensao.Text = "dimensão do livro";
            // 
            // lblValorDescricao
            // 
            lblValorDescricao.BackColor = Color.Transparent;
            lblValorDescricao.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblValorDescricao.ForeColor = Color.FromArgb(69, 69, 69);
            lblValorDescricao.IsSelectionEnabled = false;
            lblValorDescricao.Location = new Point(417, 146);
            lblValorDescricao.MaximumSize = new Size(590, 385);
            lblValorDescricao.Name = "lblValorDescricao";
            lblValorDescricao.Size = new Size(106, 22);
            lblValorDescricao.TabIndex = 26;
            lblValorDescricao.Text = "descrição aqui!";
            // 
            // picDivisao
            // 
            picDivisao.Image = (Image)resources.GetObject("picDivisao.Image");
            picDivisao.Location = new Point(417, 506);
            picDivisao.Name = "picDivisao";
            picDivisao.Size = new Size(590, 5);
            picDivisao.TabIndex = 28;
            picDivisao.TabStop = false;
            // 
            // UscDetalheLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(picDivisao);
            Controls.Add(lblValorDimensao);
            Controls.Add(lblDataPublicacao);
            Controls.Add(lblPublicacao);
            Controls.Add(guna2HtmlLabel9);
            Controls.Add(lblGenero);
            Controls.Add(lblDimensao);
            Controls.Add(lblNomeAutor);
            Controls.Add(lblAutor);
            Controls.Add(lblValorDescricao);
            Controls.Add(lblNomeEditora);
            Controls.Add(lblEditora);
            Controls.Add(btnDetalhes);
            Controls.Add(lblDescricao);
            Controls.Add(btnReservar);
            Controls.Add(lblSobreLivro);
            Controls.Add(lblExibicaoNomeAutor);
            Controls.Add(picCapaLivro);
            Name = "UscDetalheLivro";
            Size = new Size(1054, 854);
            Load += UscDetalheLivro_Load;
            ((System.ComponentModel.ISupportInitialize)picCapaLivro).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDivisao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picCapaLivro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblExibicaoNomeAutor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSobreLivro;
        private Guna.UI2.WinForms.Guna2Button btnReservar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescricao;
        private Guna.UI2.WinForms.Guna2HtmlLabel btnDetalhes;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEditora;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNomeEditora;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAutor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNomeAutor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDimensao;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGenero;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPublicacao;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDataPublicacao;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblValorDimensao;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblValorDescricao;
        private PictureBox picDivisao;
    }
}
