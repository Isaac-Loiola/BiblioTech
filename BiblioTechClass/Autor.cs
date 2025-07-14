using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public Autor()
        {

        }

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

        public static Autor ObterPorId(int id)
        {
            Autor autor = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from autores where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                autor = new
                    (
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetDateTime(2),
                        dr.GetString(3),
                        dr.GetString(4)
                    );   
            }
            cmd.Connection.Close();

            return autor;
        }

        public List<Autor> ObterLista()
        {
            List<Autor> autores = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from autores";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                autores.Add
                    (
                        new
                        (
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetDateTime(2),
                            dr.GetString(3),
                            dr.GetString(4)
                        )
                    );
                    
            }
            dr.Close();
            cmd.Connection.Close();
            
            return autores;
        }
    }
}
