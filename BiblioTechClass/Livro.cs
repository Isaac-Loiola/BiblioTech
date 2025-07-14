using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechClass
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Autor Autor { get; set; }
        public Editora Editora { get; set; }
        public string Descricao { get; set; }
        public string Dimensao { get; set; }
        public Genero Genero { get; set; }
        public DateTime DataPublicacao { get; set; }
        public byte[] Imagem { get; set; }
        
        public Livro()
        {

        }
        public Livro(int id, string nome, Autor autor, Editora editora, string descricao, string dimensao, Genero genero, DateTime dataPublicacao, byte[] imagem)
        {
            Id = id;
            Nome = nome;
            Autor = autor;
            Editora = editora;
            Descricao = descricao;
            Dimensao = dimensao;
            Genero = genero;
            DataPublicacao = dataPublicacao;
            Imagem = imagem;
        }
        public Livro( string nome, Autor autor, Editora editora, string descricao, string dimensao, Genero genero, DateTime dataPublicacao, byte[] imagem)
        {
            Nome = nome;
            Autor = autor;
            Editora = editora;
            Descricao = descricao;
            Dimensao = dimensao;
            Genero = genero;
            DataPublicacao = dataPublicacao;
            Imagem = imagem;
        }

        public static Livro ObterPorId(int id)
        {
            Livro livro = new();


            return livro;
        }
    }
}
