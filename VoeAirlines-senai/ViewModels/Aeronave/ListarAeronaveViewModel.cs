//ID, CODIGO, MODELO
//não precisa do fabricante.
namespace VoeAirlinesSenai.ViewModels;

public class ListarAeronaveViewModel1
{
    public ListarAeronaveViewModel1(int id, string modelo, string codigo)
    {
        Id = id;
        Modelo = modelo;
        Codigo = codigo;
    }

    public int Id{get;set;}
    public string Modelo{get;set;}
    public string Codigo{get;set;}
}