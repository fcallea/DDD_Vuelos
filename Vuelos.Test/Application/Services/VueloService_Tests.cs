using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Services;
using Xunit;

namespace Vuelos.Test.Application.Services
{
    public class VueloService_Tests
    {
        [Theory]
        [InlineData("COMERCIAL", true)]
        [InlineData("CHARTER", false)]
        [InlineData("AAAAAAA", false)]
        [InlineData("DDDDDD", false)]
        [InlineData("SDFSDFSDF", false)]
        public async void VueloService_Tests_CheckValidData(string strExpectedTipoVuelo, bool isEqual)
        {
            var vueloServicio = new VueloService();
            String tipoVuelo = await vueloServicio.CrearTipoVueloAsync();
            String tipoVueloCompare = (String)"COMERCIAL";
            decimal milllas = await vueloServicio.CrearMillasVueloAsync();
            decimal tiempovuelo = await vueloServicio.CrearTiempoVueloAsync();
            if (isEqual)
            {
                Assert.Equal(tipoVuelo, tipoVueloCompare);
                Assert.InRange(milllas, 0, 999999999);
                Assert.InRange(tiempovuelo, 0, 999999999);
            }
            else
            {
                Assert.NotEqual(tipoVuelo, tipoVueloCompare);
                Assert.NotInRange(milllas, 0, 999999999);
                Assert.NotInRange(tiempovuelo, 0, 999999999);
            }

            var tripulacionService = new TripulacionService();
            Assert.NotNull((Object)await tripulacionService.CrearTripulacionAsync());

            Assert.NotNull((object)await vueloServicio.CrearLugarOrigenAsync());
            Assert.NotNull((object)await vueloServicio.CrearLugarDestinoAsync());
            Assert.NotNull((object)await vueloServicio.CrearFechaHoraPartidaAsync());
            Assert.NotNull((object)await vueloServicio.CrearFechaHoraLlegadaAsync());

        }
    }
}
