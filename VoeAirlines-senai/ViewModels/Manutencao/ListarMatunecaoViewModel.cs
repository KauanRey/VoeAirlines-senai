using VoeAirlinesSenai.Entities.Enums;

namespace VoeAirlinesSenai.ViewModels.Manutencao;

public class ListarManutencaoViewModel
{
  public ListarManutencaoViewModel(int id,DateTime dataHora,  TipoManutencao tipo, string? observacoes,int aeronaveId)
    {
        Id = id;
        DataHora = dataHora;
        Observacoes = observacoes;
        Tipo = tipo;
        AeronaveId = aeronaveId;
    }
  
    public int Id { get; set; }
    public DateTime DataHora { get; set; }
    public string? Observacoes { get; set; }
    public TipoManutencao Tipo  { get; set; }
    public int AeronaveId { get; set; }

}