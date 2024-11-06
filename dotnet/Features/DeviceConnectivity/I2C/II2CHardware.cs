using dotnet.Common.ErrorHandling;
namespace dotnet.Features.DeviceConnectivity.I2C
{
    public interface II2CHardware
    {
        unsafe Either<Response<bool>, I2cError> Initialize(int busId, byte deviceAddress);

        /** Read single byte from 8-bit device register
        * @param devAddr - I2C slave device address
        * @param regAddr - internal register address within I2C slave
        */
        unsafe Either<Response<byte>, I2cError> ReadByte(int busId, byte devAddr, byte regAddr);

        /** Read multiple bytes from 8-bit device register
        * @param devAddr - I2C slave device address
        * @param regAddr - first register regAddr to read from
        * @param length - number of bytes to read
        */

        unsafe Either<Response<byte[]>, I2cError> ReadBytes(int busId, byte devAddr, byte regAddr, int length);

        /** Write single byte to 8-bit device register
        * @param devAddr - I2C slave device address
        * @param regAddr - register to write to
        * @param data - new byte value to write
        */
        unsafe Either<Response<bool>, I2cError> WriteByte(int busId, byte devAddr, byte regAddr, byte data);


        /** Write multiple bytes to 8-bit device register
        * @param devAddr - I2C slave device address
        * @param regAddr - first register address to write to
        * @param length - number of bytes to write
        * @param data - buffer to copy new data from
        */

        unsafe Either<Response<bool>, I2cError> WriteBytes(int busId, byte devAddr, byte regAddr, int length, byte[] data);

    }
}