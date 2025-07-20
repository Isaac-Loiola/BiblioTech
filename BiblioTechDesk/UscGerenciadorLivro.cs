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

            btnAdicionar.FillColor = Color.White;
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
            byte[] imBytes;
            MemoryStream ms = new();
            picCapaDoLivro.Image.Save(ms, picCapaDoLivro.Image.RawFormat);
            imBytes = ms.ToArray();

            if (txtNome.Text != string.Empty && txtDimensao.Text != string.Empty && txtDescricao.Text != string.Empty &&
                cmbAutor.Text != string.Empty && cmbEditora.Text != string.Empty && cmbGenero.Text != string.Empty)
            {
                Livro livro = new
                    (
                        txtNome.Text,
                        Autor.ObterPorId(Convert.ToInt32(cmbAutor.SelectedValue)),
                        Editora.ObterPorId(Convert.ToInt32(cmbEditora.SelectedValue)),
                        txtDescricao.Text,
                        txtDimensao.Text,
                        Genero.ObterPorId(Convert.ToInt32(cmbGenero.SelectedValue)),
                        dtpDataPublicacao.Value,
                        imBytes
                    );

                livro.Adicionar();

                ControleEstoque controleEstoque = new(livro, "entrada", Convert.ToInt32(nudQuantidade.Value));
                controleEstoque.Adicionar();
            }
            else
            {
                var frmprincipal = Application.OpenForms["FrmPrincipal"] as FrmPrincipal;
                frmprincipal.ExibirNotificacaoCamposObrigatorios();
            }
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            btnMenuAdicionar.FillColor = Color.FromArgb(247, 247, 247);
            btnReservas.FillColor = Color.White;

            pnlReservas.Visible = true;
            var reservas = Reserva.ObterLista();
            int contador = 0;

            foreach(var reserva in reservas)
            {
                dgvReservas.Rows.Add();
                dgvReservas.Rows[contador].Cells[0].Value = reserva.Id;
                dgvReservas.Rows[contador].Cells[1].Value = reserva.Usuario.Id;
                dgvReservas.Rows[contador].Cells[2].Value = reserva.Livro.Id;
                dgvReservas.Rows[contador].Cells[3].Value = reserva.DataReserva.Date;
                dgvReservas.Rows[contador].Cells[4].Value = reserva.DataDevolucao;
                dgvReservas.Rows[contador].Cells[5].Value = reserva.Status;

                contador++;
            }
        }

        private void pnlReservas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
