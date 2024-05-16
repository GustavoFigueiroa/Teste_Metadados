using Newtonsoft.Json;

namespace Teste_Metadados.DTO
{
    public class PreAdmissao
    {
        [JsonProperty("pessoa")]
        public Pessoa? Pessoa { get; set; }

        [JsonProperty("contrato")]
        public Contrato? Contrato { get; set; }

        [JsonProperty("familiar")]
        public List<Familiar> Familiar { get; set; } = [];
    }

}
