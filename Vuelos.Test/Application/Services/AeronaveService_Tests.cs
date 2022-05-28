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
        [InlineData("0000-0000-0000-0000", false)]
        [InlineData("1234-456-456", false)]
        [InlineData("xxxxxxx", false)]
        [InlineData("7dfsfsdf89", false)]
        [InlineData("", false)]
        public async void AeronaveService_CheckValidData(string StrExpectedIdAeronave, bool isEqual)
        {
            Guid expectedIdAeronave;
            bool isValid = Guid.TryParse(StrExpectedIdAeronave, out expectedIdAeronave);
            if (isEqual)
            {
                Assert.True(isValid);
            }
            else
            {
                Assert.False(isValid);
            }     
        }
    }
}
