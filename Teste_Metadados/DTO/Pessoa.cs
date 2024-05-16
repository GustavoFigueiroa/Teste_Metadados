using Newtonsoft.Json;

namespace Teste_Metadados.DTO
{
    public class Pessoa
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)] 
        public string? Id { get; set; }

        [JsonProperty("pessoa")]
        public int? PessoaID { get; set; }

        [JsonProperty("empresa")]
        public string? Empresa { get; set; }

        [JsonProperty("cpf")]
        public string? Cpf { get; set; }

        [JsonProperty("nome")]
        public string? Nome { get; set; }

        [JsonProperty("nomeCompleto")]
        public string? NomeCompleto { get; set; }

        [JsonProperty("nomeSocial")]
        public string? NomeSocial { get; set; }

        [JsonProperty("apelido")]
        public string? Apelido { get; set; }

        [JsonProperty("dataCadastramento")]
        public DateTime? DataCadastramento { get; set; }

        [JsonProperty("nascimento")]
        public DateTime? Nascimento { get; set; }

        [JsonProperty("localNascimento")]
        public string? LocalNascimento { get; set; }

        [JsonProperty("ufNascimento")]
        public string? UfNascimento { get; set; }

        [JsonProperty("pai")]
        public string? Pai { get; set; }

        [JsonProperty("mae")]
        public string? Mae { get; set; }

        [JsonProperty("nomeMaeCompleto")]
        public string? NomeMaeCompleto { get; set; }

        [JsonProperty("sexo")]
        public string? Sexo { get; set; }

        [JsonProperty("racaCor")]
        public string? RacaCor { get; set; }

        [JsonProperty("estadoCivil")]
        public string? EstadoCivil { get; set; }

        [JsonProperty("grauInstrucao")]
        public string? GrauInstrucao { get; set; }

        [JsonProperty("rua")]
        public string? Rua { get; set; }

        [JsonProperty("nroRua")]
        public string? NroRua { get; set; }

        [JsonProperty("complemento")]
        public string? Complemento { get; set; }

        [JsonProperty("bairro")]
        public string? Bairro { get; set; }

        [JsonProperty("cidade")]
        public string? Cidade { get; set; }

        [JsonProperty("uf")]
        public string? Uf { get; set; }

        [JsonProperty("cep")]
        public string? Cep { get; set; }

        [JsonProperty("ddd")]
        public string? Ddd { get; set; }

        [JsonProperty("ramal")]
        public string? Ramal { get; set; }

        [JsonProperty("telefone")]
        public string? Telefone { get; set; }

        [JsonProperty("telefoneRecados")]
        public string? TelefoneRecados { get; set; }

        [JsonProperty("dddCelular")]
        public string? DddCelular { get; set; }

        [JsonProperty("telefoneCelular")]
        public string? TelefoneCelular { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("emailCorporativo")]
        public string? EmailCorporativo { get; set; }

        [JsonProperty("identidade")]
        public string? Identidade { get; set; }

        [JsonProperty("tipoIdentidade")]
        public string? TipoIdentidade { get; set; }

        [JsonProperty("orgaoEmissor")]
        public string? OrgaoEmissor { get; set; }

        [JsonProperty("ufIdentidade")]
        public string? UfIdentidade { get; set; }

        [JsonProperty("dataIdentidade")]
        public DateTime? DataIdentidade { get; set; }

        [JsonProperty("regIdCivilNr")]
        public string? RegIdCivilNr { get; set; }

        [JsonProperty("regIdCivilOe")]
        public string? RegIdCivilOe { get; set; }

        [JsonProperty("regIdCivilDe")]
        public DateTime? RegIdCivilDe { get; set; }

        [JsonProperty("deficienteFisico")]
        public string? DeficienteFisico { get; set; }

        [JsonProperty("defAuditivaeSocial")]
        public string? DefAuditivaeSocial { get; set; }

        [JsonProperty("defIntelectualeSocial")]
        public string? DefIntelectualeSocial { get; set; }

        [JsonProperty("defMentaleSocial")]
        public string? DefMentaleSocial { get; set; }

        [JsonProperty("defMotoraeSocial")]
        public string? DefMotoraeSocial { get; set; }

        [JsonProperty("defVisualeSocial")]
        public string? DefVisualeSocial { get; set; }

        [JsonProperty("benefReabilitado")]
        public string? BenefReabilitado { get; set; }

        [JsonProperty("cotapessoaDefReab")]
        public string? CotapessoaDefReab { get; set; }

        [JsonProperty("conselhoClasse")]
        public string? ConselhoClasse { get; set; }

        [JsonProperty("registroConselho")]
        public string? RegistroConselho { get; set; }

        [JsonProperty("dataRegistro")]
        public DateTime? DataRegistro { get; set; }

        [JsonProperty("cartTrabDigital")]
        public string? CartTrabDigital { get; set; }

        [JsonProperty("nroCartTrab")]
        public string? NroCartTrab { get; set; }

        [JsonProperty("serieCartTrab")]
        public string? SerieCartTrab { get; set; }

        [JsonProperty("ufCartTrab")]
        public string? UfCartTrab { get; set; }

        [JsonProperty("dataCartTrab")]
        public DateTime? DataCartTrab { get; set; }

        [JsonProperty("pis")]
        public string? Pis { get; set; }

        [JsonProperty("dataPis")]
        public DateTime? DataPis { get; set; }

        [JsonProperty("tituloEleitoral")]
        public string? TituloEleitoral { get; set; }

        [JsonProperty("zonaEleitoral")]
        public string? ZonaEleitoral { get; set; }

        [JsonProperty("secaoEleitoral")]
        public string? SecaoEleitoral { get; set; }

        [JsonProperty("sindicato")]
        public string? Sindicato { get; set; }

        [JsonProperty("cnae")]
        public string? Cnae { get; set; }

        [JsonProperty("habilitacaoProfissional")]
        public string? HabilitacaoProfissional { get; set; }

        [JsonProperty("categoriaHabilitacao")]
        public string? CategoriaHabilitacao { get; set; }

        [JsonProperty("registroHabilitacao")]
        public string? RegistroHabilitacao { get; set; }

        [JsonProperty("ufHabilitacao")]
        public string? UfHabilitacao { get; set; }

        [JsonProperty("expedicaoHabilitacao")]
        public DateTime? ExpedicaoHabilitacao { get; set; }

        [JsonProperty("validadeHabilitacao")]
        public DateTime? ValidadeHabilitacao { get; set; }

        [JsonProperty("nacionalidade")]
        public string? Nacionalidade { get; set; }

        [JsonProperty("paisNascimento")]
        public string? PaisNascimento { get; set; }

        [JsonProperty("paisNacionalidade")]
        public string? PaisNacionalidade { get; set; }

        [JsonProperty("paisResidencia")]
        public string? PaisResidencia { get; set; }

        [JsonProperty("tipoLogradouro")]
        public string? TipoLogradouro { get; set; }

        [JsonProperty("anoChegadaBrasil")]
        public string? AnoChegadaBrasil { get; set; }

        [JsonProperty("dataChegadaBrasil")]
        public DateTime? DataChegadaBrasil { get; set; }

        [JsonProperty("clasTrabEstrangeiro")]
        public string? ClasTrabEstrangeiro { get; set; }

        [JsonProperty("regEstrangeiroNr")]
        public string? RegEstrangeiroNr { get; set; }

        [JsonProperty("regEstrangeiroOe")]
        public string? RegEstrangeiroOe { get; set; }

        [JsonProperty("regEstrangeiroDe")]
        public DateTime? RegEstrangeiroDe { get; set; }

        [JsonProperty("unidadeOperador")]
        public string? UnidadeOperador { get; set; }

        [JsonProperty("contratoOperador")]
        public string? ContratoOperador { get; set; }
    }
}
