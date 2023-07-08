using Creators.Interfaces;
using Products.ConcreteProducts;
using Products.Interfaces;

namespace Creators.ConcreteCreators;
public class WebDialog : IDialog
{
    public IButton CreateButton()
    {
        return new WebButton();
    }

    public void Render()
    {
        Console.WriteLine("render dialog web.");
    }
}