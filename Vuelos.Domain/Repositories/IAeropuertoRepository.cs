using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeropuertos;

namespace Vuelos.Domain.Repositories {
    public interface IAeropuertoRepository : IRepository<Aeropuerto, Guid> {
        Task UpdateAsync(Aeropuerto obj);

        Task RemoveAsync(Aeropuerto obj);
    }
}
