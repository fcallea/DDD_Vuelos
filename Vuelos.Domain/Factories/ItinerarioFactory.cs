using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Itinerarios;

namespace Vuelos.Domain.Factories {
    public class ItinerarioFactory : IItinerarioFactory {
        public Itinerario Create(Guid IdPista, Guid IdAeronave, int NroVuelo, DateTime FechaHoraDesde, DateTime FechaHoraHasta) {
            return new Itinerario(IdPista, IdAeronave, NroVuelo, FechaHoraDesde, FechaHoraHasta);
        }

        //public Task CreateAsync(Itinerario objItinerario)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
