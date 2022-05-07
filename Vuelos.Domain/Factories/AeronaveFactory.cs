using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeronaves;

namespace Vuelos.Domain.Factories
{
    public class AeronaveFactory : IAeronaveFactory
    {
        public Aeronave Create(string Estado, int NroAsientos, string Marca, string Modelo, decimal CapacidadCarga, decimal CapacidadTanque)
        {
            return new Aeronave(Estado, NroAsientos, Marca, Modelo, CapacidadCarga, CapacidadTanque);
        }
    }
}
