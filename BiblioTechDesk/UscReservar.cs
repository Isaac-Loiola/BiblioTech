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
using System.Security.Cryptography.X509Certificates;

namespace BiblioTechDesk
{
    public partial class UscReservar : UserControl
    {
        public UscReservar()
        {
            InitializeComponent();
        }
        
        private void ExibirDetalhesDoLivro(int idLivro)
        {
            UscDetalheLivro.idDoLivro = idLivro;

            this.Controls.Clear();
            UscDetalheLivro uscDetalheLivro = new();
            uscDetalheLivro.Dock = DockStyle.Fill;
            this.Controls.Add(uscDetalheLivro);

        }

        private void UscReservar_Load(object sender, EventArgs e)
        {
            var livros = Livro.ObterLista();

            foreach (var livro in livros)
            {
                Guna2Panel painel = new();
                painel.Width = 241;
                painel.Height = 382/*352*/;
                painel.Margin = new Padding(3);

                Guna2PictureBox Picbox = new();
                Picbox.SizeMode = PictureBoxSizeMode.StretchImage;
                Picbox.Width = 220/*232*/;
                Picbox.Height = 296;
                Picbox.BorderRadius = 10;
                Picbox.Location = new Point(3, 3);

                using (MemoryStream ms = new MemoryStream(livro.Imagem))
                {
                    Picbox.Image = Image.FromStream(ms);
                }

                Guna2HtmlLabel LblNome = new();
                LblNome.ForeColor = Color.Black;
                LblNome.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                LblNome.Location = new Point(3, 305);
                LblNome.Text = livro.Nome;

                Guna2HtmlLabel LblDescricao = new();
                LblDescricao.ForeColor = Color.FromArgb(69, 69, 69);
                LblDescricao.MaximumSize = new Size(219, 23);
                LblDescricao.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                LblDescricao.Location = new Point(3, 328);
                LblDescricao.Text = livro.Descricao;

                Guna2HtmlLabel lblId = new();
                lblId.ForeColor = Color.Black;
                lblId.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                lblId.Location = new Point(0,350);
                lblId.Visible = false;
                lblId.Text = livro.Id.ToString();

                painel.MouseEnter += ( sender,  e) =>
                {
                    LblNome.MouseClick += (sender, e) =>
                    {
                        ExibirDetalhesDoLivro(Convert.ToInt32(lblId.Text));
                    };

                    Picbox.MouseClick += (sender, e) =>
                    {
                        ExibirDetalhesDoLivro(Convert.ToInt32(lblId.Text));

                    };

                    painel.MouseClick += (sender, e) =>
                    {
                        ExibirDetalhesDoLivro(Convert.ToInt32(lblId.Text));

                    };

                    LblDescricao.MouseClick += (sender, e) =>
                    {
                        ExibirDetalhesDoLivro(Convert.ToInt32(lblId.Text));

                    };

                };

                painel.Controls.Add(Picbox);
                painel.Controls.Add(LblDescricao);
                painel.Controls.Add(LblNome);
                painel.Controls.Add(lblId);

                flpLivros.Controls.Add(painel);
            }
        }
    }
}
