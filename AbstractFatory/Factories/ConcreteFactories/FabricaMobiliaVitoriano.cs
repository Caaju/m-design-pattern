using Factories.Abstracts;
using Products.ConcreteProducts.Vitoriano;

namespace Products.Abstracts.ConcreteProducts;
public class FabricaMobiliaVitoriano : IFabricaMobilia
{
    public ICadeira FactoryCadeira()
    {
        return new CadeiraVitoriano();
    }

    public IMesaDeCentro FactoryMesaDeCentro()
    {
        return new MesaDeCentroVitoriano();
    }

    public ISofa FactorySofa()
    {
        return new SofaVitoriano();
    }
}