using System;
using System.Collections.Generic;
using System.Linq;
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
        public Penalidade(Usuario usuario, string tipo)
        {
            Usuario = usuario;
            Tipo = tipo;
        }

        public Penalidade ObterPorId(int idUsuario)
        {
            Penalidade penalidade = new();



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

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
    }
}
