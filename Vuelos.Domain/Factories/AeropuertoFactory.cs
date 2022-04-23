using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aereonaves;
using Vuelos.Domain.Model.Aereopuertos;

namespace Vuelos.Domain.Factories
{
    public class AeropuertoFactory : IAeronaveFactory
    {
        public Aeropuerto Create(string pais, string localidad, string nombre)
        {
            return new Aeropuerto(pais, localidad, nombre);
        }

        public Aeronave Create(string nombreAeronave, int nroAsientos)
        {
            throw new NotImplementedException();
        }
    }
}
