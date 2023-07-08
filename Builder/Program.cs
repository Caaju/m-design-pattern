// See https://aka.ms/new-console-template for more information

using Builders.ConcreteBuilders;
using Builders.Interfaces;
using Directors;

var director=new Director();
CarBuilder builder=new CarBuilder();

director.MakeSportCar(builder);
var car=builder.GetResult();

Console.WriteLine(car.SeatNumber);

CarManualBuilder manualBuilder=new CarManualBuilder();
director.MakeSportCar(manualBuilder);
var manual=manualBuilder.GetResult();
Console.WriteLine(manual.Description);