using System.Collections.Generic;
using dotnet.Features.SensorManagement.Domain.Entities;

namespace dotnet.Features.SensorManagement.Domain.Repositories{
    public interface ISensorManagementRepository
    {
        SensorDto GetById(int id);
        IEnumerable<SensorDto> GetAll();
        void Add(SensorDto entity);
        void Update(SensorDto entity);
        void Delete(SensorDto entity);
    }
}