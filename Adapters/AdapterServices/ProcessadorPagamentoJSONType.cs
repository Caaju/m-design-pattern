using Models;
using Models.Base;
using Services;
using Services.Interfaces;

namespace AdapterServices;
public class ProcessadorPagamentoJSONType : IProcessadorPagamento
{
    IProcessadorPagamento processadorPagamento;
    public ProcessadorPagamentoJSONType()
    {
        this.processadorPagamento=new ProcessadorPagamento();
    }
    public void Perform(TypeData data)
    {
        Console.WriteLine("convert JSON data to XML data");
        this.processadorPagamento.Perform(new XMLData());
    }
}