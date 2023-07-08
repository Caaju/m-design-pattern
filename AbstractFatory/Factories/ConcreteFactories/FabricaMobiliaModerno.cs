using Factories.Abstracts;
using Products.ConcreteProducts.Moderno;

namespace Products.Abstracts.ConcreteProducts;

public class FabricaMobiliaModerno : IFabricaMobilia
{
    public ICadeira FactoryCadeira()
    {
        return new CadeiraModerno();
    }

    public IMesaDeCentro FactoryMesaDeCentro()
    {
        return new MesaDeCentroModerno();
    }

    public ISofa FactorySofa()
    {
        return new SofaModerno();
    }
}
