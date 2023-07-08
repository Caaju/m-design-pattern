using Products.Abstracts;

namespace Products.ConcreteProducts.Moderno;
public class MesaDeCentroModerno : IMesaDeCentro
{
    public void Perform()
    {
        Console.WriteLine("Perform mesa de centro moderna.");
    }
}