using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aereonaves;

namespace Vuelos.Domain.Factories
{
    public interface IAeronaveFactory
    {
        Aeronave Create(string nombreAeronave, int nroAsientos);
    }
}
