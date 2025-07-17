using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechClass
{
    public class Usuario
    {
        
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public DateTime? DataNascimento { get; set; }
        public int? Status { get; set; }
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

        
        
        /// <summary>
        /// Método para Adicionar um usuario ao banco de dados!
        /// </summary>
        public void Adicionar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuarios_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spdata_nascimento", DataNascimento);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public static bool AtualizarStatus(int id, int status)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuarios_insert";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("spstatus", status);

            bool resultado = cmd.ExecuteNonQuery() > 0 ? true : false;

            cmd.Connection.Close();
            return resultado;
        }

        /// <summary>
        /// Método para atualizar um usuario!
        /// (Apenas a senha)
        /// </summary>
        /// <returns>booleano</returns>
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuarios_insert";
            cmd.Parameters.AddWithValue("spid",Id);
            cmd.Parameters.AddWithValue("spstatus", Senha);

            bool resultado = cmd.ExecuteNonQuery() > 0 ? true : false;

            cmd.Connection.Close();
            return resultado;
        }

        public static Usuario EfetuarLogin(string email, string senha)
        {
            Usuario usuario = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from usuarios where email = {email} and senha = {senha}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new
                    (
                          dr.GetInt32(0),
                          dr.GetString(1),
                          dr.GetString(2),
                          dr.GetString(3),
                          dr.GetDateTime(4),
                          dr.GetInt32(5)
                    );
            }
            dr.Close();
            cmd.Connection.Close();

            return usuario;
        }

        /// <summary>
        /// Método para Obter um objeto Usuario
        /// </summary>
        /// <param name="id">Id do usuario</param>
        /// <returns>Objeto Usuario</returns>
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
                          dr.GetInt32(0),
                          dr.GetString(1),
                          dr.GetString(2),
                          dr.GetString(3),
                          dr.GetDateTime(4),
                          dr.GetInt32(5)
                    );
            }
            dr.Close();
            cmd.Connection.Close();
            return usuario;
        }
    }
}
