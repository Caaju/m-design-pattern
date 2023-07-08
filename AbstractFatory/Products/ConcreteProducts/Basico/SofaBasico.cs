using Products.Abstracts;

namespace Products.ConcreteProducts.Basico;
public class SofaBasico : ISofa
{
    public void Perform()
    {
        Console.WriteLine("Peform sofá basico.");
    }
}