using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Itinerarios;

namespace Vuelos.Domain.Repositories {
    public interface IItinerarioRepository : IRepository<Itinerario, Guid> {
        Task UpdateAsync(Itinerario obj);
        Task CreateAsync(Itinerario obj);
        //Task RemoveAsync(Itinerario obj);
    }
}
