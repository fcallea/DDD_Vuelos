using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Services
{
    public class PistaService : IPistaService
    {
        public Task<string> AsignarNroVueloAsync() => Task.FromResult("V-000001");
        public Task<Guid> ObtenerIdPistaAsync() => Task.FromResult(Guid.NewGuid());
    }
}
