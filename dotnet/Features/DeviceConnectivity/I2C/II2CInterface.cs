namespace dotnet.Features.DeviceConnectivity.I2C
{
    public interface II2CInterface
    {
        bool Initialize(int busId, int deviceAddress);
        byte[] Read(int length);
        void Write(byte[] data);
    }
}