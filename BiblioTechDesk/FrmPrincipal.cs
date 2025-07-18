using BiblioTechClass;
using Guna.UI2.WinForms;

namespace BiblioTechDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void ExibirNotificacao(string nomeLivro)
        {
            Guna2MessageDialog mdConcluido = new();
            mdConcluido.Style = MessageDialogStyle.Light;

            mdConcluido.Parent = this;

            mdConcluido.Show($"A reserva do livro {nomeLivro} foi concluída com sucesso, {Program.UsuarioLogado.Nome}!", "Tudo certo!");
        }

        public void ExibirNotificacaoCamposObrigatorios()
        {
            Guna2MessageDialog mdCamposObrigatorios = new();
            mdCamposObrigatorios.Style = MessageDialogStyle.Light;
            mdCamposObrigatorios.Icon = MessageDialogIcon.Warning;

            mdCamposObrigatorios.Parent = this;
            mdCamposObrigatorios.Caption = "Ops...";
            mdCamposObrigatorios.Show($"Todos os campos devem ser preenchidos!");
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
            Log logSaida = new(Program.UsuarioLogado, 0);
            logSaida.AdicionarLog();

            Application.Exit();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            UscReservar uscReservar = new();
            AssociarUserControla(uscReservar);
            uscReservar.Load += (sender, e) =>
            {

            };
        }
    }
}
