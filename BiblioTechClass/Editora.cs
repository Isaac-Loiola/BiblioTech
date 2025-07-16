using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        /// <summary>
        /// Método para obter lista de todas editoras
        /// </summary>
        /// <returns>lista do tipo Editora</returns>
        public static List<Editora> ObterLista()
        {
            List<Editora> editoras = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from editoras";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                editoras.Add
                    (
                        new
                        (
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetDateTime(3)
                        )
                    );
            }
            dr.Close();
            cmd.Connection.Close();

            return editoras;
        }


        /// <summary>
        /// Método para obter um objeto Editora por um id
        /// </summary>
        /// <param name="id"> id da editora</param>
        /// <returns>Objeto Editora</returns>
        public static Editora ObterPorId(int id)
        {
            Editora editora = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from editoras where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                editora = new
                    (
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetDateTime(3)
                    );
            }
            cmd.Connection.Close();
            
            return editora;
        }
    }
}
