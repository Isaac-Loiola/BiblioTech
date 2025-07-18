using BiblioTechClass;
using Guna.UI2.WinForms.Enums;
using NcMaster;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            if (txtNome.Text != string.Empty && txtEmailCadastro.Text != string.Empty && txtSenhaCadastro.Text != string.Empty)
            {
                Usuario usuario = new(txtNome.Text, txtEmailCadastro.Text, txtSenhaCadastro.Text, dtpDataNascimento.Value, 1);
                usuario.Adicionar();

                pnlEndereco.Visible = true;
                Program.UsuarioLogado = usuario;
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
            }

        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            if (txtNumero.Text != String.Empty && txtComplemento.Text != string.Empty)
            {
                Program.EnderecoUsuario.Usuario = Program.UsuarioLogado;
                Program.EnderecoUsuario.Adicionar();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
            }


            this.Hide();
            FrmPrincipal frmPrincipal = new();
            frmPrincipal.ShowDialog();
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

            if (txtCep.Text.Length == 8)
            {
                WebCEP webCEP = new(txtCep.Text);
                txtLogradouro.Text = webCEP.Lagradouro;

                if (txtEmailCadastro.Text.Length > 0)
                {
                    Program.EnderecoUsuario.Bairro = webCEP.Bairro;
                    Program.EnderecoUsuario.Cep = txtCep.Text;
                    Program.EnderecoUsuario.Cidade = webCEP.Cidade;
                    Program.EnderecoUsuario.Logradouro = webCEP.Lagradouro;
                    Program.EnderecoUsuario.Uf = webCEP.UF;
                    Program.EnderecoUsuario.Numero = txtNumero.Text;
                    Program.EnderecoUsuario.Complemento = txtComplemento.Text;
                }
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

            var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if (usuario.Id > 0)
            {
                this.Hide();
                FrmPrincipal frmPrincipal = new();
                frmPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou senha incorreto!");
            }
        }

        private void FrmAcesso_Load(object sender, EventArgs e)
        {

        }
    }
}
