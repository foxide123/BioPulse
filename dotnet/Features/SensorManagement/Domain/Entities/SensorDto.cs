using System;

namespace dotnet.Features.SensorManagement.Domain.Entities
{
    public class SensorDto : ISensor
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsWireless { get; set; }
        public double CurrentReadingValue { get; set; }
        public DateTime CurrentReadingTime { get; set; }
        public void UpdateReadingValue(double lastReadingValue)
        {
            CurrentReadingValue = lastReadingValue;
            CurrentReadingTime = DateTime.Now;
        }

        public SensorDto(int id, string name, bool isEnabled, bool isWireless, double currentReadingValue,
            DateTime currentReadingTime){
            
            Id = id;
            Name = name;
            IsEnabled = isEnabled;
            IsWireless = isWireless;
            CurrentReadingValue = currentReadingValue;
            CurrentReadingTime = currentReadingTime;
        }

        public SensorDto(){}
    }
}