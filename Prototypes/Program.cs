// See https://aka.ms/new-console-template for more information

using Prototype.ConcretePrototype;

Rectangule r = new Rectangule();
r.w=3;r.h=10;
Rectangule r_clone = r.Clone();
r.w=7;r.h=2;
Console.WriteLine(r_clone.w);

Circle c=new Circle();
c.r=8;
Circle c_clone=c.Clone();
c.r=10;
Console.WriteLine(c_clone.r);

