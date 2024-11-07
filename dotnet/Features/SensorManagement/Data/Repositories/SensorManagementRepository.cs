using System.Collections.Generic;
using System.Linq;
using dotnet.Features.SensorManagement.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using dotnet.Features.SensorManagement.Data.DataSources;
using dotnet.Features.SensorManagement.Domain.Entities;
using dotnet.Features.SensorManagement.Data.Models;

public class SensorManagementRepository : ISensorManagementRepository
{

    private readonly SensorManagementLocalDataSource _localDataSource;

    public SensorManagementRepository(SensorManagementLocalDataSource localDataSource)
    {
        _localDataSource = localDataSource;
    }

    public SensorDto GetById(int id)
    {
        var sensorDao = _localDataSource.GetById(id);
        //Write dao - dto conversion or mapper class
        return new SensorDto();
    }

    public IEnumerable<SensorDto> GetAll()
    {
        var collectionSensorDao = _localDataSource.GetAll();
        //Write dao - dto conversion or mapper class
        return [];
    }

    public void Add(SensorDto entity)
    {
        var sensorDao = new SensorDao();
        //Write dto - dao conversion or mapper class
        _localDataSource.Add(sensorDao);
    }

    public void Update(SensorDto entity)
    {
        var sensorDao = new SensorDao();
        //Write dto - dao conversion or mapper class
        _localDataSource.Update(sensorDao);
    }

    public void Delete(SensorDto entity)
    {
        var sensorDao = new SensorDao();
        //Write dto - dao conversion or mapper class
        _localDataSource.Delete(sensorDao);
    }
}