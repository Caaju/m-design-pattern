using Prototype.Interfaces;

namespace Prototype.ConcretePrototype;

public class Circle : ShapeBase, IPrototype<Circle>
{
    public int r;

    public Circle() { }

    public Circle(Circle shape)
        : base(shape)
    {
        this.r = shape.r;
    }

    public Circle Clone()
    {
        return new Circle(this);
    }
}
