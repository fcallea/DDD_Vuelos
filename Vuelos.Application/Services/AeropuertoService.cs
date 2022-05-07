using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Services
{
    internal class AeropuertoService : IAeropuertoService
    {
        public Task<string> GenerarNroVueloAsync() => Task.FromResult("VUELO-XXX");
    }
}
