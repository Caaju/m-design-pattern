using Component;

namespace CompositeComponent;

public class CompoundGraphic
{
    private ICollection<IGraphic> children;

    public CompoundGraphic()
    {
        children = new HashSet<IGraphic>();
    }

    public void Add(IGraphic graphic) => this.children.Add(graphic);

    public void Move(int x, int y)
    {
        foreach (var child in this.children)
        {
            child.Move(x, y);
        }
    }

    public void Draw()
    {
        foreach (var child in this.children)
        {
            child.Draw();
        }
    }
}
