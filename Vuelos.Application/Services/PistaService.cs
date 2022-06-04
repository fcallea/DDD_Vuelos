using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Services
{
    public class PistaService : IPistaService
    {
        public Task<int> AsignarNroVueloAsync() => Task.FromResult(456);
        public Task<Guid> GetIdPistaAsync() => Task.FromResult(Guid.NewGuid());
    }
}
