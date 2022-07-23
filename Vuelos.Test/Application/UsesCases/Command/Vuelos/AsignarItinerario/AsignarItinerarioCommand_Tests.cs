using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelo;
using Vuelos.Application.UseCases.Command.Vuelos.AsignarItinerario;
using Vuelos.Domain.Model.Itinerarios;
using Vuelos.Domain.ValueObjects;
using Xunit;

namespace Vuelos.Test.Application.UsesCases.Command.Vuelos.AsignarItinerario {
    public class AsignarItinerarioCommand_Tests {
        public object MockFactory { get; private set; }

        [Fact]
        public void AsignarItinerarioCommand_DataValid() {
            Guid IdPista = Guid.NewGuid();
            Guid IdAeronave = Guid.NewGuid();
            DateTime fechaHoraDesde = DateTime.Now;
            DateTime fechaHoraHasta = DateTime.Now;
            int NroVuelo = 123;

            ItinerarioDto Itinerario =
                new() {
                    IdPista = Guid.NewGuid(),
                    IdAeronave = Guid.NewGuid(),
                    FechaHoraDesde = fechaHoraDesde,
                    FechaHoraHasta = fechaHoraHasta
                };

            var command = new AsignarItinerarioCommand(Itinerario);

            Assert.NotEqual(IdPista, command.Itinerario.IdPista);
            Assert.NotEqual(IdAeronave, command.Itinerario.IdAeronave);
            Assert.Equal(fechaHoraDesde, command.Itinerario.FechaHoraDesde);
            Assert.Equal(fechaHoraHasta, command.Itinerario.FechaHoraHasta);
        }


        [Fact]
        public void TestConstructor_IsPrivate() {
            var command = (AsignarItinerarioCommand)Activator.CreateInstance(typeof(AsignarItinerarioCommand), true);
            //Assert.Null((object)command.Itinerario.IdPista);
            //Assert.Null((object)command.Itinerario.IdAeronave);
            //Assert.NotNull((object)command.Itinerario.FechaHoraDesde);
            //Assert.NotNull((object)command.Itinerario.FechaHoraHasta);
        }
    }
}
