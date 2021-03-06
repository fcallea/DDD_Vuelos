using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Vuelos;
using Vuelos.Domain.Repositories;
using Vuelos.Infraestructure.EF.Contexts;

namespace Vuelos.Infraestructure.EF.Repository {
    public class VueloRepository : IVueloRepository {
        public Task CreateAsync(Vuelo obj) {
            Console.WriteLine($"INSERTANDO EL VUELO {obj.NroVuelo}");
            return Task.CompletedTask;
        }

        public Task<Vuelo> FindByIdAsync(Guid id) {
            Console.WriteLine($"BUSCANDO POR EL VUELO {id}");
            return (Task<Vuelo>)Task.CompletedTask;
        }

        public Task UpdateAsync(Vuelo obj) {
            Console.WriteLine($"ACTUALIZANDO EL VUELO {obj.NroVuelo}");
            return Task.CompletedTask;
        }
        /*
        public readonly DbSet<Vuelo> _vuelos;

        public VueloRepository(WriteDbContext context)
        {
            _vuelos = context.Vuelo;
        }

        public async Task CreateAsync(Vuelo obj)
        {
            await _vuelos.AddAsync(obj);
        }

        public async Task<Vuelo> FindByIdAsync(Guid id)
        {
            return await _vuelos.Include("_vuelos")
                    .SingleAsync(x => x.Id == id);
        }
        
        public Task UpdateAsync(Vuelo obj)
        {
            _vuelos.Update(obj);

            return Task.CompletedTask;
        }
        */
    }
}
