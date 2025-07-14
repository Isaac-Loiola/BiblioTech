using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechClass
{
    class Nivel
    { 
        public int Id { get; set; }
        public string Nome { get; set; }

        public Nivel()
        {

        }
        public Nivel(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
