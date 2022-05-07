using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Vuelos;

namespace Vuelos.Domain.Factories
{
    public interface IVueloFactory
    {
        Vuelo Create(Guid IdLugarOrigen, Guid IdLugarDestino
            , Guid IdItinerario, Guid IdAeronave, string NroVuelo
            , Guid IdTripulacion
            , DateTime FechaHoraPartida, DateTime FechaHoraLlegada
            , String TipoVuelo
            , decimal MillasVuelo, decimal TiempoVuelo);
    }
}