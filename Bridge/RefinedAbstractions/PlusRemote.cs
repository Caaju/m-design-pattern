using Abstractions;
using Implementations;

namespace RefinedAbstractions;

public class PlusRemote : Remote
{
    public PlusRemote(IDevice device)
        : base(device) { }

    public void Mute() => Console.WriteLine($"Mute {this.device.ToString()}");
}
