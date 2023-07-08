using Prototype.Interfaces;

namespace Prototype.ConcretePrototype;

public class Rectangule : ShapeBase, IPrototype<Rectangule>
{
    public int w,h;

    public Rectangule() { }

    public Rectangule(Rectangule shape)
        : base(shape)
    {
        this.w = shape.w;
        this.h = shape.h;
    }

    public Rectangule Clone()
    {
        return new Rectangule(this);
    }
}
