using Implementations;

namespace Abstractions;

public class Remote
{
    protected IDevice device;

    public Remote(IDevice device)
    {
        this.device = device;
    }

    public void VolumeDown()
    {
        this.device.SetVolume(this.device.GetVolume() - 1);
    }

    public void VolumeUp()
    {
        this.device.SetVolume(this.device.GetVolume() + 1);
    }

    public void ChannelDown()
    {
        this.device.SetChannel(this.device.GetChannel() - 1);
        Console.WriteLine($"{this.device.ToString()} =>  Channel: {this.device.GetChannel()}");
    }

    public void ChannelUp()
    {
        this.device.SetChannel(this.device.GetChannel() + 1);
        Console.WriteLine($"{this.device.ToString()} =>  Channel: {this.device.GetChannel()}");
    }
}
