using Builders.Interfaces;
using Products;

namespace Builders.ConcreteBuilders;

public class CarBuilder : IBuilder
{
    private Car car;

    public CarBuilder() => this.Reset();

    public Car GetResult() => this.car;

    public void Reset()
    {
        this.car = new Car();
    }

    public void SetEngine(object engine)
    {
        this.car.Engine=engine;
    }

    public void SetGPS()
    {
        this.car.HasGPS=true;
    }

    public void SetSeats(int n)
    {
        this.car.SeatNumber=n;
    }

    public void SetTripComputer()
    {
        this.car.HasTripComputer=true;
    }
}
