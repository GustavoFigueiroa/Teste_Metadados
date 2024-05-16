using Newtonsoft.Json;

namespace Teste_Metadados.DTO
{
    public class Contrato
    {
        [JsonProperty("unidade")]
        public string? Unidade { get; set; }

        [JsonProperty("contrato")]
        public string? ContratoId { get; set; }

        [JsonProperty("observacoesContrato")]
        public string? ObservacoesContrato { get; set; }

        [JsonProperty("estabelecimento")]
        public string? Estabelecimento { get; set; }

        [JsonProperty("situacaoPreAdmissao")]
        public string? SituacaoPreAdmissao { get; set; }

        [JsonProperty("dataAdmissao")]
        public DateTime? DataAdmissao { get; set; }

        [JsonProperty("tipoEmprego")]
        public string? TipoEmprego { get; set; }

        [JsonProperty("percInsalubridade")]
        public string? PercInsalubridade { get; set; }

        [JsonProperty("percPericulosidade")]
        public string? PercPericulosidade { get; set; }

        [JsonProperty("nivelExposicao")]
        public string? NivelExposicao { get; set; }

        [JsonProperty("banco")]
        public string? Banco { get; set; }

        [JsonProperty("bancoCredor")]
        public string? BancoCredor { get; set; }

        [JsonProperty("contaCorrente")]
        public string? ContaCorrente { get; set; }

        [JsonProperty("opcaoPrevidencia")]
        public string? OpcaoPrevidencia { get; set; }

        [JsonProperty("vinculoPrevidencia")]
        public string? VinculoPrevidencia { get; set; }

        [JsonProperty("opcaoFgts")]
        public string? OpcaoFgts { get; set; }

        [JsonProperty("dataOpcaoFgts")]
        public DateTime? DataOpcaoFgts { get; set; }

        [JsonProperty("cadastroEmpregadoFgts")]
        public string? CadastroEmpregadoFgts { get; set; }

        [JsonProperty("sindicato")]
        public string? Sindicato { get; set; }

        [JsonProperty("opcaoSindical")]
        public string? OpcaoSindical { get; set; }

        [JsonProperty("socioSindicato")]
        public string? SocioSindicato { get; set; }

        [JsonProperty("registro")]
        public string? Registro { get; set; }

        [JsonProperty("tipoContrato")]
        public string? TipoContrato { get; set; }

        [JsonProperty("inicioContrato")]
        public DateTime? InicioContrato { get; set; }

        [JsonProperty("terminoContrato")]
        public DateTime? TerminoContrato { get; set; }

        [JsonProperty("nroDiasContrato")]
        public string? NroDiasContrato { get; set; }

        [JsonProperty("inicioProrrogacao")]
        public DateTime? InicioProrrogacao { get; set; }

        [JsonProperty("terminoProrrogacao")]
        public DateTime? TerminoProrrogacao { get; set; }

        [JsonProperty("nrodiasProrrogacao")]
        public string? NrodiasProrrogacao { get; set; }

        [JsonProperty("salarioContratual")]
        public string? SalarioContratual { get; set; }

        [JsonProperty("horasContratuais")]
        public string? HorasContratuais { get; set; }

        [JsonProperty("tipoComplementoSalarial")]
        public string? TipoComplementoSalarial { get; set; }

        [JsonProperty("tipoSalario")]
        public string? TipoSalario { get; set; }

        [JsonProperty("cargo")]
        public string? Cargo { get; set; }

        [JsonProperty("planoCargo")]
        public string? PlanoCargo { get; set; }

        [JsonProperty("faixaSalarial")]
        public string? FaixaSalarial { get; set; }

        [JsonProperty("classeSalarial")]
        public string? ClasseSalarial { get; set; }

        [JsonProperty("funcao")]
        public string? Funcao { get; set; }

        [JsonProperty("setor")]
        public string? Setor { get; set; }

        [JsonProperty("escala")]
        public string? Escala { get; set; }

        [JsonProperty("centroCusto1")]
        public string? CentroCusto1 { get; set; }

        [JsonProperty("centroCusto2")]
        public string? CentroCusto2 { get; set; }

        [JsonProperty("centroCusto3")]
        public string? CentroCusto3 { get; set; }

