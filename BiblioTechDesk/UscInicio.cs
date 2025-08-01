﻿using System;
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
    public partial class UscInicio : UserControl
    {
        public UscInicio()
        {
            InitializeComponent();
        }

        private void UscInicio_Load(object sender, EventArgs e)
        {
            //Livros em destaque
            var livros = Livro.ObterLivrosEmDestaque();

            int contador = 0;

            flpDestaque.Controls.Clear();
            flpDestaque.MaximumSize = new Size(1054, 365);
            // detalhes panel

            foreach (var livro in livros)
            {
                Guna2Panel painel = new();
                painel.Width = 241;
                painel.Height = 352;
                painel.Margin = new Padding(3);

                Guna2PictureBox Picbox = new();
                Picbox.SizeMode = PictureBoxSizeMode.StretchImage;
                Picbox.Width = 220/*232*/;
                Picbox.Height = 296;
                Picbox.BorderRadius = 10;
                Picbox.Location = new Point(3, 3);

                using(MemoryStream ms = new MemoryStream(livro.Imagem))
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

                painel.Controls.Add(Picbox);
                painel.Controls.Add(LblDescricao);
                painel.Controls.Add(LblNome);

                flpDestaque.Controls.Add(painel);
            }

            flpMaisAdquiridos.Controls.Clear();
            var livrosMaisAdquiridos = Livro.ObterLivrosMaisAdquiridos();

            foreach(var livro in livrosMaisAdquiridos)
            {
                Guna2Panel painelAdquirido = new();
                painelAdquirido.Width = 195;
                painelAdquirido.Height = 269;
                painelAdquirido.Margin = new Padding(3);

                Guna2PictureBox picBoxAdquirido = new();
                picBoxAdquirido.SizeMode = PictureBoxSizeMode.StretchImage;
                picBoxAdquirido.Width = 181;
                picBoxAdquirido.Height = 220;
                picBoxAdquirido.BorderRadius = 10;
                picBoxAdquirido.Location = new Point(3, 3);

                using (MemoryStream ms = new MemoryStream(livro.Imagem))
                {
                    picBoxAdquirido.Image = Image.FromStream(ms);
                }

                Guna2HtmlLabel LblNomeAdquirido = new();
                LblNomeAdquirido.ForeColor = Color.Black;
                LblNomeAdquirido.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
                LblNomeAdquirido.Location = new Point(3, 224);
                LblNomeAdquirido.Text = livro.Nome;

                Guna2HtmlLabel LblDescricaoAdquirido = new();
                LblDescricaoAdquirido.ForeColor = Color.FromArgb(69, 69, 69);
                LblDescricaoAdquirido.MaximumSize = new Size(171, 19);
                LblDescricaoAdquirido.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
                LblDescricaoAdquirido.Location = new Point(3, 247);
                LblDescricaoAdquirido.Text = livro.Descricao;

                painelAdquirido.Controls.Add(LblDescricaoAdquirido);
                painelAdquirido.Controls.Add(LblNomeAdquirido);
                painelAdquirido.Controls.Add(picBoxAdquirido);

                flpMaisAdquiridos.Controls.Add(painelAdquirido);
            }


        }

        private void flpDestaque_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
