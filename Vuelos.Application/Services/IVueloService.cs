using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Services
{
    public interface IVueloService
    {
        Task<Guid> CrearLugarOrigenAsync();
        Task<Guid> CrearLugarDestinoAsync();
        Task<DateTime> CrearFechaHoraPartidaAsync();
        Task<DateTime> CrearFechaHoraLlegadaAsync();
        Task<string> CrearTipoVueloAsync();
        Task<decimal> CrearMillasVueloAsync();
        Task<decimal> CrearTiempoVueloAsync();
    }
}
