using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelo;
using Vuelos.Domain.Model.Personales;
using Vuelos.Domain.Repositories;

namespace Vuelos.Application.UseCases.Queries.Vuelos.GetVueloById
{
    public class GetVueloByIdQuery : IRequestHandler<GetVueloByIdQuery, VueloDto>
    {
        private readonly IVueloRepository _vueloRepository;
        private readonly ILogger<GetVueloByIdQuery> _logger;

    public GetVueloByIdHandler(IVueloRepository vueloRepository, ILogger<GetVueloByIdQuery> logger)
    {
        _vueloRepository = vueloRepository;
        _logger = logger;
    }

    public async Task<VueloDto> Handle(GetVueloByIdQuery request, CancellationToken cancellationToken)
    {
        VueloDto result = null;
        try
        {
            Vuelo objVuelo = await _vueloRepository.FindByIdAsync(request.Id);

            result = new VueloDto()
            {
                Id = objVuelo.Id,
                NroVuelo = objVuelo.NroVuelo,
                //Total = objVuelo.Total
            };

            foreach (var item in objVuelo.Tripulantes)
            {
                result.Tripulantes.Add(new TripulanteVueloDto()
                {
                    //Cantidad = item.Cantidad,
                    //Instrucciones = item.Instrucciones,
                    //Precio = item.Precio,
                    PersonalId = item.PersonalId
                });
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al obtener Vuelo con id: { VueloId }", request.Id);
        }

        return result;
    }
}
}
