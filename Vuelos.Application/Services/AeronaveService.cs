using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Services
{
    public class AeronaveService : IAeronaveService
    {
        public Task<Guid> ObtenerIdAeronaveAsync() => Task.FromResult(Guid.NewGuid());
        public Task<int> ObtenerNroAsientosAsync() => Task.FromResult(50);
    }
}
