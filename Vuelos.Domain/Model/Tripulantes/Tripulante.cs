using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Tripulantes.Cargos;

namespace Vuelos.Domain.Model.Tripulantes
{
    internal class Tripulante : Entity<Guid>
    {
        public PersonNameValue Nombre { get; private set; }
        public Guid IdPersonal { get; private set; }
        public CargoTripulante Cargo { get; private set; }


        public Tripulante(PersonNameValue nombre, Guid idPersonal, CargoTripulante cargo)
        {
            Id = Guid.NewGuid();
            this.Nombre = nombre;
            this.IdPersonal = idPersonal;
            this.Cargo = cargo;
        }
    }
}
