using Microsoft.Extensions.Logging;
using Moq;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelo;
using Vuelos.Application.Services;
using Vuelos.Application.UseCases.Command.Vuelos.AsignarItinerario;
using Vuelos.Application.UseCases.Command.Vuelos.CrearVuelo;
using Vuelos.Domain.Event;
using Vuelos.Domain.Factories;
using Vuelos.Domain.Model.Vuelos;
using Vuelos.Domain.Repositories;
using Vuelos.Domain.ValueObjects;
using Xunit;

namespace Vuelos.Test.Application.UsesCases.Command.Vuelos.CrearVuelo
{
    public class CrearVueloHandler_Tests
    {
        private readonly Mock<IVueloRepository> vueloRepository;
        private readonly Mock<ILogger<CrearVueloHandler>> logger;
        private readonly Mock<IItinerarioService> itinerarioService;
        //private readonly Mock<IVueloFactory> vueloFactory;
        private readonly Mock<IUnitOfWork> unitOfWork;

        Guid IdLugarOrigen = Guid.NewGuid();
        Guid IdLugarDestino = Guid.NewGuid();
        Guid IdItinerario = Guid.NewGuid();
        Guid IdAeronave = Guid.NewGuid();
        Guid IdTripulacion = Guid.NewGuid();
        NroVueloValue NroVuelo = new NroVueloValue(123);
        FechaValue FechaHoraPartida = new FechaValue(DateTime.Now);
        FechaValue FechaHoraLlegada = new FechaValue(DateTime.Now);
        TipoVueloValue TipoVuelo = new TipoVueloValue("COMERCIAL");
        decimal MillasVuelo = new decimal(20.0);
        decimal TiempoVuelo = new decimal(60.0);
        private VueloDto vueloDtoTest;
        private Vuelo vueloTest;

        public CrearVueloHandler_Tests()
        {
            vueloRepository = new Mock<IVueloRepository>();
            logger = new Mock<ILogger<CrearVueloHandler>>();
            itinerarioService = new Mock<IItinerarioService>();
            unitOfWork = new Mock<IUnitOfWork>();
            vueloDtoTest = new VueloDto();
            vueloDtoTest.IdLugarOrigen = this.IdLugarOrigen;
            vueloDtoTest.IdLugarDestino = this.IdLugarDestino;
            vueloDtoTest.IdItinerario = this.IdItinerario;
            vueloDtoTest.IdTripulacion = this.IdTripulacion;
            vueloDtoTest.FechaHoraPartida = this.FechaHoraPartida;
            vueloDtoTest.FechaHoraLlegada = this.FechaHoraLlegada;
            vueloDtoTest.TipoVuelo = this.TipoVuelo;
            vueloDtoTest.MillasVuelo = this.MillasVuelo;
            vueloDtoTest.NroVuelo = this.NroVuelo;

            //vueloTest = new vueloFactory().Create(idPista, idAeronave, nroVuelo, fechaHoraDesde, fechaHoraHasta);
            vueloTest = new Vuelo(IdLugarOrigen, IdLugarDestino, IdItinerario, IdAeronave, NroVuelo, IdTripulacion
                    , FechaHoraPartida, FechaHoraLlegada
                    , TipoVuelo, MillasVuelo, TiempoVuelo
                    );
        }

        [Fact]
        public void AsignarItinerarioHandler_HandleCorrectly()
        {
            //vueloFactory.Setup(factory => factory.Create(IdLugarOrigen, IdLugarDestino, IdItinerario, IdAeronave, NroVuelo, IdTripulacion, FechaHoraPartida, FechaHoraLlegada, TipoVuelo, MillasVuelo, TiempoVuelo))
            //    .Returns(vueloTest);

            var objHandler = new CrearVueloHandler(
                logger.Object,
                vueloRepository.Object,
                itinerarioService.Object,
                unitOfWork.Object
            );

            var objRequest = new CrearVueloCommand(
               vueloDtoTest
           );
            var tcs = new CancellationTokenSource(1000);
            var result = objHandler.Handle(objRequest, tcs.Token);
            Assert.IsType<Guid>(result.Result);

            var domainEventList = (List<DomainEvent>)vueloTest.DomainEvents;
            Assert.Single(domainEventList);
            Assert.IsType<VueloCreado>(domainEventList[0]);
        }
        [Fact]
        public void CrearProductoHandler_Handle_Fail()
        {
            // Failing by returning null values
            var objHandler = new CrearVueloHandler(
                logger.Object,
                vueloRepository.Object,
                itinerarioService.Object,
                unitOfWork.Object
            );
            var objRequest = new CrearVueloCommand(
               vueloDtoTest
           );
            var tcs = new CancellationTokenSource(1000);
            var result = objHandler.Handle(objRequest, tcs.Token);
            logger.Verify(mock => mock.Log(
                It.Is<LogLevel>(logLevel => logLevel == LogLevel.Error),
                It.Is<EventId>(eventId => eventId.Id == 0),
                It.Is<It.IsAnyType>((@object, @type) => @object.ToString() == "Error al crear vuelo"),
                It.IsAny<Exception>(),
                It.IsAny<Func<It.IsAnyType, Exception, string>>())
            , Times.Once);
        }
    }
}
