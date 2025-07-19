using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioTechClass;
using Guna.UI2.WinForms;

namespace BiblioTechDesk
{
    public partial class UscLivrosUsuario : UserControl
    {
        public UscLivrosUsuario()
        {
            InitializeComponent();
        }

        private void UscLivrosUsuario_Load(object sender, EventArgs e)
        {
            btnMeusLivros.FillColor = Color.White;
            btnDevolver.FillColor = Color.FromArgb(247, 247, 247);

            flpLivrosUsuario.Controls.Clear();
            var livrosDoUsuario = Livro.ObterLivrosDoUsuario(Convert.ToInt32(Program.UsuarioLogado.Id));

            foreach (var livro in livrosDoUsuario)
            {
                Guna2Panel painelAdquirido = new();
                painelAdquirido.Width = 195;
                painelAdquirido.Height = 289;
                painelAdquirido.Margin = new Padding(3);

                Guna2PictureBox picBoxAdquirido = new();
                picBoxAdquirido.SizeMode = PictureBoxSizeMode.StretchImage;
                picBoxAdquirido.Width = 181;
                picBoxAdquirido.Height = 230;
                picBoxAdquirido.BorderRadius = 10;
                picBoxAdquirido.Location = new Point(3, 3);

                using (MemoryStream ms = new MemoryStream(livro.Imagem))
                {
                    picBoxAdquirido.Image = Image.FromStream(ms);
                }

                Guna2HtmlLabel LblNomeAdquirido = new();
                LblNomeAdquirido.ForeColor = Color.Black;
                LblNomeAdquirido.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
                LblNomeAdquirido.Location = new Point(3, 234);
                LblNomeAdquirido.Text = livro.Nome;

                Guna2HtmlLabel LblDescricaoAdquirido = new();
                LblDescricaoAdquirido.ForeColor = Color.FromArgb(69, 69, 69);
                LblDescricaoAdquirido.MaximumSize = new Size(171, 19);
                LblDescricaoAdquirido.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
                LblDescricaoAdquirido.Location = new Point(3, 257);
                LblDescricaoAdquirido.Text = livro.Descricao;

                painelAdquirido.Controls.Add(LblDescricaoAdquirido);
                painelAdquirido.Controls.Add(LblNomeAdquirido);
                painelAdquirido.Controls.Add(picBoxAdquirido);

                flpLivrosUsuario.Controls.Add(painelAdquirido);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            btnMeusLivros.FillColor = Color.FromArgb(247, 247, 247);
            btnDevolver.FillColor = Color.White;

            flpLivrosUsuario.Controls.Clear();
            var livrosDoUsuarioEmAberto = Livro.ObterLivrosEmAbertoDoUsuario(Convert.ToInt32(Program.UsuarioLogado.Id));

            foreach (var livro in livrosDoUsuarioEmAberto)
            {
                Guna2Panel painelAdquirido = new();
                painelAdquirido.Width = 195;
                painelAdquirido.Height = 289;
                painelAdquirido.Margin = new Padding(3);

                Guna2PictureBox picBoxAdquirido = new();
                picBoxAdquirido.SizeMode = PictureBoxSizeMode.StretchImage;
                picBoxAdquirido.Width = 181;
                picBoxAdquirido.Height = 230;
                picBoxAdquirido.BorderRadius = 10;
                picBoxAdquirido.Location = new Point(3, 3);

                using (MemoryStream ms = new MemoryStream(livro.Imagem))
                {
                    picBoxAdquirido.Image = Image.FromStream(ms);
                }

                Guna2HtmlLabel LblNomeAdquirido = new();
                LblNomeAdquirido.ForeColor = Color.Black;
                LblNomeAdquirido.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
                LblNomeAdquirido.Location = new Point(3, 234);
                LblNomeAdquirido.Text = livro.Nome;

               

                Guna2Panel pnlSituacaoDaDevolucao = new();
                pnlSituacaoDaDevolucao.Width = 103;
                pnlSituacaoDaDevolucao.Height = 10;
                pnlSituacaoDaDevolucao.BorderRadius = 2;
                pnlSituacaoDaDevolucao.Location = new Point(80, 260);

                //pnlSituacaoDaDevolucao.Location = new Point(100, 259);

                var reserva = Reserva.ObterPorId(livro.Id, Convert.ToInt32(Program.UsuarioLogado.Id));
                var prazoMedio = DateTime.Today.AddDays(7);

                var dataDevolucao = reserva.DataDevolucao;
                
                if(dataDevolucao >= DateTime.Today &&  dataDevolucao <= prazoMedio)
                {
                    pnlSituacaoDaDevolucao.FillColor = Color.FromArgb( 255,215 ,0);
                }
                else if(dataDevolucao == DateTime.Today || DateTime.Today > dataDevolucao)
                {
                    pnlSituacaoDaDevolucao.FillColor = Color.FromArgb(255, 69, 0);
                }
                else
                {
                    pnlSituacaoDaDevolucao.FillColor = Color.FromArgb(124, 252, 0);
                }

                Guna2HtmlLabel lblDataDevolucao = new();
                lblDataDevolucao.ForeColor = Color.FromArgb(69, 69, 69);
                lblDataDevolucao.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
                lblDataDevolucao.Location = new Point(3, 257);
                lblDataDevolucao.Text = reserva.DataDevolucao.Date.ToString("dd/MM/yyyyy");

                painelAdquirido.Controls.Add(lblDataDevolucao);
                painelAdquirido.Controls.Add(pnlSituacaoDaDevolucao);
                painelAdquirido.Controls.Add(LblNomeAdquirido);
                painelAdquirido.Controls.Add(picBoxAdquirido);

                flpLivrosUsuario.Controls.Add(painelAdquirido);
            }
        }

        private void btnMeusLivros_Click(object sender, EventArgs e)
        {
            UscLivrosUsuario_Load(sender, e);
        }
    }
}
