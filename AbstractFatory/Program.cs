// See https://aka.ms/new-console-template for more information

using Factories.Abstracts;
using Products.Abstracts.ConcreteProducts;

FabricarMobilia(new FabricaMobiliaModerno());

void FabricarMobilia(IFabricaMobilia fabrica)
{
    fabrica.FactoryCadeira().Perform();
    fabrica.FactorySofa().Perform();
    fabrica.FactoryMesaDeCentro().Perform();
}