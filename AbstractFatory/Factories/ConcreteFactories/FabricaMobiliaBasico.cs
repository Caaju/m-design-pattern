using Factories.Abstracts;
using Products.ConcreteProducts.Basico;

namespace Products.Abstracts.ConcreteProducts;
public class FabricaMobiliaBasico : IFabricaMobilia
{
    public ICadeira FactoryCadeira()
    {
        return new CadeiraBasico();
    }

    public IMesaDeCentro FactoryMesaDeCentro()
    {
        return new MesaDeCentroBasico();
    }

    public ISofa FactorySofa()
    {
        return new SofaBasico();
    }
}