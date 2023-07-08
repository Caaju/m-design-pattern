using Products.Abstracts;

namespace Products.ConcreteProducts.Moderno;
public class CadeiraModerno : ICadeira
{
    public void Perform()
    {
        Console.WriteLine("Perform cadeira moderna.");
    }
}