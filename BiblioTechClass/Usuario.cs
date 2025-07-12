using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechClass
{
    public class Usuario
    {
        public int Id { get; set; }

        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();
        }
    }
}
