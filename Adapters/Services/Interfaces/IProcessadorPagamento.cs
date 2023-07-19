using Models.Base;

namespace Services.Interfaces;
public interface IProcessadorPagamento
{
    void Perform(TypeData data);
}