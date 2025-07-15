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
        public Reserva( Usuario usuario, Livro livro, DateTime dataReserva, DateTime dataDevolucao, string status)
        {
            Usuario = usuario;
            Livro = livro;
            DataReserva = dataReserva;
            DataDevolucao = dataDevolucao;
            Status = status;
        }
        
    }
}
