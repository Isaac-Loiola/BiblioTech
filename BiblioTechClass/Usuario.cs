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
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Status { get; set; }
        public Usuario()
        {

        }
        public Usuario(int id, string nome, string email, string senha, DateTime dataNascimento, int status)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            DataNascimento = dataNascimento;
            Status = status;
        }

        public Usuario(string nome, string email, string senha, DateTime dataNascimento, int status)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            DataNascimento = dataNascimento;
        }
        public Usuario(int id, int status)
        {
            Id = id;
            Status = status;
        }
        public Usuario(int id, string senha)
        {
            Id = id;
            Senha = senha;
        }

        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new
                    (
                       
                    );
            }

            return usuario;
        }
    }
}
