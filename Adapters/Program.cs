// See https://aka.ms/new-console-template for more information
using AdapterServices;
using Models;
using Models.Base;
using Services;
using Services.Interfaces;

var XMLdata=new XMLData();
var JSONdata=new JSONData();
IProcessadorPagamento processador
    //=new ProcessadorPagamento();
    =new ProcessadorPagamentoJSONType();

//processador.Perform(XMLdata);
processador.Perform(JSONdata);