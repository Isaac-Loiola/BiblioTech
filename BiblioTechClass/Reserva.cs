using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechClass
{
    public class Reserva
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataReserva { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Status { get; set; }
        public Reserva()
        {

        }
        public Reserva(int id, Usuario usuario, Livro livro, DateTime dataReserva, DateTime dataDevolucao, string status)
        {
            Id = id;
            Usuario = usuario;
            Livro = livro;
            DataReserva = dataReserva;
            DataDevolucao = dataDevolucao;
            Status = status;
        }
        public Reserva( Usuario usuario, Livro livro,DateTime dataDevolucao)
        {
            Usuario = usuario;
            Livro = livro;
            DataDevolucao = dataDevolucao;
        }
        public Reserva(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Método para inserir uma reserva ao banco de dados!
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_reservas_insert";
            cmd.Parameters.AddWithValue("spid_usuario", Usuario.Id);
            cmd.Parameters.AddWithValue("spid_livro", Livro.Id);
            cmd.Parameters.AddWithValue("spdata_devolucao", DataDevolucao);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        /// <summary>
        /// Método para finalizar uma reserva!
        /// </summary>
        /// <returns>booleano</returns>
        public bool Finalizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_reservas_finalizar";
            cmd.Parameters.AddWithValue("spid", Id);

            bool resultado = cmd.ExecuteNonQuery() > 0 ? true : false;
            cmd.Connection.Close();

            return resultado; 
        }

        /// <summary>
        /// Método para obter um objeto Reserva por id
        /// </summary>
        /// <param name="id">id da Reserva</param>
        /// <returns>Objeto Reserva</returns>
        public static Reserva ObterPorId(int idLivro, int idUsuario)
        {
            Reserva reserva = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from reservas where id_usuario = {idUsuario} and id_livro = {idLivro} order by  data_reserva desc limit 1";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                reserva = new
                    (
                        dr.GetInt32(0),
                        Usuario.ObterPorId(dr.GetInt32(1)),
                        Livro.ObterPorId(dr.GetInt32(2)),
                        dr.GetDateTime(3),
                        dr.GetDateTime(4),
                        dr.GetString(5)
                    );
            }
            dr.Close();
            cmd.Connection.Close();

            return reserva;
        }

        public static List<Reserva> ObterLista()
        {
            List<Reserva> reservas = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from reservas";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                reservas.Add
                    (
                        new
                        (
                            dr.GetInt32(0),
                            Usuario.ObterPorId(dr.GetInt32(1)),
                            Livro.ObterPorId(dr.GetInt32(2)),
                            dr.GetDateTime(3),
                            dr.GetDateTime(4),
                            dr.GetString(5)
                        )
                    );
            }
                   
                    
            dr.Close();
            cmd.Connection.Close();

            return reservas;
        }
    }
}
