using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechClass
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }


        public Genero()
        {

        }
        public Genero(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public static List<Genero> ObterLista()
        {
            List<Genero> generos = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from generos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                generos.Add
                    (
                        new
                        (
                            dr.GetInt32(0),
                            dr.GetString(1)
                        )
                    );
            }
            dr.Close();
            cmd.Connection.Close();

            return generos;
        }

        public static Genero ObterPorId(int id)
        {
            Genero genero = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from generos where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                genero = new
                    (
                        dr.GetInt32(0),
                        dr.GetString(1)
                    );
            }
            dr.Close();
            cmd.Connection.Close();

            return genero;
        }
    }
}
