using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Services
{
    public interface IItinerarioService
    {
        Task<Guid> ObtenerIdItinerarioAsync();
        Task<Guid> ObtenerIdPistaAsync();
        Task<Guid> ObtenerIdAeronaveAsync();
        Task<string> ObtenerNroVueloAsync();
        Task<DateTime> ObtenerFechaDesdeAsync();
        Task<DateTime> ObtenerFechaHastaAsync();        
            
    }
}
