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
        public bool Atividade { get; set; }
        public Log(int id, Usuario usuario, DateTime periodo, bool atividade)
        {
            Id = id;
            Usuario = usuario;
            Periodo = periodo;
            Atividade = atividade;
        }
        public Log( Usuario usuario, DateTime periodo, bool atividade)
        {
            Usuario = usuario;
            Periodo = periodo;
            Atividade = atividade;
        }
        public Log(Usuario usuario, bool atividade)
        {
            Usuario = usuario;
            Atividade = atividade;
        }
    }
}
