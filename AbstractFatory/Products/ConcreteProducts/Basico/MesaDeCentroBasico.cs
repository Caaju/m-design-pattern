using Products.Abstracts;

namespace Products.ConcreteProducts.Basico;

public class MesaDeCentroBasico : IMesaDeCentro
{
    public void Perform()
    {
        Console.WriteLine("Perform mesa de centro básica.");
    }
}