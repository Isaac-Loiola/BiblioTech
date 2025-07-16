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

namespace BiblioTechDesk
{
    public partial class UscGerenciadorLivro : UserControl
    {
        public UscGerenciadorLivro()
        {
            InitializeComponent();
        }

        private void UscGerenciadorLivro_Load(object sender, EventArgs e)
        {
            var editoras = Editora.ObterLista();
            cmbEditora.DataSource = editoras;
            cmbEditora.DisplayMember = "Nome";
            cmbEditora.ValueMember = "Id";

            var autores = Autor.ObterLista();
            cmbAutor.DataSource = autores;
            cmbAutor.DisplayMember = "Nome";
            cmbAutor.ValueMember = "Id";

            var generos = Genero.ObterLista();
            cmbGenero.DataSource = generos;
            cmbGenero.DisplayMember = "Nome";
            cmbGenero.ValueMember = "Id";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ofdObterCapa.Filter = "Imagens (*.jpg ; *.png) | *.jpg; *.png";
            if (ofdObterCapa.ShowDialog() == DialogResult.OK)
            {
                picCapaDoLivro.Image = Image.FromFile(ofdObterCapa.FileName);
            }
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
