using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Services
{
    public class ItinerarioService : IItinerarioService
    {
        public Task<Guid> ObtenerIdItinerarioAsync() => Task.FromResult(Guid.NewGuid());
        public Task<Guid> ObtenerIdPistaAsync() => Task.FromResult(Guid.NewGuid());
        public Task<Guid> ObtenerIdAeronaveAsync() => Task.FromResult(Guid.NewGuid());
        public Task<string> ObtenerNroVueloAsync() => Task.FromResult("VUELO-001");
    }
}
