using Products.Interfaces;

namespace Creators.Interfaces;
public interface IDialog
{
    void Render();
    IButton CreateButton();
}