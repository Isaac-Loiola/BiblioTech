using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTechClass
{
    public class Endereco
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        
        public Endereco()
        {

        }
        public Endereco(int id, Usuario usuario, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string tipo)
        {
            Id = id;
            Usuario = usuario;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        }

        public Endereco(Usuario usuario, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string tipo)
        {
            Usuario = usuario;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        }
        
        /// <summary>
        /// Método para adicionar um endereco ao banco de dados
        /// </summary>
        public void Adicionar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_enderecos_insert";
            cmd.Parameters.AddWithValue("spid_usuario", Usuario.Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        /// <summary>
        /// Método para obter um endereco de um usuario expecifico!
        /// </summary>
        /// <param name="idUsuario">id do usuario</param>
        /// <returns>Objeto Endereco</returns>
        public static Endereco ObterPorId(int idUsuario)
        {
            Endereco endereco = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from enderecos where id_usuario = {idUsuario}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                endereco = new
                    (
                        dr.GetInt32(0),
                        Usuario.ObterPorId(dr.GetInt32(1)),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(7),
                        dr.GetString(8),
                        dr.GetString(9)
                    );    
            }
            cmd.Connection.Close();

            return endereco;
        }
    }
}
