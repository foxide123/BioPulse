using System;
using System.Device.I2c;
using dotnet.Common.ErrorHandling;

namespace dotnet.Features.DeviceConnectivity.I2C.Implementations
{
    public class I2CManager
    {
        private readonly II2CHardware _i2cHardware;

        public I2CManager(II2CHardware i2cHardware)
        {
            _i2cHardware = i2cHardware;
        }

        //Should be move to other class
        public void DisplayError(string error)
        {
            Console.WriteLine(error);
        }

        public bool Initialize(int busId, byte devAddr)
        {
            var initializeResult = _i2cHardware.Initialize(busId, devAddr);
            return initializeResult.Match(
                result => true,
                error => {
                    DisplayError(error.ErrorMessage);
                    return false;
                }
            );
        }

        public unsafe byte? ReadByte(int busId, byte devAddr, byte regAddr)
        {
            return _i2cHardware.ReadByte(busId, devAddr, regAddr)
                .Match<byte?>(
                    success => {
                        return success.Data;
                    },
                    error => {
                        DisplayError(error.ErrorMessage);
                        return null;
                    }
                );
        }


        public unsafe int? ReadBit(int busId, byte devAddr, byte regAddr, int bitNum)
        {
            byte? readByte = ReadByte(busId, devAddr, regAddr);
            if(readByte.HasValue)
            {
                if(readByte != -1 && bitNum >=0 && bitNum <=7)
                {
                    return (int)(readByte >> bitNum) & 1;
                }
            }
            return null;
        }

        public unsafe int ReadBitW(byte devAddr, byte regAddr, int bitNum)
        {
            throw new NotImplementedException();
        }

        public unsafe byte? ReadBits(int busId, byte devAddr, byte regAddr, int bitStart, int length)
        {
            // 01101001 - read byte
            // 76543210 - bit numbers
            // bitStart=4, length=3
            // 010 masked
            byte? readByte = ReadByte(busId, devAddr, regAddr);

            if(readByte.HasValue)
            {
                if(readByte != -1)
                {
                    byte b = readByte.Value;
                    byte mask = (byte) (((1 << length) - 1) << (bitStart - length +1));
                    b &= mask;
                    b >>= (bitStart - length + 1);
                    return b;
                }
            }
            return null;
        }

        public unsafe int ReadBitsW(byte devAddr, byte regAddr, int bitStart, int length, ushort* data)
        {
            throw new NotImplementedException();
        }

        public unsafe int ReadWord(byte devAddr, byte regAddr, ushort* data)
        {
            return ReadWords(devAddr, regAddr, 1, data);
        }

              public unsafe int ReadWords(byte devAddr, byte regAddr, int length, ushort* data)
        {
            throw new NotImplementedException();
        }

        public unsafe void WriteByte(int busId, byte devAddr, byte regAddr, byte data)
        {
            var result = _i2cHardware.WriteByte(busId, devAddr, regAddr, data);
            result.Match(
                success => $"Successfuly written byte",
                error => $"Error: {error.ErrorMessage}"
            );
        }

        public unsafe bool WriteBit(byte devAddr, byte regAddr, int bitNum, byte data)
        {
            throw new NotImplementedException();
        }

        public unsafe bool WriteBitW(byte devAddr, byte regAddr, int bitNum, ushort data)
        {
            throw new NotImplementedException();
        }

        public unsafe bool WriteBits(byte devAddr, byte regAddr, int bitStart, int length, byte data)
        {
            throw new NotImplementedException();
        }

        public unsafe bool WriteBitsW(byte devAddr, byte regAddr, byte bitStart, byte length, ushort data)
        {
            throw new NotImplementedException();
        }

        public unsafe bool WriteWord(byte devAddr, byte regAddr, ushort data)
        {
            throw new NotImplementedException();
        }

         public unsafe bool WriteWords(byte devAddr, byte regAddr, int length, ushort* data)
        {
            throw new NotImplementedException();
        }
    }
}