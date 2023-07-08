// See https://aka.ms/new-console-template for more information

Database b=Database.GetInstance();
b.query("SELECT T_B");
Database c=Database.GetInstance();
Console.WriteLine(c.command);

c.query("SELECT T_C(ID)");
Console.WriteLine(b.command);
