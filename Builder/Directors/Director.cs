using Builders.Interfaces;
using Engines;

namespace Directors;

public class Director
{
    public void MakeSportCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(2);
        builder.SetTripComputer();
        builder.SetGPS();
        builder.SetEngine(new SportEngine());
    }

    public void MakeSUVCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(4);
        builder.SetTripComputer();
        builder.SetGPS();
        builder.SetEngine(new SUVEngine());
    }
}
