namespace Products;

public class Manual
{
    public Manual()
    {
        this.SetDescription("Specification Car");
    }
    public string? Description { get; set; }

    public string SetDescription(string description) =>
        this.Description = string.Concat(this.Description, description, "\n");
}
