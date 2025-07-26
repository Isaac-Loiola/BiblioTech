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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblReserva = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSubtitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlFinalizarReserva = new Guna.UI2.WinForms.Guna2Panel();
            dgvResevas = new Guna.UI2.WinForms.Guna2DataGridView();
            pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            btnPenalidades = new Guna.UI2.WinForms.Guna2Button();
            btnReservas = new Guna.UI2.WinForms.Guna2Button();
            btnMenuAdicionar = new Guna.UI2.WinForms.Guna2Button();
            clnID = new DataGridViewTextBoxColumn();
            clnIdUsuario = new DataGridViewTextBoxColumn();
            clnIdLivro = new DataGridViewTextBoxColumn();
            clnDataReserva = new DataGridViewTextBoxColumn();
            clnDataDevolucao = new DataGridViewTextBoxColumn();
            clnStatus = new DataGridViewTextBoxColumn();
            pnlFinalizarReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResevas).BeginInit();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // lblReserva
            // 
            lblReserva.BackColor = Color.Transparent;
            lblReserva.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblReserva.ForeColor = Color.Black;
            lblReserva.IsSelectionEnabled = false;
            lblReserva.Location = new Point(3, 52);
            lblReserva.Name = "lblReserva";
            lblReserva.Size = new Size(98, 39);
            lblReserva.TabIndex = 6;
            lblReserva.Text = "Reserva";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSubtitulo.ForeColor = Color.FromArgb(69, 69, 69);
            lblSubtitulo.IsSelectionEnabled = false;
            lblSubtitulo.Location = new Point(3, 97);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(109, 19);
            lblSubtitulo.TabIndex = 5;
            lblSubtitulo.Text = "Finalizar Reservas";
            // 
            // pnlFinalizarReserva
            // 
            pnlFinalizarReserva.BorderRadius = 10;
            pnlFinalizarReserva.Controls.Add(dgvResevas);
            pnlFinalizarReserva.CustomizableEdges = customizableEdges1;
            pnlFinalizarReserva.Location = new Point(3, 170);
            pnlFinalizarReserva.Name = "pnlFinalizarReserva";
            pnlFinalizarReserva.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlFinalizarReserva.Size = new Size(1025, 668);
            pnlFinalizarReserva.TabIndex = 7;
            // 
            // dgvResevas
            // 
            dgvResevas.AllowUserToAddRows = false;
            dgvResevas.AllowUserToDeleteRows = false;
            dgvResevas.AllowUserToResizeColumns = false;
            dgvResevas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvResevas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvResevas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvResevas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvResevas.ColumnHeadersHeight = 22;
            dgvResevas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvResevas.Columns.AddRange(new DataGridViewColumn[] { clnID, clnIdUsuario, clnIdLivro, clnDataReserva, clnDataDevolucao, clnStatus });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(69, 69, 69);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(247, 247, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvResevas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvResevas.GridColor = Color.FromArgb(231, 229, 255);
            dgvResevas.Location = new Point(3, 3);
            dgvResevas.Name = "dgvResevas";
            dgvResevas.ReadOnly = true;
            dgvResevas.RowHeadersVisible = false;
            dgvResevas.RowTemplate.Height = 35;
            dgvResevas.Size = new Size(1019, 662);
            dgvResevas.TabIndex = 8;
            dgvResevas.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvResevas.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvResevas.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvResevas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvResevas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvResevas.ThemeStyle.BackColor = Color.White;
            dgvResevas.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvResevas.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvResevas.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvResevas.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvResevas.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvResevas.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvResevas.ThemeStyle.HeaderStyle.Height = 22;
            dgvResevas.ThemeStyle.ReadOnly = true;
            dgvResevas.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvResevas.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvResevas.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvResevas.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvResevas.ThemeStyle.RowsStyle.Height = 35;
            dgvResevas.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvResevas.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // pnlMenu
            // 
            pnlMenu.BorderRadius = 10;
            pnlMenu.Controls.Add(btnPenalidades);
            pnlMenu.Controls.Add(btnReservas);
            pnlMenu.Controls.Add(btnMenuAdicionar);
            pnlMenu.CustomizableEdges = customizableEdges9;
            pnlMenu.FillColor = Color.FromArgb(247, 247, 247);
            pnlMenu.Location = new Point(3, 12);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlMenu.Size = new Size(300, 34);
            pnlMenu.TabIndex = 16;
            // 
            // btnPenalidades
            // 
            btnPenalidades.BackColor = Color.Transparent;
            btnPenalidades.BorderRadius = 10;
            btnPenalidades.CustomizableEdges = customizableEdges3;
            btnPenalidades.DisabledState.BorderColor = Color.DarkGray;
            btnPenalidades.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPenalidades.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPenalidades.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPenalidades.FillColor = Color.FromArgb(247, 247, 247);
            btnPenalidades.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPenalidades.ForeColor = Color.Black;
            btnPenalidades.Location = new Point(203, 5);
            btnPenalidades.Name = "btnPenalidades";
            btnPenalidades.PressedColor = Color.White;
            btnPenalidades.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPenalidades.Size = new Size(94, 24);
            btnPenalidades.TabIndex = 1;
            btnPenalidades.Text = "Penalidades";
            // 
            // btnReservas
            // 
            btnReservas.BackColor = Color.Transparent;
            btnReservas.BorderRadius = 10;
            btnReservas.CustomizableEdges = customizableEdges5;
            btnReservas.DisabledState.BorderColor = Color.DarkGray;
            btnReservas.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReservas.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReservas.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReservas.FillColor = Color.FromArgb(247, 247, 247);
            btnReservas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnReservas.ForeColor = Color.Black;
            btnReservas.Location = new Point(103, 5);
            btnReservas.Name = "btnReservas";
            btnReservas.PressedColor = Color.White;
            btnReservas.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnReservas.Size = new Size(94, 24);
            btnReservas.TabIndex = 1;
            btnReservas.Text = "Reservas";
            // 
            // btnMenuAdicionar
            // 
            btnMenuAdicionar.BackColor = Color.Transparent;
            btnMenuAdicionar.BorderRadius = 10;
            btnMenuAdicionar.CustomizableEdges = customizableEdges7;
            btnMenuAdicionar.DisabledState.BorderColor = Color.DarkGray;
            btnMenuAdicionar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMenuAdicionar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMenuAdicionar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMenuAdicionar.FillColor = Color.FromArgb(247, 247, 247);
            btnMenuAdicionar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMenuAdicionar.ForeColor = Color.Black;
            btnMenuAdicionar.Location = new Point(3, 5);
            btnMenuAdicionar.Name = "btnMenuAdicionar";
            btnMenuAdicionar.PressedColor = Color.White;
            btnMenuAdicionar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnMenuAdicionar.Size = new Size(94, 24);
            btnMenuAdicionar.TabIndex = 1;
            btnMenuAdicionar.Text = "Adicionar";
            // 
            // clnID
            // 
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Visible = false;
            // 
            // clnIdUsuario
            // 
            clnIdUsuario.FillWeight = 112.309647F;
            clnIdUsuario.HeaderText = "Nome do Usuario";
            clnIdUsuario.Name = "clnIdUsuario";
            clnIdUsuario.ReadOnly = true;
            clnIdUsuario.Width = 248;
            // 
            // clnIdLivro
            // 
            clnIdLivro.FillWeight = 112.309647F;
            clnIdLivro.HeaderText = "Nome do Livro";
            clnIdLivro.Name = "clnIdLivro";
            clnIdLivro.ReadOnly = true;
            clnIdLivro.Width = 250;
            // 
            // clnDataReserva
            // 
            clnDataReserva.FillWeight = 112.309647F;
            clnDataReserva.HeaderText = "Data da Reserva";
            clnDataReserva.Name = "clnDataReserva";
            clnDataReserva.ReadOnly = true;
            clnDataReserva.Width = 213;
            // 
            // clnDataDevolucao
            // 
            clnDataDevolucao.FillWeight = 112.309647F;
            clnDataDevolucao.HeaderText = "Data de Devolução";
            clnDataDevolucao.Name = "clnDataDevolucao";
            clnDataDevolucao.ReadOnly = true;
            clnDataDevolucao.Width = 213;
            // 
            // clnStatus
            // 
            clnStatus.FillWeight = 50.76142F;
            clnStatus.HeaderText = "Status";
            clnStatus.Name = "clnStatus";
            clnStatus.ReadOnly = true;
            clnStatus.Width = 95;
            // 
            // UscReservar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlMenu);
            Controls.Add(pnlFinalizarReserva);
            Controls.Add(lblReserva);
            Controls.Add(lblSubtitulo);
            Name = "UscReservar";
            Size = new Size(1054, 854);
            Load += UscReservar_Load;
            pnlFinalizarReserva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResevas).EndInit();
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblReserva;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlFinalizarReserva;
        private Guna.UI2.WinForms.Guna2DataGridView dgvResevas;
        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button btnPenalidades;
        private Guna.UI2.WinForms.Guna2Button btnReservas;
        private Guna.UI2.WinForms.Guna2Button btnMenuAdicionar;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnIdUsuario;
        private DataGridViewTextBoxColumn clnIdLivro;
        private DataGridViewTextBoxColumn clnDataReserva;
        private DataGridViewTextBoxColumn clnDataDevolucao;
        private DataGridViewTextBoxColumn clnStatus;
    }
}
