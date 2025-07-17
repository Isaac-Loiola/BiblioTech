using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTechDesk
{
    public partial class FrmAcesso : Form
    {
        public FrmAcesso()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            pnlCadastro.Visible = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            pnlEndereco.Visible = true;
        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal frmPrincipal = new();
            frmPrincipal.ShowDialog();
        }
    }
}
