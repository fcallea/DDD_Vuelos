using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelo;

namespace Vuelos.Application.UseCases.Command.Vuelos.CrearVuelo {
    public class CrearVueloCommand : IRequest<Guid> {
        public VueloDto Vuelo { get; set; }
        private CrearVueloCommand() { }
        public CrearVueloCommand(VueloDto vuelo) {
            Vuelo = vuelo;
        }
    }
}
