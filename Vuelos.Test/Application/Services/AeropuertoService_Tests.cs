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
        [InlineData("V01", true)]
        [InlineData("1X123", false)]
        [InlineData("234234", false)]
        [InlineData("AAAA", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public async void AeropuertoService_CheckValidData(string expectedNroVuelo, bool isEqual)
        {
            var aeropuertoService = new AeropuertoService();
            string nroVuelo = await aeropuertoService.GenerarNroVueloAsync();
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
