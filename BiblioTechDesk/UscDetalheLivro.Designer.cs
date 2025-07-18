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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UscDetalheLivro));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            picCapaLivro = new Guna.UI2.WinForms.Guna2PictureBox();
            lblExibicaoNomeAutor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSobreLivro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnReservar = new Guna.UI2.WinForms.Guna2Button();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            lblDescricao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnDetalhes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblEditora = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblNomeEditora = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblAutor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblNomeAutor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDimensao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblValorDimensao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblGenero = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblPublicacao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblDataPublicacao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)picCapaLivro).BeginInit();
            SuspendLayout();
            // 
            // picCapaLivro
            // 
            picCapaLivro.BorderRadius = 10;
            picCapaLivro.CustomizableEdges = customizableEdges7;
            picCapaLivro.Image = (Image)resources.GetObject("picCapaLivro.Image");
            picCapaLivro.ImageRotate = 0F;
            picCapaLivro.Location = new Point(3, 201);
            picCapaLivro.Name = "picCapaLivro";
            picCapaLivro.ShadowDecoration.CustomizableEdges = customizableEdges8;
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
            // 
            // btnReservar
            // 
            btnReservar.BorderRadius = 10;
            btnReservar.CustomizableEdges = customizableEdges9;
            btnReservar.DisabledState.BorderColor = Color.DarkGray;
            btnReservar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReservar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReservar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReservar.FillColor = Color.Black;
            btnReservar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnReservar.ForeColor = Color.White;
            btnReservar.Location = new Point(3, 622);
            btnReservar.Name = "btnReservar";
            btnReservar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnReservar.Size = new Size(274, 29);
            btnReservar.TabIndex = 22;
            btnReservar.Text = "Reservar";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderColor = Color.White;
            guna2TextBox1.CustomizableEdges = customizableEdges11;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.Enabled = false;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            guna2TextBox1.ForeColor = Color.FromArgb(69, 69, 69);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(417, 146);
            guna2TextBox1.Multiline = true;
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2TextBox1.Size = new Size(515, 385);
            guna2TextBox1.TabIndex = 24;
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
            btnDetalhes.Location = new Point(417, 577);
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
            lblEditora.Location = new Point(417, 622);
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
            lblNomeEditora.Location = new Point(482, 622);
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
            lblAutor.Location = new Point(417, 664);
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
            lblNomeAutor.Location = new Point(472, 664);
            lblNomeAutor.Name = "lblNomeAutor";
            lblNomeAutor.Size = new Size(112, 23);
            lblNomeAutor.TabIndex = 26;
            lblNomeAutor.Text = "nome do autor";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            guna2HtmlLabel4.ForeColor = Color.Black;
            guna2HtmlLabel4.IsSelectionEnabled = false;
            guna2HtmlLabel4.Location = new Point(418, 708);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(59, 23);
            guna2HtmlLabel4.TabIndex = 26;
            guna2HtmlLabel4.Text = "Editora: ";
            // 
            // lblDimensao
            // 
            this.lblDimensao.BackColor = Color.Transparent;
            this.lblDimensao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            this.lblDimensao.ForeColor = Color.Black;
            this.lblDimensao.IsSelectionEnabled = false;
            this.lblDimensao.Location = new Point(417, 708);
            this.lblDimensao.Name = "lblDimensao";
            this.lblDimensao.Size = new Size(87, 23);
            this.lblDimensao.TabIndex = 26;
            this.lblDimensao.Text = "Dimensões:";
            // 
            // lblValorDimensao
            // 
            this.lblValorDimensao.BackColor = Color.Transparent;
            this.lblValorDimensao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            this.lblValorDimensao.ForeColor = Color.FromArgb(69, 69, 69);
            this.lblValorDimensao.IsSelectionEnabled = false;
            this.lblValorDimensao.Location = new Point(510, 708);
            this.lblValorDimensao.Name = "lblValorDimensao";
            this.lblValorDimensao.Size = new Size(142, 23);
            this.lblValorDimensao.TabIndex = 26;
            this.lblValorDimensao.Text = "dimensões do livro";
            // 
            // lblGenero
            // 
            lblGenero.BackColor = Color.Transparent;
            lblGenero.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblGenero.ForeColor = Color.Black;
            lblGenero.IsSelectionEnabled = false;
            lblGenero.Location = new Point(417, 752);
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
            guna2HtmlLabel9.Location = new Point(484, 752);
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
            lblPublicacao.Location = new Point(417, 799);
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
            lblDataPublicacao.Location = new Point(568, 799);
            lblDataPublicacao.Name = "lblDataPublicacao";
            lblDataPublicacao.Size = new Size(141, 23);
            lblDataPublicacao.TabIndex = 26;
            lblDataPublicacao.Text = "data de publicação";
            // 
            // UscDetalheLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblDataPublicacao);
            Controls.Add(lblPublicacao);
            Controls.Add(guna2HtmlLabel9);
            Controls.Add(lblGenero);
            Controls.Add(this.lblValorDimensao);
            Controls.Add(this.lblDimensao);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(lblNomeAutor);
            Controls.Add(lblAutor);
            Controls.Add(lblNomeEditora);
            Controls.Add(lblEditora);
            Controls.Add(btnDetalhes);
            Controls.Add(lblDescricao);
            Controls.Add(guna2TextBox1);
            Controls.Add(btnReservar);
            Controls.Add(lblSobreLivro);
            Controls.Add(lblExibicaoNomeAutor);
            Controls.Add(picCapaLivro);
            Name = "UscDetalheLivro";
            Size = new Size(1054, 854);
            Load += UscDetalheLivro_Load;
            ((System.ComponentModel.ISupportInitialize)picCapaLivro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picCapaLivro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblExibicaoNomeAutor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSobreLivro;
        private Guna.UI2.WinForms.Guna2Button btnReservar;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescricao;
        private Guna.UI2.WinForms.Guna2HtmlLabel btnDetalhes;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEditora;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNomeEditora;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAutor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNomeAutor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGenero;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPublicacao;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDataPublicacao;
    }
}
