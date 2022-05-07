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
using Vuelos.Domain.Model.Itinerarios;
using Vuelos.Domain.Repositories;

namespace Vuelos.Application.UseCases.Command.Vuelos.AsignarItinerario
{
    public class AsignarItinerarioHandler : IRequestHandler<AsignarItinerarioCommand, Guid>
    {
        private readonly IItinerarioRepository _itinerarioRepository;
        private readonly ILogger<AsignarItinerarioHandler> _logger;
        private readonly IItinerarioService _itinerarioService;
        private readonly IPistaService _ipistaService;
        private readonly IAeronaveService _iaeronaveService;
        private readonly IItinerarioFactory _itinerarioFactory;
        private readonly IUnitOfWork _unitOfWork;

        public AsignarItinerarioHandler(
              IItinerarioRepository itinerarioRepository
            , ILogger<AsignarItinerarioHandler> logger
            , IItinerarioService itinerarioService
            , IPistaService ipistaService
            , IAeronaveService iaeronaveService
            , IItinerarioFactory itinerarioFactory
            , IUnitOfWork unitOfWork)
        {
            _itinerarioRepository = itinerarioRepository;
            _logger = logger;
            _itinerarioService = itinerarioService;
            _ipistaService = ipistaService;
            _iaeronaveService = iaeronaveService;
            _itinerarioFactory = itinerarioFactory;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(AsignarItinerarioHandler request, CancellationToken cancellationToken)
        {
            try
            {
                string nroVuelo = await _ipistaService.AsignarNroVueloAsync();
                DateTime fechaHoraDesde = await _itinerarioService.ObtenerFechaDesdeAsync();
                DateTime fechaHoraHasta = await _itinerarioService.ObtenerFechaHastaAsync();
                Guid idItinerario = await _itinerarioService.ObtenerIdItinerarioAsync();
                
                Guid idPista = await request._itinerarioService.ObtenerIdPistaAsync();
                Guid idAeronave = await request._itinerarioService.ObtenerIdAeronaveAsync();

                //Guid idPista = await request.Itinerario.IdPista;
                //Guid idAeronave = await request.Itinerario.IdAeronave;
                Itinerario objItinerario = _itinerarioFactory.Create(idPista, idAeronave, nroVuelo, fechaHoraDesde, fechaHoraHasta);

                objItinerario.ConfirmarItinerario();

                await _itinerarioFactory.CreateAsync(objItinerario);

                await _unitOfWork.Commit();

                return objItinerario.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al confirmar Itinerario");
            }
            return Guid.Empty;
        }

        Task<Guid> IRequestHandler<AsignarItinerarioCommand, Guid>.Handle(AsignarItinerarioCommand request, CancellationToken cancellationToken)
        {          
            throw new NotImplementedException();
        }
    }
}
