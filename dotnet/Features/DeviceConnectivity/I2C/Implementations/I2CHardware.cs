using System;
using System.Device.I2c;
using dotnet.Common.ErrorHandling;
using Iot.Device.Board;

namespace dotnet.Features.DeviceConnectivity.I2C.Implementations
{
    public class I2CHardware : II2CHardware
    {
        I2cDevice i2c;

        public bool ValidateDeviceAddress(byte devAddr)
        {
            return devAddr >= 0x08 && devAddr <= 0x77;
        }


        

        public unsafe Either<Response<bool>, I2cError> Initialize(int busId, byte devAddr)
        {
            if (!ValidateDeviceAddress(devAddr))
            {
                return new I2cError("Invalid device address.");
            }

            try{
                var connectionSettings = new I2cConnectionSettings(busId, devAddr);
                i2c = I2cDevice.Create(connectionSettings);
                return new Response<bool>(true);
            }catch(IOException e)
            {
                return new I2cError("Unhandled error: " + e);
            }
        }

        public List<Int32> ScanAvailableDevices(I2cBus i2cBus, int lowAddr = 0x03, int highAddr = 0x77)
        {
            List<Int32> busAddresses = I2cBusExtensions.PerformBusScan(i2cBus, lowAddr, highAddr);
            return busAddresses;
        }

        public unsafe Either<Response<byte>, I2cError> ReadByte(int busId, byte devAddr, byte regAddr)
        {
            if (!ValidateDeviceAddress(devAddr))
            {
                return new I2cError("Invalid device address.");
            }

            using (I2cDevice i2c = I2cDevice.Create(new I2cConnectionSettings(busId, devAddr)))
            {
                try{
                    i2c.WriteByte(regAddr);
                    byte readByte = i2c.ReadByte();  
                    return new Response<byte>(readByte);
                }catch(Exception e)
                {
                    return new I2cError("Unhandled error: " + e);
                } 
            }
        }

        public unsafe Either<Response<byte[]>, I2cError> ReadBytes(int busId, byte devAddr, byte regAddr, int length)
        {
            if (!ValidateDeviceAddress(devAddr))
            {
                return new I2cError("Invalid device address.");
            }

            using (I2cDevice i2c = I2cDevice.Create(new I2cConnectionSettings(busId, devAddr)))
            {
                try{
                    byte[] data = new byte[length];
                    i2c.WriteByte(regAddr);
                    i2c.Read(data);
                    return new Response<byte[]>(data);
                }catch(Exception e)
                {
                    return new I2cError("Unhandled error: " + e);
                }  
            }
        }

        public unsafe Either<Response<bool>, I2cError> WriteByte(int busId, byte devAddr, byte regAddr, byte data)
        {
            if (!ValidateDeviceAddress(devAddr))
            {
                return new I2cError("Invalid device address.");
            }

            using (I2cDevice i2c = I2cDevice.Create(new I2cConnectionSettings(busId, devAddr)))
            {
                try{
                    i2c.Write([regAddr, data]);
                    return new Response<bool>(true);
                }catch(Exception e)
                {
                    return new I2cError("Unhandled error: " + e);
                }
            }
        }

        public unsafe Either<Response<bool>, I2cError> WriteBytes(int busId, byte devAddr, byte regAddr, int length, byte[] data)
        {
            if (!ValidateDeviceAddress(devAddr))
            {
                return new I2cError("Invalid device address.");
            }

            using (I2cDevice i2c = I2cDevice.Create(new I2cConnectionSettings(busId, devAddr)))
            {
                try
                {
                    byte[] buffer = new byte[data.Length + 1];
                    buffer[0] = regAddr;
                    Array.Copy(data, 0, buffer, 1, data.Length);
                    i2c.Write(buffer);
                    return new Response<bool>(true);
                }catch(Exception e)
                {
                    return new I2cError("Unhandled error: " + e);
                }
            }
        }
    }
}