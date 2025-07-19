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

            flpMeusLivros.Controls.Clear();
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

                flpMeusLivros.Controls.Add(painelAdquirido);
            }
        }
    }
}
