using Component;

namespace Leaf;
public class Dot : IGraphic
{
    protected int x;
    protected int y;

    public Dot(int x, int y)
    {
        this.x=x;
        this.y=y;
    }
    public virtual void Draw()
    {
        Console.WriteLine($"Drawing dot on cordinate ({x},{y})");
    }

    public void Move(int x, int y)
    {
        this.x=x;
        this.y=y;

        Console.WriteLine($"Moving to ({x},{y})");
    }
}