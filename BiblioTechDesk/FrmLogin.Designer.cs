namespace BiblioTechDesk
{
    partial class FrmLogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblAjuda = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogar = new Guna.UI2.WinForms.Guna2Button();
            lblCadastro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblOu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(30, 0);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(146, 72);
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 10;
            txtEmail.CustomizableEdges = customizableEdges3;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(213, 218, 223);
            txtEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(130, 130, 130);
            txtEmail.HoverState.BorderColor = Color.FromArgb(213, 218, 223);
            txtEmail.Location = new Point(532, 378);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderForeColor = Color.FromArgb(130, 130, 130);
            txtEmail.PlaceholderText = "seu.email@email.com";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtEmail.Size = new Size(400, 40);
            txtEmail.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            guna2HtmlLabel1.IsSelectionEnabled = false;
            guna2HtmlLabel1.Location = new Point(697, 283);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(71, 39);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "Login";
            // 
            // lblAjuda
            // 
            lblAjuda.BackColor = Color.Transparent;
            lblAjuda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAjuda.IsSelectionEnabled = false;
            lblAjuda.Location = new Point(635, 328);
            lblAjuda.Name = "lblAjuda";
            lblAjuda.Size = new Size(194, 23);
            lblAjuda.TabIndex = 2;
            lblAjuda.Text = "Utilize o  email cadastrado.";
            lblAjuda.Click += guna2HtmlLabel2_Click;
            // 
            // txtSenha
            // 
            txtSenha.BorderRadius = 10;
            txtSenha.CustomizableEdges = customizableEdges5;
            txtSenha.DefaultText = "";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(213, 218, 223);
            txtSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(130, 130, 130);
            txtSenha.HoverState.BorderColor = Color.FromArgb(213, 218, 223);
            txtSenha.Location = new Point(532, 436);
            txtSenha.Margin = new Padding(4);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderForeColor = Color.FromArgb(130, 130, 130);
            txtSenha.PlaceholderText = "senha";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSenha.Size = new Size(400, 40);
            txtSenha.TabIndex = 1;
            // 
            // btnLogar
            // 
            btnLogar.BorderRadius = 10;
            btnLogar.CustomizableEdges = customizableEdges7;
            btnLogar.DisabledState.BorderColor = Color.DarkGray;
            btnLogar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogar.FillColor = Color.Black;
            btnLogar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLogar.ForeColor = Color.White;
            btnLogar.Location = new Point(532, 492);
            btnLogar.Name = "btnLogar";
            btnLogar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnLogar.Size = new Size(400, 40);
            btnLogar.TabIndex = 3;
            btnLogar.Text = "Logar";
            // 
            // lblCadastro
            // 
            lblCadastro.BackColor = Color.Transparent;
            lblCadastro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCadastro.IsSelectionEnabled = false;
            lblCadastro.Location = new Point(702, 555);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(87, 23);
            lblCadastro.TabIndex = 2;
            lblCadastro.Text = "cadastre-se";
            lblCadastro.Click += guna2HtmlLabel2_Click;
            // 
            // lblOu
            // 
            lblOu.BackColor = Color.Transparent;
            lblOu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblOu.ForeColor = Color.FromArgb(130, 130, 130);
            lblOu.IsSelectionEnabled = false;
            lblOu.Location = new Point(676, 555);
            lblOu.Name = "lblOu";
            lblOu.Size = new Size(22, 23);
            lblOu.TabIndex = 2;
            lblOu.Text = "ou";
            lblOu.Click += guna2HtmlLabel2_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1464, 861);
            ControlBox = false;
            Controls.Add(btnLogar);
            Controls.Add(lblOu);
            Controls.Add(lblCadastro);
            Controls.Add(lblAjuda);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(guna2PictureBox1);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAjuda;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2Button btnLogar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCadastro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOu;
    }
}