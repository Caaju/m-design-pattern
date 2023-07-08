using Prototype.Interfaces;

namespace Prototype.ConcretePrototype;
public abstract class ShapeBase
{
    private int x,y;
    private string? color;

    public ShapeBase()
    {
    }

    public ShapeBase(ShapeBase shape)
    {
        this.x=shape.x;
        this.y=shape.y;
        this.color=shape.color;
    }
}