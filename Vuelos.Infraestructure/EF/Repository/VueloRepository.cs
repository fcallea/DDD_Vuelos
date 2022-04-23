using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Personales;
using Vuelos.Domain.Repositories;

namespace Vuelos.Infraestructure.EF.Repository
{
    public class VueloRepository : IVueloRepository
    {
        public Task CreateAsync(Vuelo obj)
        {
            Console.WriteLine($"Insertando el vuelo { obj.NroVuelo }");

            return Task.CompletedTask;
        }

        public Task<Vuelo> FindByIdAsync(Guid id)
        {
            Console.WriteLine($"Retornando el vuelo { id }");

            return null;
        }

        public Task UpdateAsync(Vuelo obj)
        {
            Console.WriteLine($"Actualizando el vuelo { obj.NroVuelo }");

            return Task.CompletedTask;
        }
    }
}
