using Products.Abstracts;

namespace Products.ConcreteProducts.Basico;

public class CadeiraBasico : ICadeira
{
    public void Perform()
    {
        Console.WriteLine("Perform cadeira básica.");
    }
}