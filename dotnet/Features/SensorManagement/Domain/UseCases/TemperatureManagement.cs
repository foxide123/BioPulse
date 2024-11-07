using dotnet.Features.SensorManagement.Domain.Entities;
using dotnet.Features.SensorManagement.Domain.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace dotnet.Features.SensorManagement.Domain.UseCases
{
    public class TemperatureManagement
    {
        private readonly ISensorManagementRepository _sensorManagementRepository;
        public TemperatureManagement(ISensorManagementRepository sensorManagementRepository)
        {
            _sensorManagementRepository = sensorManagementRepository;
        }

        public TemperatureSensorDto GetById(int id)
        {
            return (TemperatureSensorDto) _sensorManagementRepository.GetById(id);
        }
    }
}