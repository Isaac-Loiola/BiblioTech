using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechClass
{
    public class AvaliacaoLivro
    {
        public int Id { get; set; }
        public Livro Livro { get; set; }
        public int Nivel { get; set; }
        public int NivelTotal { get; set; }
        public int AvaliacaoTotal { get; set; }
        public AvaliacaoLivro()
        {

        }
        public AvaliacaoLivro(int id, Livro livro, int nivel)
        {
            Id = id;
            Livro = livro;
            Nivel = nivel;
        }
        public AvaliacaoLivro(int nivelTotal, int avaliacaoTotal)
        {
            NivelTotal = nivelTotal;
            AvaliacaoTotal = avaliacaoTotal;
        }

        /// <summary>
        /// Método para adicionar uma avaliação de um livro!
        /// </summary>
        public void Avaliar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_avaliacao_livro";
            cmd.Parameters.AddWithValue("spid_livro", Livro.Id);
            cmd.Parameters.AddWithValue("spnivel", Nivel);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        /// <summary>
        /// Método para obter avaliações de um livro 
        /// </summary>
        /// <param name="idLivro">Id do livro</param>
        /// <returns>Lista de avaliações!</returns>
        public static List<AvaliacaoLivro> ObterLista(int idLivro)
        {
            List<AvaliacaoLivro> avaliacoes = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from avaliacao_livro where id_livro = {idLivro}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                avaliacoes.Add
                    (
                        new
                        (
                            dr.GetInt32(0),
                            Livro.ObterPorId(dr.GetInt32(1)),
                            dr.GetInt32(2)
                        )
                    );

            }
            dr.Close();
            cmd.Connection.Close();

            return avaliacoes;
        }


        /// <summary>
        /// Método para obter todas as avaliacoes de um livro
        /// </summary>
        /// <param name="id_livro"></param>
        public void ObterAvaliacoesTotais(int id_livro)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select count(nivel) from avaliacao_livro;";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                NivelTotal = dr.GetInt32(0);
                AvaliacaoTotal = dr.GetInt32(1);
            }
            dr.Close();
            cmd.Connection.Close();
        }
        
    }
}
