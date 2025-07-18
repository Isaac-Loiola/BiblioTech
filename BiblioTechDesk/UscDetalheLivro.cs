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
using Guna.UI2.WinForms.Enums;

namespace BiblioTechDesk
{
    public partial class UscDetalheLivro : UserControl
    {
        public UscDetalheLivro()
        {
            InitializeComponent();

        }

        public static int idDoLivro;

        private void UscDetalheLivro_Load(object sender, EventArgs e)
        {
            var livro = Livro.ObterPorId(idDoLivro);

            //Exibição da imagem do livro!
            using (MemoryStream ms = new(livro.Imagem))
            {
                picCapaLivro.Image = Image.FromStream(ms);
            }

            lblValorDescricao.Text = livro.Descricao;
            lblNomeLivro.Text = livro.Nome;
            lblNomeEditora.Text = livro.Editora.Nome;
            lblNomeAutor.Text = livro.Autor.Nome;
            lblValorDimensao.Text = livro.Dimensao;
            lblValorDimensao.Text = livro.Genero.Nome;
            lblDataPublicacao.Text = Convert.ToString(livro.DataPublicacao);
        }

        private void lblSobreLivro_Click(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
