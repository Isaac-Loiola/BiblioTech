using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechClass
{
    public class ControleEstoque
    {
        public int Id { get; set; }
        public Livro Livro { get; set; }
        public string Movimento { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataMovimentacao { get; set; }

        public ControleEstoque()
        {

        }
        public ControleEstoque(int id, Livro livro, string movimento, int quantidade, DateTime dataMovimentacaoe)
        {
            Id = id;
            Livro = livro;
            Movimento = movimento;
            Quantidade = quantidade;
            DataMovimentacao = dataMovimentacaoe;
        }

        public ControleEstoque(Livro livro, string movimento, int quantidade)
        {
            Livro = livro;
            Movimento = movimento;
            Quantidade = quantidade;
        }

    }
}
