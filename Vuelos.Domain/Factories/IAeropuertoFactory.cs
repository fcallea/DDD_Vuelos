using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aereopuertos;

namespace Vuelos.Domain.Factories
{
    public interface IAeropuertoFactory
    {
        Aeropuerto Create(string pais, string localidad, string nombre);
    }
}
