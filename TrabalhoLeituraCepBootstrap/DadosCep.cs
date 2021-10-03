using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TrabalhoLeituraCepBootstrap
{
    public class DadosCep
    {
        [JsonPropertyName("resultado")]
        public string Resultado { get; set; }

        [JsonPropertyName("resultado_txt")]
        public string ResultadoTxt { get; set; }

        [JsonPropertyName("uf")]
        public string Uf { get; set; }

        [JsonPropertyName("cidade")]
        public string Cidade { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("tipo_logradouro")]
        public string TipoLogradouro { get; set; }

        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }
    }
}
