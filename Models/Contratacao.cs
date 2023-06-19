namespace iob_smart_webapi.Models;

public class Contratacao
{
    public long ContratacaoId { get; set; }

    public long EmpresaId { get; set; }

    public string? NomeFuncionario { get; set; }

    public string? CpfFuncionario { get; set; }

    public string? RazaoSocialEmpresa { get; set; }

    public DateTime DataContratacao { get; set; }

    public decimal Salario { get; set; }
}