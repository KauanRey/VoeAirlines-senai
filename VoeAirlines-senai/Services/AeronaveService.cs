//Utilização dos namespaces
using VoeAirlinesSenai.Contexts;
using VoeAirlinesSenai.Entities;
using VoeAirlinesSenai.ViewModels.Aeronave;

namespace VoeAirlinesSenai.Services;

public class AeronaveService
{

    //RF - Requisito Funcional
    //RF - Não funcionais
    //Nesse momento você vai trabalhar com requisitos funcionais

    //O sistema deve cadastrar a Aeronave
    //Nesse ponto do código veremos na prática 
    //VoeAirlinesContext objeto new VoeAirlinesContext();

    //Injeção de Dependencia 
    private readonly VoeAirlinesContext _context;
    public AeronaveService(VoeAirlinesContext context)
    {
        _context = context;
    }

    public DetalhesAeronaveViewModel AdicionarAeronave(AdicionarAeronaveViewModel dados)

    {

        var aeronave = new Aeronave(dados.Fabricante, dados.Modelo, dados.Codigo);

        _context.Add(aeronave);
        _context.SaveChanges();

        return new DetalhesAeronaveViewModel
        (
            aeronave.Id,
            aeronave.Fabricante,
            aeronave.Modelo,
            aeronave.Codigo
        );
    }

    //Listar Aeronaves
    public IEnumerable<ListarAeronaveViewModel> ListarAeronaves()
    {

        return _context.Aeronaves.Select(a => new ListarAeronaveViewModel(a.Id, a.Modelo, a.Codigo));

    }

    public DetalhesAeronaveViewModel? ListarAeronavePeloId(int id){
        
        var aeronave = _context.Aeronaves.Find(id);
        if(aeronave != null){
            return new DetalhesAeronaveViewModel(
                aeronave.Id,
                aeronave.Fabricante,
                aeronave.Modelo,
                aeronave.Codigo
            );
        }
        return null;
    }
    public void ExcluirAeronave(int id){
        var aeronave = _context.Aeronaves.Find(id);
        if(aeronave != null){
            _context.Remove(aeronave);
            _context.SaveChanges();
        }
    }
  
    public DetalhesAeronaveViewModel? AtualizarAeronave(AtualizarAeronaveViewModel dados){
              
              var aeronave = _context.Aeronaves.Find(dados.Id);
              if(aeronave != null){
                  aeronave.Fabricante = dados.Fabricante;
                  aeronave.Modelo = dados.Modelo;
                  aeronave.Codigo = dados.Codigo;
                  _context.Update(aeronave);
                  _context.SaveChanges();
                  return new DetalhesAeronaveViewModel(aeronave.Id,aeronave.Fabricante,aeronave.Modelo,aeronave.Codigo);

              }
              return null; 
     
    }


}