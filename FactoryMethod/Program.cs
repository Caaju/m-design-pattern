// See https://aka.ms/new-console-template for more information
using Creators.ConcreteCreators;
using Creators.Interfaces;
using Products.Interfaces;

Render(new DesktopDialog());

void Render(IDialog dialog)
{
    IButton button = dialog.CreateButton();
    dialog.Render();
    button.Render();
    button.Close();
}
