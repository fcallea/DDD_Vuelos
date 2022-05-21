using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelo;
using Xunit;

namespace Vuelos.Test.Application.Dto
{
    public class TripulanteDto_Tests
    {
        [Fact]
        public void TripulanteDto_CheckPropertiesValid()
        {
            var IdTripulante = Guid.NewGuid();
            var IdCargo = Guid.NewGuid();

            var tripulante = new TripulanteDto();

            Assert.Equal(Guid.Empty, tripulante.IdTripulante);
            Assert.Equal(Guid.Empty, tripulante.IdCargo);


            tripulante.IdTripulante = IdTripulante;
            tripulante.IdCargo = IdCargo;


            Assert.Equal(IdTripulante, tripulante.IdTripulante);
            Assert.Equal(IdCargo, tripulante.IdCargo);


        }
    }
}
