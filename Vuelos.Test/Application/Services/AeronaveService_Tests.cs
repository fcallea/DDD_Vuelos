using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Services;
using Xunit;

namespace Vuelos.Test.Application.Services
{
    public class AeronaveService_Tests
    {
        [Theory]
        [InlineData(10, false)]
        [InlineData(60, true)]
        [InlineData(-1, false)]
        [InlineData(100, false)]
        [InlineData(0, false)]
        public async void AeronaveService_CheckValidData(int limiteNroAsientos, bool isEqual)
        {
            var aeronaveService = new AeronaveService();
            if (isEqual)
            {
                Assert.NotNull((object)await aeronaveService.ObtenerNroAsientosAsync());
                Assert.InRange(await aeronaveService.ObtenerNroAsientosAsync(), 30, limiteNroAsientos);
            }
            else
            {
                Assert.NotInRange(await aeronaveService.ObtenerNroAsientosAsync(), 30, limiteNroAsientos);
            }

            Assert.NotNull((object)await aeronaveService.ObtenerIdAeronaveAsync());

        }
    }
}
