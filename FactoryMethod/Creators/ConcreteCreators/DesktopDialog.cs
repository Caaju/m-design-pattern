using Creators.Interfaces;
using Products.ConcreteProducts;
using Products.Interfaces;

namespace Creators.ConcreteCreators;
public class DesktopDialog : IDialog
{
    public IButton CreateButton()
    {
        return new DesktopButton();
    }

    public void Render()
    {
        Console.WriteLine("render dialog desktop");
    }
}