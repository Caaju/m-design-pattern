using Products.Abstracts;

namespace Products.ConcreteProducts.Vitoriano;
public class CadeiraVitoriano : ICadeira
{
    public void Perform()
    {
        Console.WriteLine("Perform cadeira vitoriana.");
    }
}