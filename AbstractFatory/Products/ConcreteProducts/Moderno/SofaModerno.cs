using Products.Abstracts;

namespace Products.ConcreteProducts.Moderno;
public class SofaModerno : ISofa
{
    public void Perform()
    {
        Console.WriteLine("Perform sofá moderno.");
    }
}