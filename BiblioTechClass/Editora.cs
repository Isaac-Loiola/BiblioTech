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

        /// <summary>
        /// Método para adicionar uma editora no banco de dados@
        /// </summary>
        public void Adicionar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_editores_insert";

            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sppais", Pais);
            cmd.Parameters.AddWithValue("spdata_criacao", DataCriacao);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
    }
}
