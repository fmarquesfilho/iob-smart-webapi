namespace iob_smart_webapi.Models;

public class Nota
{
    public long NotaId { get; set; }

    public long PrestadorId { get; set; }

    public long TomadorId { get; set; }

    public string? RazaoSocialPrestador { get; set; }

    public string? RazaoSocialTomador { get; set; }

    public decimal Valor { get; set; }
}