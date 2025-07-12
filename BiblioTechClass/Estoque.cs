using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechClass
{
    public class Estoque
    {
        public Livro Livro { get; set; }
        public int Quantidade { get; set; }
        public int Disponiveis { get; set; }


        public Estoque()
        {

        }

        public Estoque(Livro livro, int quantidade, int disponiveis)
        {
            Livro = livro;
            Quantidade = quantidade;
            Disponiveis = disponiveis;
        }


        public Estoque ObterPorId(int idLivro)
        {
            Estoque estoque = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from estoques {idLivro}";
            var dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                estoque = new
                    (
                        Livro.ObterPorId(dr.GetInt32(0)),
                        dr.GetInt32(1),
                        dr.GetInt32(2)

                    );
            }
            dr.Close();
            cmd.Connection.Close();

            return estoque;
        }

        public List<Estoque> ObterLista()
        {
            List<Estoque> estoques = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from estoques";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                estoques.Add
                    (
                        new
                        (
                                Livro.ObterPorId(dr.GetInt32(0)),
                                dr.GetInt32(1),
                                dr.GetInt32(2)
                        )
                    );
            }
            dr.Close();
            cmd.Connection.Close();

            return estoques;
        }
    }
}
