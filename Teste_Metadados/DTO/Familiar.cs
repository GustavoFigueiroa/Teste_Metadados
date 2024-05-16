using Newtonsoft.Json;

namespace Teste_Metadados.DTO
{
    public class Familiar
    {
        [JsonProperty("nome")]
        public string? Nome { get; set; }

        [JsonProperty("nomeCompleto")]
        public string? NomeCompleto { get; set; }

        [JsonProperty("cpf")]
        public string? Cpf { get; set; }

        [JsonProperty("nascimento")]
        public DateTime? Nascimento { get; set; }

        [JsonProperty("sexo")]
        public string? Sexo { get; set; }

        [JsonProperty("estadoCivil")]
        public string? EstadoCivil { get; set; }

        [JsonProperty("grauInstrucao")]
        public string? GrauInstrucao { get; set; }

        [JsonProperty("nacionalidade")]
        public string? Nacionalidade { get; set; }

        [JsonProperty("emDiaComVacinas")]
        public string? EmDiaComVacinas { get; set; }

        [JsonProperty("frequentaEscola")]
        public string? FrequentaEscola { get; set; }

        [JsonProperty("grauDependencia")]
        public string? GrauDependencia { get; set; }

        [JsonProperty("grauParentesco")]
        public string? GrauParentesco { get; set; }

        [JsonProperty("depPlanoPrivadoSaude")]
        public string? DepPlanoPrivadoSaude { get; set; }

        [JsonProperty("depIncapazParaTrab")]
        public string? DepIncapazParaTrab { get; set; }

        [JsonProperty("tipoDependenteeSocial")]
        public string? TipoDependenteeSocial { get; set; }

        [JsonProperty("salFamilia")]
        public string? SalFamilia { get; set; }

        [JsonProperty("auxilioCreche")]
        public string? AuxilioCreche { get; set; }

        [JsonProperty("dependenteIrf")]
        public string? DependenteIrf { get; set; }

        [JsonProperty("benefPrevidencia")]
        public string? BenefPrevidencia { get; set; }

        [JsonProperty("benefSeguro")]
        public string? BenefSeguro { get; set; }

        [JsonProperty("percBenefSeguro")]
        public string? PercBenefSeguro { get; set; }
    }
}
