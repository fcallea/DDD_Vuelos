using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelo;
using Vuelos.Domain.Model.Vuelos;

namespace Vuelos.Application.UseCases.Command.Vuelos.CrearVuelo
{
    public class CrearVueloCommand : IRequest<Guid>
    {
        private CrearVueloCommand() { }

        public CrearVueloCommand(List<TripulanteDto> tripulante)
        {
            Tripulantes = tripulante;
        }

        public List<TripulanteDto> Tripulantes { get; set; }



    }
}
