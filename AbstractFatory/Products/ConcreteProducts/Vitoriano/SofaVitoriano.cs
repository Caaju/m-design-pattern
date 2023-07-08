using Products.Abstracts;

namespace Products.ConcreteProducts.Vitoriano;
public class SofaVitoriano : ISofa
{
    public void Perform()
    {
        Console.WriteLine("Perform sofá vitoriano.");
    }
}