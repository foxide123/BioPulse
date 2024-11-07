using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dotnet.Features.SensorManagement.Domain.Entities
{
    public class TemperatureSensorDto : SensorDto{
        public TemperatureSensorDto(SensorDto sensorDto) 
            : base(sensorDto.Id, sensorDto.Name, sensorDto.IsEnabled, sensorDto.IsWireless,
                    sensorDto.CurrentReadingValue, sensorDto.CurrentReadingTime) {}
    }

}
