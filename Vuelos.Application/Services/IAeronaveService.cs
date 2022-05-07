using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Services
{
    public interface IAeronaveService
    {
        Task<Guid> ObtenerIdAeronaveAsync();
        Task<int> ObtenerNroAsientosAsync();
    }
}
