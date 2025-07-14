using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechClass
{
    public class Log
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Periodo { get; set; }
        public int Atividade { get; set; }
        public Log(int id, Usuario usuario, DateTime periodo, int atividade)
        {
            Id = id;
            Usuario = usuario;
            Periodo = periodo;
            Atividade = atividade;
        }
        public Log( Usuario usuario, DateTime periodo, int atividade)
        {
            Usuario = usuario;
            Periodo = periodo;
            Atividade = atividade;
        }
        public Log(Usuario usuario, int atividade)
        {
            Usuario = usuario;
            Atividade = atividade;
        }

        /// <summary>
        /// Método para adicionar um log de um usuario especifico!
        /// </summary>
        public void AdicionarLog()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_log_usuario_insert";
            cmd.Parameters.AddWithValue("spid_usuario", Usuario.Id);
            cmd.Parameters.AddWithValue("spatividade", Atividade);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
    }
}
