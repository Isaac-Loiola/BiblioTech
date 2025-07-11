using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechClass
{
    public class Editora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Pais { get; set; }
        public DateTime DataCriacao { get; set; }

        public Editora()
        {
            
        }
        public Editora(int id, string nome, string pais, DateTime dataCriacao)
        {
            Id = id;
            Nome = nome;
            Pais = pais;
            DataCriacao = dataCriacao;
        }


        public Editora(string nome, string pais, DateTime dataCriacao)
        {
            Nome = nome;
            Pais = pais;
            DataCriacao = dataCriacao;
        }


    }
}
