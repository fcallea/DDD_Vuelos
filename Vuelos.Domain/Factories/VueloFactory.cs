using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Personales;
using Vuelos.Domain.Model.Vuelos;

namespace Vuelos.Domain.Factories
{
    public class VueloFactory : IVueloFactory
    {
        public Vuelo Create(Guid DestinoId, string NroVuelo, DateTime Fecha, TimeSpan HoraPartida, TimeSpan HoraLlegada, string TipoVuelo, Guid AeronaveEnPistaId)
        {
            return new Vuelo(DestinoId, NroVuelo, Fecha, HoraPartida, HoraLlegada, TipoVuelo, AeronaveEnPistaId);
        }
    }
}
