using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechClass
{
    public class AvaliacaoLivro
    {
        public Livro Livro { get; set; }
        public int Nivel { get; set; }

        public AvaliacaoLivro(Livro livro, int nivel)
        {
            Livro = livro;
            Nivel = nivel;
        }

    }
}