        [JsonProperty("centroCusto4")]
        public string? CentroCusto4 { get; set; }

        [JsonProperty("postoTrabalho")]
        public string? PostoTrabalho { get; set; }

        [JsonProperty("classificacaoGps")]
        public string? ClassificacaoGps { get; set; }

        [JsonProperty("classificacaoSefip")]
        public string? ClassificacaoSefip { get; set; }

        [JsonProperty("classificacaoGerencial")]
        public string? ClassificacaoGerencial { get; set; }

        [JsonProperty("classificacaoContabil")]
        public string? ClassificacaoContabil { get; set; }

        [JsonProperty("vinculoEmpregaticio")]
        public string? VinculoEmpregaticio { get; set; }

        [JsonProperty("tipoAdmissao")]
        public string? TipoAdmissao { get; set; }

        [JsonProperty("indicativoAdmissao")]
        public string? IndicativoAdmissao { get; set; }

        [JsonProperty("indicPrimeiroEmprego")]
        public string? IndicPrimeiroEmprego { get; set; }

        [JsonProperty("tipoRegimeTrab")]
        public string? TipoRegimeTrab { get; set; }

        [JsonProperty("tipoRegimePrev")]
        public string? TipoRegimePrev { get; set; }

        [JsonProperty("naturezaAtividade")]
        public string? NaturezaAtividade { get; set; }

        [JsonProperty("categoriaTrabalhador")]
        public string? CategoriaTrabalhador { get; set; }

        [JsonProperty("tipoRegimeJornada")]
        public string? TipoRegimeJornada { get; set; }

        [JsonProperty("maoDeObra")]
        public string? MaoDeObra { get; set; }

        [JsonProperty("nrProcMenoreseSocial")]
        public string? NrProcMenoreseSocial { get; set; }

        [JsonProperty("naturezaEstagio")]
        public string? NaturezaEstagio { get; set; }

        [JsonProperty("nivelEstagio")]
        public string? NivelEstagio { get; set; }

        [JsonProperty("areaAtuacaoEstagiario")]
        public string? AreaAtuacaoEstagiario { get; set; }

        [JsonProperty("nrApoliceSeguroEstag")]
        public string? NrApoliceSeguroEstag { get; set; }

        [JsonProperty("valorBolsaEstagiario")]
        public string? ValorBolsaEstagiario { get; set; }

        [JsonProperty("dataTerminoEstagio")]
        public DateTime? DataTerminoEstagio { get; set; }

        [JsonProperty("supervisorEstagio")]
        public string? SupervisorEstagio { get; set; }

        [JsonProperty("cpfSupervisorEstagio")]
        public string? CpfSupervisorEstagio { get; set; }

        [JsonProperty("inscricaoInstEnsino")]
        public string? InscricaoInstEnsino { get; set; }

        [JsonProperty("razaoSocialInstEnsino")]
        public string? RazaoSocialInstEnsino { get; set; }

        [JsonProperty("descLogradInstEnsino")]
        public string? DescLogradInstEnsino { get; set; }

        [JsonProperty("nroLogradInstEnsino")]
        public string? NroLogradInstEnsino { get; set; }

        [JsonProperty("bairroInstEnsino")]
        public string? BairroInstEnsino { get; set; }

        [JsonProperty("cepInstEnsino")]
        public string? CepInstEnsino { get; set; }

        [JsonProperty("cidadeInstEnsino")]
        public string? CidadeInstEnsino { get; set; }

        [JsonProperty("codMunicipInstEnsino")]
        public string? CodMunicipInstEnsino { get; set; }

        [JsonProperty("ufInstEnsino")]
        public string? UfInstEnsino { get; set; }

        [JsonProperty("inscricaoAgIntegr")]
        public string? InscricaoAgIntegr { get; set; }

        [JsonProperty("razaoSocialAgIntegr")]
        public string? RazaoSocialAgIntegr { get; set; }

        [JsonProperty("descLogradAgIntegr")]
        public string? DescLogradAgIntegr { get; set; }

        [JsonProperty("nroLogradAgIntegr")]
        public string? NroLogradAgIntegr { get; set; }

