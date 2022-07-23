using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeropuertos;
using Vuelos.Domain.Model.Vuelos;

namespace Vuelos.Domain.Model.Lugares {
    public class Lugar : AggregateRoot<Guid> {
        public Guid IdLocalidad { get; private set; }
        private readonly ICollection<Vuelo> _Vuelos;
        public IReadOnlyCollection<Vuelo> Vuelos {
            get {
                return new ReadOnlyCollection<Vuelo>(_Vuelos.ToList());
            }
        }
        private readonly ICollection<Aeropuerto> _Aeropuertos;
        public IReadOnlyCollection<Aeropuerto> Aeropuertos {
            get {
                return new ReadOnlyCollection<Aeropuerto>(_Aeropuertos.ToList());
            }
        }

        public Lugar(Guid IdLocalidad) {
            Id = Guid.NewGuid();
            this.IdLocalidad = IdLocalidad;

            _Vuelos = new List<Vuelo>();
            _Aeropuertos = new List<Aeropuerto>();
        }

    }
}
