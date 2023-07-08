using Builders.Interfaces;
using Products;

namespace Builders.ConcreteBuilders;

public class CarManualBuilder : IBuilder
{
    private Manual? manual;

    public CarManualBuilder() => this.Reset();

    public void Reset() => this.manual = new Manual();

    public void SetEngine(object engine)
    {
        this.manual.SetDescription($"Engine:{nameof(engine)}");
    }

    public void SetGPS()
    {
        this.manual.SetDescription("Has GPS");
    }

    public void SetSeats(int n)
    {
        this.manual.SetDescription($"Seat Number:{n}");
    }

    public void SetTripComputer()
    {
        this.manual.SetDescription("Has trip computer");
    }

    public Manual GetResult() => this.manual;
}
