using VoeAirlinesSenai.Entities.Enums;

namespace VoeAirlinesSenai.ViewModels.Manutencao;

public class AtualizarManutencaoViewModel
{
  public AtualizarManutencaoViewModel(DateTime dataHora,  TipoManutencao tipo,  string? observacoes,int aeronaveId)
    {
        DataHora = dataHora;
        Observacoes = observacoes;
        Tipo = tipo;
        AeronaveId = aeronaveId;
    }
    
  
    public DateTime DataHora { get; set; }
    public string? Observacoes { get; set; }
    public TipoManutencao Tipo  { get; set; }
    public int AeronaveId { get; set; }

}