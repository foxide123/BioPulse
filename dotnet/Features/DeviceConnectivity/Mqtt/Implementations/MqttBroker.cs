using System.Threading.Tasks;
using MQTTnet.Protocol;
using MQTTnet.Server;
using MQTTnet;
using MQTTnet.Internal;
using Xunit.Sdk;

namespace dotnet.Features.DeviceConnectivity.Mqtt.Implementations
{
    public class MqttBroker : IMqttBroker
    {

        public bool IsRunning { get; private set; }

        public string? LastPublishedMessage { get; private set;}

        public string? LastPublishedTopic { get; private set;}

        public async Task Run_Minimal_Server()
        {
            await Task.CompletedTask;
        }

        public async Task<bool> Publish_Message_From_Broker(string message, string topic)
        {
            return await Task.FromResult(false);
        }

        public async Task<bool> Disconnect_Client()
        {
            return await Task.FromResult(false);
        }

        static async Task<MqttServer> StartMqttServer()
        {
            var mqttServerFactory = new MqttFactory();

            // Due to security reasons the "default" endpoint (which is unencrypted) is not enabled by default!
            var mqttServerOptions = mqttServerFactory.CreateServerOptionsBuilder().WithDefaultEndpoint().Build();
            var server = mqttServerFactory.CreateMqttServer(mqttServerOptions);
            await server.StartAsync();
            return server;
        }
    }
}