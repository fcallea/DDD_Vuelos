using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Services;
using Xunit;

namespace Vuelos.Test.Application.Services
{
    public class AeropuertoService_Tests
    {
        [Theory]
        [InlineData(123, false)]
        [InlineData(0000, false)]
        [InlineData(217, false)]
        [InlineData(-5, false)]
        [InlineData(0, false)]
        public async void AeropuertoService_CheckValidData(int expectedNroVuelo, bool isEqual)
        {
            var aeropuertoService = new AeropuertoService();
            int nroVuelo = await aeropuertoService.GenerarNroVueloAsync();
            if (isEqual)
            {
                Assert.Equal(expectedNroVuelo, nroVuelo);
            }
            else
            {
                Assert.NotEqual(expectedNroVuelo, nroVuelo);
            }
        }
    }
}
