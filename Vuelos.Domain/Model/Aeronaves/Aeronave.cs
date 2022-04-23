using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Aereonaves
{
    public class Aeronave : AggregateRoot<Guid>
    {
        public string NombreAeronave { get; set; }
        public int NroAsientos { get; set; }

        public Aeronave(string nombreAeronave, int nroAsientos)
        {
            Id = Guid.NewGuid();
            NombreAeronave = nombreAeronave;
            NroAsientos = nroAsientos;
        }
    }
}
