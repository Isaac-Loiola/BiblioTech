using System;
using System.Net.Http;
using System.Text.Json;

namespace NcMaster
{
    public class WebViaCEP
    {
        #region "Variáveis"
        string _uf = "";
        string _cidade = "";
        string _bairro = "";
        string _tipo_lagradouro = "";
        string _lagradouro = "";
        string _resultado = "0";
        string _resultato_txt = "CEP não encontrado";
        #endregion

        #region "Propriedades"
        public string UF => _uf;
        public string Cidade => _cidade;
        public string Bairro => _bairro;
        public string TipoLagradouro => _tipo_lagradouro;
        public string Lagradouro => _lagradouro;
        public string Resultado => _resultado;
        public string ResultadoTXT => _resultato_txt;
        #endregion

        #region "Construtor"
        public WebViaCEP(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep) || cep.Length != 8)
            {
                _resultato_txt = "CEP inválido";
                return;
            }

            try
            {
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Add("User-Agent", "BiblioTech");

                var response = client.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

                if (!response.IsSuccessStatusCode)
                {
                    _resultato_txt = "Erro ao conectar com ViaCEP.";
                    return;
                }

                var json = response.Content.ReadAsStringAsync().Result;

                if (string.IsNullOrWhiteSpace(json) || json.Contains("\"erro\": true"))
                {
                    _resultato_txt = "CEP não encontrado.";
                    return;
                }

                var dados = JsonSerializer.Deserialize<ViaCepResponse>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (dados == null)
                {
                    _resultato_txt = "Erro ao interpretar a resposta do ViaCEP.";
                    return;
                }

                _uf = dados.uf ?? "";
                _cidade = dados.localidade ?? "";
                _bairro = dados.bairro ?? "";
                _lagradouro = dados.logradouro ?? "";
                _tipo_lagradouro = ""; // ViaCEP não retorna isso diretamente

                _resultado = "1";
                _resultato_txt = "CEP encontrado com sucesso.";
            }
            catch (Exception ex)
            {
                _resultato_txt = $"Erro de execução: {ex.Message}";
                _resultado = "0";
            }
        }
        #endregion

        #region "Classe interna"
        private class ViaCepResponse
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
        }
        #endregion
    }
}
