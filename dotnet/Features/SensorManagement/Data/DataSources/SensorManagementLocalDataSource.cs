using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using dotnet.Features.SensorManagement.Data.Models;

namespace dotnet.Features.SensorManagement.Data.DataSources
{
    public class SensorManagementLocalDataSource
    {
        private readonly DbContext _context;
        private readonly DbSet<SensorDao> _dbSet;

        public SensorManagementLocalDataSource(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<SensorDao>();
        }

        public SensorDao GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<SensorDao> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Add(SensorDao entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(SensorDao entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(SensorDao entity)
        {
            _dbSet.Remove(entity);
        }
    }
}