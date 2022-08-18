//Namespace é um conjunto de classes
//Namespace é uma divisão lógica
namespace VoeAirlinesSenai.Entities;

//Classe:é um conjunto de objetos
//Objeto: é uma instãncia de uma classe 
public class Aeronave
{
    public Aeronave(string fabricante, string modelo, string codigo)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        Codigo = codigo;
    }

    //Propriedades Automáticas
    //Caracteristicas do objeto
    //Automático: gera o get set
    //Métodos set -atribui
    //Métodos get -recupera
    //POCO-foco é o objeto
    public int ID { get; set; }
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public string Codigo { get; set; }
    public ICollection<Manutencao> Manutencoes { get; set; }=null!;
    public ICollection<Voo> Voo  { get; set; } =null!;

}