using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Vuelos;

namespace Vuelos.Domain.Factories
{
    public class VueloFactory : IVueloFactory
    {
        public Vuelo Create(Guid IdLugarOrigen, Guid IdLugarDestino
            , Guid IdItinerario, Guid IdAeronave, int NroVuelo
            , Guid IdTripulacion
            , DateTime FechaHoraPartida, DateTime FechaHoraLlegada
            , String TipoVuelo
            , decimal MillasVuelo, decimal TiempoVuelo)
        {
            return new Vuelo(IdLugarOrigen, IdLugarDestino, IdItinerario, IdAeronave, NroVuelo, IdTripulacion, FechaHoraPartida, FechaHoraLlegada, TipoVuelo, MillasVuelo, TiempoVuelo);
        }
    }
}
