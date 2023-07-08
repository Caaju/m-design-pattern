using Products.Abstracts;

namespace Factories.Abstracts;
public interface IFabricaMobilia
{
    IMesaDeCentro FactoryMesaDeCentro();
    ISofa FactorySofa();
    ICadeira FactoryCadeira();
}
