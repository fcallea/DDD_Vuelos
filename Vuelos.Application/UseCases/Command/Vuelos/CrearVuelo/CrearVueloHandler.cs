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
        private readonly IItinerarioService _itinerarioService;
        private readonly ITripulacionService _itripulacionService;
        private readonly IVueloService _ivueloService;
        private readonly IVueloFactory _vueloFactory;
        private readonly IUnitOfWork _unitOfWork;

        public CrearVueloHandler(
              IVueloRepository vueloRepository
            , ILogger<CrearVueloHandler> logger
            , IItinerarioService itinerarioService
            , ITripulacionService itripulacionService
            , IVueloService ivueloService
            , IVueloFactory vueloFactory
            , IUnitOfWork unitOfWork)
        {
            _vueloRepository = vueloRepository;
            _logger = logger;
            _itinerarioService = itinerarioService;
            _itripulacionService = itripulacionService;
            _ivueloService = ivueloService;
            _vueloFactory = vueloFactory;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CrearVueloCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Guid idTripulacion = await _itripulacionService.CrearTripulacionAsync();
                Guid idLugarDestino = await _ivueloService.CrearLugarDestinoAsync();
                DateTime fechaHoraPartida = await _ivueloService.CrearFechaHoraPartidaAsync();
                DateTime fechaHoraLlegada = await _ivueloService.CrearFechaHoraLlegadaAsync();
                string tipoVuelo = await _ivueloService.CrearTipoVueloAsync();
                decimal millasVuelo = await _ivueloService.CrearMillasVueloAsync();
                Guid idItinerario = await _itinerarioService.ObtenerIdItinerarioAsync();

                Guid idAeronave = await _itinerarioService.ObtenerIdAeronaveAsync();
                string nroVuelo = await _itinerarioService.ObtenerNroVueloAsync();
                Guid idLugarOrigen = await _ivueloService.CrearLugarOrigenAsync();
                decimal tiempoVuelo = await _ivueloService.CrearTiempoVueloAsync();

                //Guid idLugarDestino = request.Vuelo.IdLugarDestino;
                //Guid idItinerario = request.Vuelo.IdItinerario;
                //Guid idTripulacion = request.Vuelo.IdTripulacion;
                //DateTime fechaHoraPartida = request.Vuelo.FechaHoraPartida;
                //DateTime fechaHoraLlegada = request.Vuelo.FechaHoraLlegada;
                //string tipoVuelo = request.Vuelo.TipoVuelo;
                //decimal millasVuelo = request.Vuelo.MillasVuelo;

                Vuelo objVuelo = _vueloFactory.Create(idLugarOrigen, idLugarDestino
                , idItinerario, idAeronave, nroVuelo
                , idTripulacion
                , fechaHoraPartida, fechaHoraLlegada
                , tipoVuelo
                , millasVuelo, tiempoVuelo);

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
