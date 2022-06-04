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
using Vuelos.Domain.Event;
using Vuelos.Domain.Factories;
using Vuelos.Domain.Model.Itinerarios;
using Vuelos.Domain.Repositories;
using Xunit;

namespace Vuelos.Test.Application.UsesCases.Command.Vuelos.AsignarItinerario
{
    public class AsignarItinerarioHandler_Tests
    {
        private readonly Mock<IItinerarioRepository> itinerarioRepository;
        private readonly Mock<ILogger<AsignarItinerarioHandler>> logger;
        private readonly Mock<IItinerarioService> itinerarioService;
        private readonly Mock<IItinerarioFactory> itinerarioFactory;
        private readonly Mock<IUnitOfWork> unitOfWork;

        private Guid idPista = Guid.NewGuid();
        private Guid idAeronave = Guid.NewGuid();
        private int nroVuelo = 789;
        private DateTime fechaHoraDesde = DateTime.Now;
        private DateTime fechaHoraHasta = DateTime.Now;
        private ItinerarioDto itinerarioDtoTest;
        private Itinerario itinerarioTest;

        public AsignarItinerarioHandler_Tests()
        {
            itinerarioRepository = new Mock<IItinerarioRepository>();
            logger = new Mock<ILogger<AsignarItinerarioHandler>>();
            itinerarioService = new Mock<IItinerarioService>();
            itinerarioFactory = new Mock<IItinerarioFactory>();
            unitOfWork = new Mock<IUnitOfWork>();

            itinerarioTest = new ItinerarioFactory().Create(idPista, idAeronave, nroVuelo, fechaHoraDesde, fechaHoraHasta);

        }


        [Fact]
        public void AsignarItinerarioHandler_HandleCorrectly()
        {
            itinerarioFactory.Setup(factory => factory.Create(idPista, idAeronave, nroVuelo, fechaHoraDesde, fechaHoraHasta))
                .Returns(itinerarioTest);

            var objHandler = new AsignarItinerarioHandler(
                itinerarioRepository.Object,
                logger.Object,
                itinerarioService.Object,
                itinerarioFactory.Object,
                unitOfWork.Object
            );
            var objRequest = new AsignarItinerarioCommand(
               itinerarioDtoTest
           );
            var tcs = new CancellationTokenSource(1000);
            var result = objHandler.Handle(objRequest, tcs.Token);
            Assert.IsType<Guid>(result.Result);

            var domainEventList = (List<DomainEvent>)itinerarioTest.DomainEvents;
            Assert.Single(domainEventList);
            Assert.IsType<ItinerarioAsignado>(domainEventList[0]);
        }
        [Fact]
        public void CrearProductoHandler_Handle_Fail()
        {
            // Failing by returning null values
            var objHandler = new AsignarItinerarioHandler(
                itinerarioRepository.Object,
                logger.Object,
                itinerarioService.Object,
                itinerarioFactory.Object,
                unitOfWork.Object
            );
            var objRequest = new AsignarItinerarioCommand(
               itinerarioDtoTest
           ) ;
            var tcs = new CancellationTokenSource(1000);
            var result = objHandler.Handle(objRequest, tcs.Token);
            logger.Verify(mock => mock.Log(
                It.Is<LogLevel>(logLevel => logLevel == LogLevel.Error),
                It.Is<EventId>(eventId => eventId.Id == 0),
                It.Is<It.IsAnyType>((@object, @type) => @object.ToString() == "Error al crear itinerario"),
                It.IsAny<Exception>(),
                It.IsAny<Func<It.IsAnyType, Exception, string>>())
            , Times.Once);
        }
    }
}
