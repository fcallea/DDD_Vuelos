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
        [InlineData("0000-0000-0000-0000", true)]
        [InlineData("1234-456-456", false)]
        [InlineData("xxxxxxx", false)]
        [InlineData("7dfsfsdf89", false)]
        [InlineData("", false)]
        public async void ItinerarioService_CheckValidData(Guid expectedIdItinerario, bool isEqual)
        {
            var itinerarioService = new ItinerarioService();
            Guid iditinerario = await itinerarioService.ObtenerIdAeronaveAsync();
            if (isEqual)
            {
                Assert.Equal(expectedIdItinerario, iditinerario);
            }
            else
            {
                Assert.NotEqual(expectedIdItinerario, iditinerario);
            }
        }
    }
}
