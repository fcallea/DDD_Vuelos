using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aereonaves;
using Vuelos.Domain.Model.Destinos;

namespace Vuelos.Domain.Factories
{
    public class DestinoFactory : IAeronaveFactory
    {
        public Destino Create(Guid AereopuertoIdOrigen, Guid AereopuertoIdDestino, decimal DistanciaMillas, TimeSpan TiempoMinutos)
        {
            return new Destino(AereopuertoIdOrigen, AereopuertoIdDestino, DistanciaMillas, TiempoMinutos);
        }

        public Aeronave Create(string nombreAeronave, int nroAsientos)
        {
            throw new NotImplementedException();
        }
    }
}
