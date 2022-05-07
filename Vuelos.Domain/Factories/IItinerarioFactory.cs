using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Itinerarios;

namespace Vuelos.Domain.Factories
{
    public interface IItinerarioFactory
    {       
        Itinerario Create(Guid IdPista, Guid IdAeronave, string NroVuelo, DateTime FechaHoraDesde, DateTime FechaHoraHasta);
        Task CreateAsync(Itinerario objItinerario);
    }
}