        [JsonProperty("bairroAgIntegr")]
        public string? BairroAgIntegr { get; set; }

        [JsonProperty("cepAgIntegr")]
        public string? CepAgIntegr { get; set; }

        [JsonProperty("cidadeAgIntegr")]
        public string? CidadeAgIntegr { get; set; }

        [JsonProperty("codMunicipAgIntegr")]
        public string? CodMunicipAgIntegr { get; set; }

        [JsonProperty("ufAgIntegr")]
        public string? UfAgIntegr { get; set; }

        [JsonProperty("categTrabEmprOrigem")]
        public string? CategTrabEmprOrigem { get; set; }

        [JsonProperty("inscricaoEmprOrigem")]
        public string? InscricaoEmprOrigem { get; set; }

        [JsonProperty("dataAdmEmprOrigem")]
        public DateTime? DataAdmEmprOrigem { get; set; }

        [JsonProperty("matriculaEmprOrigem")]
        public string? MatriculaEmprOrigem { get; set; }

        [JsonProperty("inscricaoEmprAnter")]
        public string? InscricaoEmprAnter { get; set; }

        [JsonProperty("matriculaEmprAnter")]
        public string? MatriculaEmprAnter { get; set; }

        [JsonProperty("dataAdmEmprAnter")]
        public DateTime? DataAdmEmprAnter { get; set; }

        [JsonProperty("inscricaoEmprCed")]
        public string? InscricaoEmprCed { get; set; }

        [JsonProperty("matriculaEmprCed")]
        public string? MatriculaEmprCed { get; set; }

        [JsonProperty("dataAdmEmprCed")]
        public string? DataAdmEmprCed { get; set; }

        [JsonProperty("opcaoOnusTrabCed")]
        public string? OpcaoOnusTrabCed { get; set; }

        [JsonProperty("motivoContratTrabTemp")]
        public string? MotivoContratTrabTemp { get; set; }

        [JsonProperty("categTrabEmprCed")]
        public string? CategTrabEmprCed { get; set; }

        [JsonProperty("estatutarioIndProvim")]
        public string? EstatutarioIndProvim { get; set; }

        [JsonProperty("estatutarioTipoProvim")]
        public string? EstatutarioTipoProvim { get; set; }

        [JsonProperty("estatutarioDataNomeacao")]
        public DateTime? EstatutarioDataNomeacao { get; set; }

        [JsonProperty("estatutarioDataPosse")]
        public DateTime? EstatutarioDataPosse { get; set; }

        [JsonProperty("estatutarioDataExercicio")]
        public DateTime? EstatutarioDataExercicio { get; set; }

        [JsonProperty("matriculaServidorPublico")]
        public string? MatriculaServidorPublico { get; set; }

        [JsonProperty("fatoJustContrTrabTemp")]
        public string? FatoJustContrTrabTemp { get; set; }

        [JsonProperty("tipoInclContrTrabTemp")]
        public string? TipoInclContrTrabTemp { get; set; }

        [JsonProperty("cpfTrabSubstituido")]
        public string? CpfTrabSubstituido { get; set; }

        [JsonProperty("estatutarioNrProcJud")]
        public string? EstatutarioNrProcJud { get; set; }

        [JsonProperty("estatutarioTipoPlano")]
        public string? EstatutarioTipoPlano { get; set; }

        [JsonProperty("carreiraPublica")]
        public string? CarreiraPublica { get; set; }

        [JsonProperty("ingressoCarreiraPublica")]
        public DateTime? IngressoCarreiraPublica { get; set; }

        [JsonProperty("tipoContratoTempoParcial")]
        public string? TipoContratoTempoParcial { get; set; }

        [JsonProperty("emprestimoConsigGarantiaFgts")]
        public string? EmprestimoConsigGarantiaFgts { get; set; }

        [JsonProperty("matriculaInstitConsigCadCaixa")]
        public string? MatriculaInstitConsigCadCaixa { get; set; }

        [JsonProperty("nroContratEmprestimoConsig")]
        public string? NroContratEmprestimoConsig { get; set; }

        [JsonProperty("tipoInscricaoEmprAnter")]
        public string? TipoInscricaoEmprAnter { get; set; }
    }
}
