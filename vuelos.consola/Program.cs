using System;
using System.Threading.Tasks;
using Vuelos.Application.Services;
using Vuelos.Domain.Model.Itinerarios;
using Vuelos.Domain.Model.Vuelos;

namespace vuelos.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guid IdPista = Guid.NewGuid();
            Guid IdAeronave = Guid.NewGuid();
            int NroVuelo = 123;
            DateTime FechaHoraDesde = DateTime.Now;
            DateTime FechaHoraHasta = DateTime.Now;

            Console.WriteLine($"IdPista {IdPista}");
            Console.WriteLine($"IdAeronave {IdAeronave}");
            Console.WriteLine($"NroVuelo {NroVuelo}");
            Console.WriteLine($"FechaHoraDesde {FechaHoraDesde}");
            Console.WriteLine($"FechaHoraHasta {FechaHoraHasta}");

            Itinerario it = new Itinerario(IdPista, IdAeronave, NroVuelo, FechaHoraDesde, FechaHoraHasta);

            Console.WriteLine($"Itinerario {it.IdPista}");

            PistaService pista = new PistaService();
            var dato = pista.AsignarNroVueloAsync();
            Console.WriteLine($"dato {dato}");


            Console.WriteLine("Hello World!");


            Console.WriteLine("Iniciando VUELO!");

            Guid     v_IdLugarOrigen    = Guid.NewGuid();
            Guid     v_IdLugarDestino   = Guid.NewGuid();
            Guid     v_IdItinerario     = Guid.NewGuid();
            Guid     v_IdAeronave       = Guid.NewGuid();
            int      v_NroVuelo         = 123;
            Guid     v_IdTripulacion    = Guid.NewGuid();
            DateTime v_FechaHoraPartida = DateTime.Now;
            DateTime v_FechaHoraLlegada = DateTime.Now;
            String   v_TipoVuelo        = (String)"COMERCIAL";
            decimal  v_MillasVuelo      = new decimal(21.2);
            decimal  v_TiempoVuelo      = new decimal(15.2);


            Vuelo vuelo = new Vuelo(
              v_IdLugarOrigen
            , v_IdLugarDestino
            , v_IdItinerario
            , v_IdAeronave
            , v_NroVuelo
            , v_IdTripulacion
            , v_FechaHoraPartida
            , v_FechaHoraLlegada
            , v_TipoVuelo
            , v_MillasVuelo
            , v_TiempoVuelo
        );
            Console.WriteLine($"LUGAR ORIGEN {vuelo.IdLugarOrigen}");



        }
    }
}
