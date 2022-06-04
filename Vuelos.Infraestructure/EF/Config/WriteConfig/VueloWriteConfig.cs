using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeronaves;
using Vuelos.Domain.Model.Aeropuertos;
using Vuelos.Domain.Model.Itinerarios;
using Vuelos.Domain.Model.Lugares;
using Vuelos.Domain.Model.Tripulaciones;
using Vuelos.Domain.Model.Vuelos;
using Vuelos.Domain.ValueObjects;

namespace Vuelos.Infraestructure.EF.Config.WriteConfig
{
    public class VueloWriteConfig :
          IEntityTypeConfiguration<Itinerario>
        //, IEntityTypeConfiguration<Aeropuerto>
        //, IEntityTypeConfiguration<Pista>
        //, IEntityTypeConfiguration<Aeronave>
        //, IEntityTypeConfiguration<Vuelo>
        //, IEntityTypeConfiguration<Lugar>
    {
        /*
        public void Configure(EntityTypeBuilder<Aeropuerto> builder)
        {
            builder.ToTable("Aeropuerto");
            builder.HasKey(x => x.Id);

            //builder.Property(x => x.IdLugar)
            //.HasMaxLength(500)
            //.HasColumnName("idLugar");

            builder.Property(x => x.SecuencialVuelo)
            .HasColumnName("secuencialVuelo");

            builder.Property(x => x.Nombre)
            .HasMaxLength(500)
            .HasColumnName("nombre");

            builder.HasMany(typeof(Pista), "_pistas");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
            builder.Ignore(x => x.Pistas);
            builder.Ignore(x => x.IdLugar);

        }

        public void Configure(EntityTypeBuilder<Pista> builder)
        {
            builder.ToTable("Pista");
            builder.HasKey(x => x.Id);

            builder.HasMany(typeof(Itinerario), "_Itinerarios");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
            builder.Ignore(x => x.Itinerarios);
        }

        public void Configure(EntityTypeBuilder<Aeronave> builder)
        {
            builder.ToTable("Aeronave");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Estado)
                .HasMaxLength(20)
                .HasColumnName("estado");

            builder.Property(x => x.NroAsientos)
                .HasColumnName("nroAsientos");

            builder.Property(x => x.Marca)
               .HasMaxLength(20)
               .HasColumnName("marca");

            builder.Property(x => x.Modelo)
               .HasMaxLength(20)
               .HasColumnName("modelo");

            builder.Property(x => x.CapacidadCarga)
                .HasColumnName("capacidadCarga")
                .HasColumnType("decimal")
                .HasPrecision(12, 2);

            builder.Property(x => x.CapacidadTanque)
                .HasColumnName("capacidadTanque")
                .HasColumnType("decimal")
                .HasPrecision(12, 2);

            builder.HasMany(typeof(Itinerario), "_Itinerarios");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
            builder.Ignore(x => x.Itinerarios);
        }

        */

        public void Configure(EntityTypeBuilder<Itinerario> builder)
        {
            builder.ToTable("Itinerario");
            builder.HasKey(x => x.Id);

            var nroVueloConverter = new ValueConverter<NroVueloValue, int>(
                nroVueloValue => nroVueloValue.Value,
                nroVuelo => new NroVueloValue(nroVuelo)
            );

            builder.Property(x => x.NroVuelo)
                .HasConversion(nroVueloConverter)
                .HasColumnName("nroVuelo");

            /*
            var fechaHoraDesdeConverter = new ValueConverter<FechaValue, DateTime>(
                fechaHoraDesdeValue => fechaHoraDesdeValue.Value,
                fechaHoraDesde => new FechaValue(fechaHoraDesde)
            );

            builder.Property(x => x.FechaHoraDesde)
                .HasConversion(fechaHoraDesdeConverter)
                .HasColumnName("fechaHoraDesde")
                .HasColumnType("datetime");


            var fechaHoraHastaConverter = new ValueConverter<FechaValue, DateTime>(
                fechaHoraHastaValue => fechaHoraHastaValue.Value,
                fechaHoraHasta => new FechaValue(fechaHoraHasta)
            );

            builder.Property(x => x.FechaHoraHasta)
                .HasConversion(fechaHoraHastaConverter)
                .HasColumnName("fechaHoraHasta")
                .HasColumnType("datetime");
            */

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
            builder.Ignore(x => x.IdPista);
            builder.Ignore(x => x.IdAeronave);
            builder.Ignore(x => x.FechaHoraDesde);
            builder.Ignore(x => x.FechaHoraHasta);
        }

        /*
        public void Configure(EntityTypeBuilder<Vuelo> builder)
        {
            builder.ToTable("Vuelo");
            builder.HasKey(x => x.Id);

            var nroVueloConverter = new ValueConverter<NroVueloValue, int>(
                nroVueloValue => nroVueloValue.Value,
                nroVuelo => new NroVueloValue(nroVuelo)
            );

            builder.Property(x => x.NroVuelo)
                .HasConversion(nroVueloConverter)
                .HasColumnName("nroVuelo");

            var fechaHoraPartidaConverter = new ValueConverter<FechaValue, DateTime>(
                fechaHoraPartidaValue => fechaHoraPartidaValue.Value,
                fechaHoraPartida => new FechaValue(fechaHoraPartida)
            );

            builder.Property(x => x.FechaHoraPartida)
                .HasConversion(fechaHoraPartidaConverter)
                .HasColumnName("fechaHoraPartida")
                .HasColumnType("datetime");

            var fechaHoraLlegadaConverter = new ValueConverter<FechaValue, DateTime>(
                fechaHoraLlegadaValue => fechaHoraLlegadaValue.Value,
                fechaHoraLlegada => new FechaValue(fechaHoraLlegada)
            );

            builder.Property(x => x.FechaHoraLlegada)
                .HasConversion(fechaHoraLlegadaConverter)
                .HasColumnName("fechaHoraLlegada")
                .HasColumnType("datetime");

            var tipoVueloConverter = new ValueConverter<TipoVueloValue, string>(
                tipoVueloValue => tipoVueloValue.Value,
                tipoVuelo => new TipoVueloValue(tipoVuelo)
            );

            builder.Property(x => x.TipoVuelo)
               .HasConversion(tipoVueloConverter)
               .HasMaxLength(20)
               .HasColumnName("tipoVuelo");

            builder.Property(x => x.MillasVuelo)
                .HasColumnName("millasVuelo")
                .HasColumnType("decimal")
                .HasPrecision(12, 2);

            builder.Property(x => x.TiempoVuelo)
                .HasColumnName("tiempoVuelo")
                .HasColumnType("decimal")
                .HasPrecision(12, 2);

            builder.Property(x => x.StockAsientos)
                .HasColumnName("stockAsientos");

            builder.HasMany(typeof(Tripulacion), "_Tripulacion");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
            builder.Ignore(x => x.Tripulantes);
            builder.Ignore(x => x.IdLugarOrigen);
            builder.Ignore(x => x.IdLugarDestino);
            builder.Ignore(x => x.IdItinerario);
            builder.Ignore(x => x.IdAeronave);
        }

        public void Configure(EntityTypeBuilder<Lugar> builder)
        {
            builder.ToTable("Lugar");
            builder.HasKey(x => x.Id);

            //builder.Property(x => x.IdLocalidad)
            //   .HasMaxLength(500)
            //   .HasColumnName("idLocalidad");

            builder.HasMany(typeof(Aeropuerto), "_Aeropuertos");
            builder.HasMany(typeof(Vuelo), "_Vuelos");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
            builder.Ignore(x => x.Aeropuertos);
            builder.Ignore(x => x.Vuelos);
            builder.Ignore(x => x.IdLocalidad);
        }
        */

    }
}