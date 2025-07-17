namespace BiblioTechDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        public void AssociarUserControla(UserControl userControl)
        {
            pnlInicio.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlInicio.Controls.Add(userControl);
        }

        private void pnlInicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            UscInicio uscInicio = new();

            AssociarUserControla(uscInicio);
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            UscGerenciadorLivro uscGerenciadorLivro = new();
            AssociarUserControla(uscGerenciadorLivro);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            UscReservar uscReservar = new();
            AssociarUserControla(uscReservar);
        }
    }
}
