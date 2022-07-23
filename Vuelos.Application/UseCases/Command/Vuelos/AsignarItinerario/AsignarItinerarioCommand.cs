using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelo;

namespace Vuelos.Application.UseCases.Command.Vuelos.AsignarItinerario {
    public class AsignarItinerarioCommand : IRequest<Guid> {
        public ItinerarioDto Itinerario { get; set; }
        private AsignarItinerarioCommand() { }
        public AsignarItinerarioCommand(ItinerarioDto itinerario) {
            Itinerario = itinerario;
        }
    }
}
