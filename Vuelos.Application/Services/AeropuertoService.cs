using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Services
{
    public class AeropuertoService : IAeropuertoService
    {
        public Task<int> GenerarNroVueloAsync() => Task.FromResult(123);
    }
}
