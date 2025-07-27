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
            var reservas = Reserva.ObterLista();

            int linha = 0;
            dgvResevas.Rows.Clear();
            foreach (var reserva in reservas)
            {
                dgvResevas.Rows.Add();
                dgvResevas.Rows[linha].Cells[0].Value = reserva.Id;
                dgvResevas.Rows[linha].Cells[1].Value = reserva.Usuario.Nome;
                dgvResevas.Rows[linha].Cells[2].Value = reserva.Livro.Nome;
                dgvResevas.Rows[linha].Cells[3].Value = reserva.DataReserva;
                dgvResevas.Rows[linha].Cells[4].Value = reserva.DataDevolucao;
                dgvResevas.Rows[linha].Cells[5].Value = reserva.Status;

                linha++;
            }
        }

        private void dgvResevas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvResevas.CurrentRow.Index!;
            int idReserva = Convert.ToInt32(dgvResevas.Rows[linha].Cells[0].Value);

            var reserva = Reserva.ObterPorId()
        }
    }
}
