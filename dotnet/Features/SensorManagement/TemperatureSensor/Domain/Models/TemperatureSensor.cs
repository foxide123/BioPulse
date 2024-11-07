using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnet.Features.SensorManagement.TemperatureSensor.Interfaces;
namespace dotnet.Features.SensorManagement.TemperatureSensor.Domain.Models
{
    public class TemperatureSensor : ISensor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsWireless { get; set; }
        public double CurentReadingValue { get; set; }
        public DateTime CurentReadingTime { get; set; }
        public void UpdateReadingValue(double lastReadingValue)
        {
            CurentReadingValue = lastReadingValue;
            CurentReadingTime = DateTime.Now;
        }
    }

}
