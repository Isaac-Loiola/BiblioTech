using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
