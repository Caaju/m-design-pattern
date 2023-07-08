namespace Builders.Interfaces;
public interface IBuilder
{
    void Reset();
    void SetSeats(int n);
    void SetEngine(object engine);
    void SetTripComputer();
    void SetGPS();
}