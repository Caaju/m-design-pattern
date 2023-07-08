using Products.Abstracts;

namespace Products.ConcreteProducts.Vitoriano;
public class MesaDeCentroVitoriano : IMesaDeCentro
{
    public void Perform()
    {
        Console.WriteLine("Perform mesa de centro vitoriano.");
    }
}