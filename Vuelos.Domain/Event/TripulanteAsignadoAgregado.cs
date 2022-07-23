using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Event {
    public record TripulanteAsignadoAgregado : DomainEvent {
        public Guid PersonalId { get; }
        public string Usuario { get; }
        public string Cargo { get; }

        public TripulanteAsignadoAgregado(Guid personalId, string usuario, string cargo) : base(DateTime.Now) {
            PersonalId = personalId;
            Usuario = usuario;
            Cargo = cargo;
        }
    }
}
