using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TrabalhoLeituraCepBootstrap.Pages
{
    public class IndexBase:ComponentBase
    {
        [Inject]
        public HttpClient HttpClient { get; set; }

        public string CepInput { get; set; }

        public DadosCep DadosCep { get; set; }

        public async Task BuscaCep()
        {
            var resultado = await HttpClient.GetAsync($"http://cep.republicavirtual.com.br/web_cep.php?cep={CepInput}&formato=json");
            DadosCep = JsonSerializer.Deserialize<DadosCep>(await resultado.Content.ReadAsStringAsync());

        }

    }
}
