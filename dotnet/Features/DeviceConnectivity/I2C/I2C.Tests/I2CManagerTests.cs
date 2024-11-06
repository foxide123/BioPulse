using dotnet.Common.ErrorHandling;
using dotnet.Features.DeviceConnectivity.I2C;
using dotnet.Features.DeviceConnectivity.I2C.Implementations;
using Moq;

namespace dotnet.Features.DeviceConnectivity.I2C.I2C.Tests
{
    public class I2CManagerTests
    {

        private readonly Mock<II2CHardware> mockI2C;
        private readonly I2CManager i2CManager;

        public I2CManagerTests()
        {
            mockI2C = new Mock<II2CHardware>();
            i2CManager = new I2CManager(mockI2C.Object);
            InitializeMoq();
        }

        private void InitializeMoq()
        {
            mockI2C.Setup(m => m.Initialize(It.IsAny<int>(), It.IsAny<byte>())).Returns(new Response<bool>(true));
            mockI2C.Setup(m => m.ReadByte(It.IsAny<int>(), It.IsAny<byte>(), It.IsAny<byte>())).Returns(new Response<byte>(0x01));
            mockI2C.Setup(m => m.ReadBytes(It.IsAny<int>(), It.IsAny<byte>(), It.IsAny<byte>(), It.IsAny<int>())).Returns(new Response<byte[]>([0x01, 0x02, 0x03]));
            mockI2C.Setup(m => m.WriteByte(It.IsAny<int>(), It.IsAny<byte>(), It.IsAny<byte>(), It.IsAny<byte>())).Returns(new Response<bool>(true));
            mockI2C.Setup(m => m.WriteBytes(It.IsAny<int>(), It.IsAny<byte>(), It.IsAny<byte>(), It.IsAny<int>(), It.IsAny<byte[]>())).Returns(new Response<bool>(true));
        }

        [Fact]
        public void Should_Initialize_I2C_Interface()
        {
            //Arrange
            byte busId = 1;
            byte deviceAddress = 0x65; 
            //Act
            var result = i2CManager.Initialize(busId, deviceAddress);
            //Assert
            Assert.True(result);
        }

    }
}