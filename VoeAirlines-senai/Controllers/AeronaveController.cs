using Microsoft.AspNetCore.Mvc;
using VoeAirlinesSenai.Services;
using VoeAirlinesSenai.ViewModels.Aeronave;

//A Controller é uma classe, porém, que permite trabalhar especificamente

//Uma Classe 
//herança no C# - ":"
//URL - Endereço - Caminho 
//Rota
//Rota é trecho - Sub Caminho
[Route("api/aeronaves")]
[ApiController]
//O Controller pode trabalhar 
//AspNet MVC ou API ou Outros
public class AeronaveController : ControllerBase
{

    private readonly AeronaveService _aeronaveService;

    public AeronaveController(AeronaveService aeronaveService)
    {
        _aeronaveService = aeronaveService;
    }
    [HttpPost]
    public IActionResult AdicionarAeronave(AdicionarAeronaveViewModel dados)
    {

        var aeronave = _aeronaveService.AdicionarAeronave(dados);
        return Ok(aeronave);

    }
    [HttpGet]
    public IActionResult ListarAeronaves(){
        return Ok(_aeronaveService.ListarAeronaves());
    }
    [HttpGet("{id}")]
    public IActionResult ListarAeronavePeloId(int id){

        var aeronave = _aeronaveService.ListarAeronavePeloId(id);
        if(aeronave!=null){
            return Ok(aeronave);
        }
        return NotFound();
    }
    [HttpPut("{id}")]
    public IActionResult AtualizarAeronave(int id,AtualizarAeronaveViewModel dados){
        if(id != dados.Id){
            return BadRequest("O id informado na URL é diferente do id informado no corpo da requisição");
        }
        var aeronave = _aeronaveService.AtualizarAeronave(dados);
        return Ok(aeronave);
    }

    [HttpDelete("{id}")]
    public IActionResult ExcluirAeronave(int id){
        _aeronaveService.ExcluirAeronave(id);
        return NoContent();
    }


    

}