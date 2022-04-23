using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vuelos.Application.Services;
using Vuelos.Domain.Factories;
using Vuelos.Domain.Model.Vuelos;
using Vuelos.Domain.Repositories;


namespace Vuelos.Application.UseCases.Command.Vuelos.CrearVuelo
{
   public class CrearVueloHandler : IRequestHandler<CrearVueloCommand, Guid>
    {
        private readonly IVueloRepository _vueloRepository;
        private readonly ILogger<CrearVueloHandler> _logger;
        private readonly IVueloService _vueloService;
        private readonly IVueloFactory _vueloFactory;
        private readonly IUnitOfWork _unitOfWork;

        public CrearVueloHandler(IVueloRepository vueloRepository, ILogger<CrearVueloHandler> logger,
            IVueloService vueloService, IVueloFactory vueloFactory, IUnitOfWork unitOfWork)
        {
            _vueloRepository = vueloRepository;
            _logger = logger;
            _vueloService = vueloService;
            _vueloFactory = vueloFactory;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CrearVueloCommand request, CancellationToken cancellationToken)
        {
            try
            {
                string nroVuelo = await _vueloService.GenerarNroVueloAsync();
                //Vuelo objVuelo = _vueloFactory.Create(nroVuelo);

                foreach (var item in request.Tripulantes)
                {
                   // objVuelo.AgregarItem(item.ProductoId, item.Cantidad, item.Precio, item.Instrucciones);
                }

                objVuelo.ConsolidarVuelo();

                await _vueloRepository.CreateAsync(objVuelo);

                await _unitOfWork.Commit();

                return objVuelo.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear vuelo");
            }
            return Guid.Empty;
        }
    }
}
