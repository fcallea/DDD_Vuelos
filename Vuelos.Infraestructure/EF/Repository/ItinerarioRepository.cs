using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Itinerarios;
using Vuelos.Domain.Repositories;
using Vuelos.Infraestructure.EF.Contexts;

namespace Vuelos.Infraestructure.EF.Repository
{
    public class ItinerarioRepository : IItinerarioRepository
    {

        public Task CreateAsync(Itinerario obj)
        {
            Console.WriteLine($"INSERTANDO EL itinerario {obj.NroVuelo}");
            return Task.CompletedTask;
        }

        public Task<Itinerario> FindByIdAsync(Guid id)
        {
            Console.WriteLine($"BUSCANDO POR EL VUELO {id}");
            return null;
        }

        public Task UpdateAsync(Itinerario obj)
        {
            Console.WriteLine($"ACTUALIZANDO EL VUELO {obj.NroVuelo}");
            return Task.CompletedTask;
        }
/*

        public readonly DbSet<Itinerario> _itinerario;

        public ItinerarioRepository(WriteDbContext context)
        {
            _itinerario = context.Itinerario;
        }

        public async Task CreateAsync(Itinerario obj)
        {
            await _itinerario.AddAsync(obj);
        }

        public async Task<Itinerario> FindByIdAsync(Guid id)
        {
            return await _itinerario.Include("_vuelos")
                    .SingleAsync(x => x.Id == id);
        }

        public Task UpdateAsync(Itinerario obj)
        {
            _itinerario.Update(obj);

            return Task.CompletedTask;
        }
*/

    }
}
