namespace Leaf;
public class Circle : Dot
{
    private int radius;

    public Circle(int x, int y, int radius) : base(x, y)
    {
        this.radius=radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing circle on cordinate ({this.x},{this.y}), radius {this.radius}");
    }
}