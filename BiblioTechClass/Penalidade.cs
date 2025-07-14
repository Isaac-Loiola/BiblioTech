using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechClass
{
    class Penalidade
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public string Tipo { get; set; }
        public string Status { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public Penalidade()
        {

        }
        public Penalidade(int id, Usuario usuario, string tipo, string status, DateTime dataInicio, DateTime dataFim)
        {
            Id = id;
            Usuario = usuario;
            Tipo = tipo;
            Status = status;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }

        public Penalidade(int id,string status,DateTime dataFim)
        {
            Id = id;
            Status = status;
            DataFim = dataFim;
        }
        public Penalidade(Usuario usuario, string tipo, DateTime datafim)
        {
            Usuario = usuario;
            Tipo = tipo;
            DataFim = datafim;
        }


        /// <summary>
        /// Método para obter uma penalidade em aberto de um usuario expecifico
        /// </summary>
        /// <param name="idUsuario">id do usuario</param>
        /// <returns>Objeto Penalidade</returns>
        public Penalidade ObterPorId(int idUsuario)
        {
            Penalidade penalidade = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from penalidades where id_usuario = {idUsuario} and status = 'aberta'";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                penalidade = new
                    (
                        dr.GetInt32(0),
                        Usuario.ObterPorId(dr.GetInt32(1)),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetDateTime(4),
                        dr.GetDateTime(5)
                    );
            }
            dr.Close();
            cmd.Connection.Close();

            return penalidade;
        }

        /// <summary>
        /// Método para inserir uma penalidade para um usuario expecifico
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_penalidades_insert";
            cmd.Parameters.AddWithValue("spid_usuario", Usuario.Id);
            cmd.Parameters.AddWithValue("sptipo", Tipo);
            cmd.Parameters.AddWithValue("spdata_fim", DataFim);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        /// <summary>
        /// Método para finalizar uma penalidade!
        /// </summary>
        public void Finalizar()
        {
            Penalidade penalidade = new();

            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_penalidades_update";
            cmd.Parameters.AddWithValue("spid", Id);

            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                penalidade = new
                    (
                        Id = dr.GetInt32(0),
                        Usuario = Usuario.ObterPorId(dr.GetInt32(1)),
                        Tipo = dr.GetString(2),
                        Status = dr.GetString(3),
                        DataInicio = dr.GetDateTime(4),
                        DataFim = dr.GetDateTime(5)
                    );
            }
            dr.Close();
            cmd.Connection.Close();
        }
    }
}
