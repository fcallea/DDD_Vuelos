using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Itinerarios;

namespace Vuelos.Domain.Model.Aeropuertos {
    public class Pista : Entity<Guid> {
        private readonly ICollection<Itinerario> _Itinerarios;
        public IReadOnlyCollection<Itinerario> Itinerarios {
            get {
                return new ReadOnlyCollection<Itinerario>(_Itinerarios.ToList());
            }
        }

        internal Pista() {
            Id = Guid.NewGuid();
            _Itinerarios = new List<Itinerario>();
        }
    }
}
