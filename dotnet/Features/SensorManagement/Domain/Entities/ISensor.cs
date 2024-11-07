using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet.Features.SensorManagement.Domain.Entities
{
    public interface ISensor
    {
        // Id for the temperature sensor
        int Id { get; set; }
        string Name { get; set; }
        // Is sensor active?

        bool IsEnabled { get; set; }



        //Is sensor wireless?

        bool IsWireless { get; set; }


        // Last temperature reading 
        double CurrentReadingValue { get; set; }

        // Timestamp of the last reading
        DateTime CurrentReadingTime { get; set; }



        //  update the last reading method
        void UpdateReadingValue(double lastReadingValue);


    }
}
