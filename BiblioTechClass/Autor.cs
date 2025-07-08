using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechClass
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimennto { get; set; }
        public string Pais { get; set; }
        public string Cidade { get; set; }

        public Autor(int id, string nome, DateTime dataNascimennto, string pais, string cidade)
        {
            Id = id;
            Nome = nome;
            DataNascimennto = dataNascimennto;
            Pais = pais;
            Cidade = cidade;
        }

        public Autor(string nome, DateTime dataNascimennto, string pais, string cidade)
        {
            Nome = nome;
            DataNascimennto = dataNascimennto;
            Pais = pais;
            Cidade = cidade;
        }

        public void Adicionar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_autores_insert";

            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spdata_nascimento", DataNascimennto);
            cmd.Parameters.AddWithValue("sppais", Pais);
            cmd.Parameters.AddWithValue("spcidade_nascimento", Cidade);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
