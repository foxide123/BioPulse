using System.Threading.Tasks;

namespace dotnet.Features.DeviceConnectivity.Mqtt
{
    public interface IMqttBroker
    {
        Task Run_Minimal_Server();
        Task<bool> Publish_Message_From_Broker(string message, string topic);
        Task<bool> Disconnect_Client();
    }
}