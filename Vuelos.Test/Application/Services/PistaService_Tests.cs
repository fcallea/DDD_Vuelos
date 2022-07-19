using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Services;
using Xunit;

namespace Vuelos.Test.Application.Services
{
    public class PistaService_Tests
    {
        [Theory]
        [InlineData(1, false)]
        [InlineData(2, false)]
        [InlineData(3, false)]
        [InlineData(4, false)]
        [InlineData(0, false)]
        public async void PistaService_CheckValidData(int expectedNroVuelo, bool isEqual)
        {
            var pistaService = new PistaService();
            int nroVuelo = await pistaService.AsignarNroVueloAsync();
            if (isEqual)
            {
                Assert.Equal(expectedNroVuelo, nroVuelo);
            } else
            {
                Assert.NotEqual(expectedNroVuelo, nroVuelo);
            }
            Assert.NotNull((object)await pistaService.GetIdPistaAsync());

        }
    }
}
