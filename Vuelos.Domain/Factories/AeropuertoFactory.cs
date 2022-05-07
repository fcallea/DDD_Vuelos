using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeropuertos;

namespace Vuelos.Domain.Factories
{
    public class AeropuertoFactory : IAeropuertoFactory
    {
        public Aeropuerto Create(Guid IdLugarAeropuerto, string NombreAeropuerto)
        {
            return new Aeropuerto(IdLugarAeropuerto, NombreAeropuerto);
        }
    }
}
