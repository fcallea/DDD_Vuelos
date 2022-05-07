using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Services
{
    internal class TripulacionService : ITripulacionService
    {
        public Task<Guid> CrearTripulacionAsync() => Task.FromResult(Guid.NewGuid());
    }
}
