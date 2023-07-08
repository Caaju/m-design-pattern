using Products.Interfaces;

namespace Products.ConcreteProducts;
public class WebButton : IButton
{
    public void Close()
    {
        Console.WriteLine("close button web.");
    }

    public void Render()
    {
        Console.WriteLine("render button web.");
    }
}