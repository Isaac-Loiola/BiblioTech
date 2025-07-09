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

        /// <summary>
        /// Método para adicionar livros no estoque 
        /// </summary>
        public void Adicionar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_controle_estoque";
            cmd.Parameters.AddWithValue("spid_livro", Livro.Id);
            cmd.Parameters.AddWithValue("spmovimento", Movimento);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }


        /// <summary>
        /// Lista todos os movimentos da tabela controle de estoque
        /// </summary>
        /// <returns>lista ControleEstoque</returns>
        public List<ControleEstoque> ObterLista()
        {
            List<ControleEstoque> controle = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from sp_controle_estoque";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                controle.Add
                    (
                        new
                        (
                            dr.GetInt32(0),
                            Livro.ObterPorId(dr.GetInt32(1)),
                            dr.GetString(2),
                            dr.GetInt32(3),
                            dr.GetDateTime(4)
                        )
                    );
            }
            dr.Close();
            cmd.Connection.Close();

            return controle;
        }
    }
}
