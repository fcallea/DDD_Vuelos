using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Services;
using Xunit;

namespace Vuelos.Test.Application.Services
{
    public class ItinerarioService_Tests
    {
        [Theory]
        [InlineData(0, 99999999, true)]
        [InlineData(0, -8, false)]
        [InlineData(-999, 0, false)]
        public async void ItinerarioService_CheckValidData(int IniExpectedNroVuelo, int FinExpectedNroVuelo, bool isEqual)
        {
            var itinerarioService = new ItinerarioService();

            if (isEqual)
            {
                Assert.InRange(await itinerarioService.ObtenerNroVueloAsync(), IniExpectedNroVuelo, FinExpectedNroVuelo);
            } else
            {
                Assert.NotInRange(await itinerarioService.ObtenerNroVueloAsync(), 0, 99999999);
            }

            Assert.NotNull((object)await itinerarioService.ObtenerIdItinerarioAsync());
            Assert.NotNull((object)await itinerarioService.ObtenerIdPistaAsync());
            Assert.NotNull((object)await itinerarioService.ObtenerIdAeronaveAsync());
            Assert.NotNull((object)await itinerarioService.ObtenerFechaDesdeAsync());
            Assert.NotNull((object)await itinerarioService.ObtenerFechaHastaAsync());
        }
    }
}
