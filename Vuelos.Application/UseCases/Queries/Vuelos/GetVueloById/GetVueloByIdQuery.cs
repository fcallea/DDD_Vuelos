using MediatR;
using System;
using Vuelos.Application.Dto.Vuelo;

namespace Vuelos.Application.UseCases.Queries.Vuelos.GetVueloById {
    public class GetVueloByIdQuery : IRequest<VueloDto> {
        public Guid Id { get; set; }

        public GetVueloByIdQuery(Guid id) {
            Id = id;
        }

        public GetVueloByIdQuery() { }
    }
}
