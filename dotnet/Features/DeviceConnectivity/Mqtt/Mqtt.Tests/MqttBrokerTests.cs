using System.Threading.Tasks;
using dotnet.Features.DeviceConnectivity.Mqtt.Implementations;
using MQTTnet.Protocol;
using MQTTnet.Server;
using MQTTnet.Diagnostics;

/*
Extra tests to be implemented:
- test DisconnectClient
- test DisconnectClient called twice
- 
*/

namespace dotnet.Features.DeviceConnectivity.Mqtt.Mqtt.Tests
{
    public class MqttBrokerTests
    {
        [Fact]
        public async Task Should_Initialize_Server()
        {
            //Arrange
            var mqttBroker = new MqttBroker();

            //Act
            await mqttBroker.Run_Minimal_Server();

            // Assert
            Assert.True(mqttBroker.IsRunning);
        }

        [Theory]
        [InlineData("Mqtt test message", "test/topic")]
        public async Task Should_Publish_Message_From_Broker_Successfully(string testMessage, string testTopic)
        {
             // Arrange
            var mqttBroker = new MqttBroker();

            // Act
            var result = await mqttBroker.Publish_Message_From_Broker(testMessage, testTopic);

            // Assert
            Assert.True(result);
            Assert.True(mqttBroker.LastPublishedMessage == testMessage);
            Assert.True(mqttBroker.LastPublishedTopic == testTopic);
        }

        [Fact]
        public async Task Should_Disconnect_Client_Successfully()
        {
            var mqttBroker = new MqttBroker();

            var result = await mqttBroker.Disconnect_Client();

            Assert.True(result);
        }
    }
}