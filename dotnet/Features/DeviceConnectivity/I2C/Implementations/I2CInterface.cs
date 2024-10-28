namespace dotnet.Features.DeviceConnectivity.I2C.Implementations
{
    public class I2CInterface : II2CInterface
    {
        public bool Initialize(int busId, int deviceAddress)
        {
            throw new System.NotImplementedException();
        }

        public byte[] Read(int length)
        {
            throw new System.NotImplementedException();
        }

        public void Write(byte[] data)
        {
            throw new System.NotImplementedException();
        }
    }
}