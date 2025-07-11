using System;
using System.Collections.Generic;
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
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Tipo { get; set; }
        
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
            Tipo = tipo;
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
            Tipo = tipo;
        }

    }
}
