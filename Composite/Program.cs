// See https://aka.ms/new-console-template for more information
using CompositeComponent;
using Leaf;

var all=new CompoundGraphic();
all.Add(new Dot(10,3));
all.Add(new Circle(10,3,4));

Console.WriteLine("Posição inicial...");
all.Draw();


all.Move(2,4);
all.Draw();
