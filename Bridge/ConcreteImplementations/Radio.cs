using Implementations;

namespace ConcreteImplementations;

public class Radio : IDevice
{
    int channel,
        volume;

    public Radio()
    {
        channel = volume = 0;
    }

    public int GetChannel() => channel;

    public int GetVolume() => volume;

    public void SetChannel(int channel) => this.channel = channel;

    public void SetVolume(int percent) => this.volume = percent;

    public override string ToString() => "Radio";
}
