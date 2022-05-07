using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Services
{
    public class VueloService : IVueloService
    {
        public Task<Guid> CrearLugarOrigenAsync() => Task.FromResult(Guid.NewGuid());
        public Task<Guid> CrearLugarDestinoAsync() => Task.FromResult(Guid.NewGuid());
        public Task<DateTime> CrearFechaHoraPartidaAsync() => Task.FromResult(DateTime.Now);
        public Task<DateTime> CrearFechaHoraLlegadaAsync() => Task.FromResult(DateTime.Now);
        public Task<string> CrearTipoVueloAsync() => Task.FromResult("COMERCIAL");
        public Task<decimal> CrearMillasVueloAsync() => Task.FromResult(1234.2m);
        public Task<decimal> CrearTiempoVueloAsync() => Task.FromResult(789.2m);
    }
}
