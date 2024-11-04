using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet.Features.TemperatureSensor.Models
{
    public class TemperatureSensor
    {
        // Id for the temperature sensor
        public int Id { get; set; }

        /* Location of the sensor (ex. water tank, air, can be also TYPE of temperature sensor.)
        public string Location { get; set; }*/

        // Current temperature reading 
        public double CurrentTemperature { get; set; }

        // Timestamp of the last reading
        public DateTime LastReadingTime { get; set; }

        //  update the temperature reading mnethod
        public void UpdateTemperature(double newTemperature)
        {
            CurrentTemperature = newTemperature;
            LastReadingTime = DateTime.Now; 
        }

        
    }
}
