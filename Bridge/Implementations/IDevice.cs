namespace Implementations;

public interface IDevice
{
    void SetVolume(int percent);
    int GetVolume();
    void SetChannel(int channel);
    int GetChannel();
}
