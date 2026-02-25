
namespace Heranca_Praticce_Activitys;

public  class Formas
{
    public double Altura { get; set; }
    public double Largura { get; set; }

    public string Nome;



    public virtual void FormaGeometrica()
    {
        double Area = Altura * Largura;
        Console.WriteLine($"A area do {Nome} e {Area}");
    }

}
