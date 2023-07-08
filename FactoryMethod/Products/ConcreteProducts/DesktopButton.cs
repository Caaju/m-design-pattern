using Products.Interfaces;

namespace Products.ConcreteProducts;

public class DesktopButton : IButton
{
    public void Close()
    {
        Console.WriteLine("close button desktop.");
    }

    public void Render()
    {
        Console.WriteLine("render button desktop.");
    }
}