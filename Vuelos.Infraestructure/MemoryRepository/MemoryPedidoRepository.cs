using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Vuelos;
using Vuelos.Domain.Repositories;

namespace Vuelos.Infraestructure.MemoryRepository
{
    public class MemoryVueloRepository : IVueloRepository
    {
        private readonly MemoryDatabase _database;

        public MemoryVueloRepository(MemoryDatabase database)
        {
            _database = database;
        }

        public Task CreateAsync(Vuelo obj)
        {
            _database.Vuelos.Add(obj);
            return Task.CompletedTask;
        }

        public Task<Vuelo> FindByIdAsync(Guid id)
        {
            return Task.FromResult(_database.Vuelos.FirstOrDefault(x => x.Id == id));
        }

        public Task UpdateAsync(Vuelo obj)
        {
            return Task.CompletedTask;
        }
    }
}
