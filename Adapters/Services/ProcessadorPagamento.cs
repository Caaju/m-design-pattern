using Models;
using Models.Base;
using Services.Interfaces;

namespace Services;
public class ProcessadorPagamento:IProcessadorPagamento
{
    public void Perform(TypeData data)
    {
        Console.WriteLine($"Processing {data.ToString()}");
    }
}