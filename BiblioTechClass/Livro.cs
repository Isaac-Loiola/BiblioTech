using Microsoft.VisualBasic;
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
        public Stream Imagem { get; set; }
        
        public Livro()
        {

        }
        public Livro(int id, string nome, Autor autor, Editora editora, string descricao, string dimensao, Genero genero, DateTime dataPublicacao, Stream imagem)
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
        public Livro( string nome, Autor autor, Editora editora, string descricao, string dimensao, Genero genero, DateTime dataPublicacao, Stream imagem)
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

        /// <summary>
        /// Método para adiconar um livro ao banco de dados!
        /// </summary>
        public void Adicionar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_livros_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spid_autor", Autor.Id);
            cmd.Parameters.AddWithValue("spid_editora", Editora.Id);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spdimensao", Dimensao);
            cmd.Parameters.AddWithValue("spid_genero", Genero.Id);  
            cmd.Parameters.AddWithValue("spdata_pub", DataPublicacao);
            cmd.Parameters.AddWithValue("spimagem", Imagem);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }


        /// <summary>
        /// Método para obter um objeto Usuario
        /// </summary>
        /// <param name="id">id do livro</param>
        /// <returns>Objeto Livro</returns>
        public static Livro ObterPorId(int id)
        {
            Livro livro = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from livros where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                livro = new
                    (
                        dr.GetInt32(0),
                        dr.GetString(1),
                        Autor.ObterPorId(dr.GetInt32(2)),
                        Editora.ObterPorId(dr.GetInt32(3)),
                        dr.GetString(4),
                        dr.GetString(5),
                        Genero.ObterPorId(dr.GetInt32(6)),
                        dr.GetDateTime(7),
                        dr.GetStream(8)
                    );
            }
            dr.Close();
            cmd.Connection.Close();

            return livro;
        }

        /// <summary>
        /// Método para obter uma lista de todos os livros
        /// </summary>
        /// <returns>Lista de objeto Livro</returns>
        public static List<Livro> ObterLista()
        {
            List<Livro> livros = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from livros";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                livros.Add
                    (
                        new
                        (
                            dr.GetInt32(0),
                            dr.GetString(1),
                            Autor.ObterPorId(dr.GetInt32(2)),
                            Editora.ObterPorId(dr.GetInt32(3)),
                            dr.GetString(4),
                            dr.GetString(5),
                            Genero.ObterPorId(dr.GetInt32(6)),
                            dr.GetDateTime(7),
                            dr.GetStream(8)
                        )
                    );
               
            }
            dr.Close();
            cmd.Connection.Close();

            return livros;
        }
    }
}
