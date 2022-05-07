using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Infraestructure.EF.Config.ReadConfig;
using Vuelos.Infraestructure.EF.ReadModel;
using Vuelos.Domain.Event;
using ShareKernel.Core;

namespace Vuelos.Infraestructure.EF.Contexts
{
    public class ReadDbContext : DbContext
    {
        public virtual DbSet<AeropuertoReadModel> Aeropuerto { set; get; }
        public virtual DbSet<PistaReadModel> Pista { set; get; }
        public virtual DbSet<AeronaveReadModel> Aeronave { set; get; }
        public virtual DbSet<ItinerarioReadModel> Itinerario { set; get; }
        public virtual DbSet<LugarReadModel> Lugar { set; get; }
        public virtual DbSet<VueloReadModel> Vuelo { set; get; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var vueloConfig = new VueloReadConfig();
            modelBuilder.ApplyConfiguration<AeropuertoReadModel>(vueloConfig);
            //modelBuilder.ApplyConfiguration<PistaReadModel>(vueloConfig);
            //modelBuilder.ApplyConfiguration<AeronaveReadModel>(vueloConfig);
            //modelBuilder.ApplyConfiguration<ItinerarioReadModel>(vueloConfig);
            //modelBuilder.ApplyConfiguration<LugarReadModel>(vueloConfig);
            //modelBuilder.ApplyConfiguration<VueloReadModel>(vueloConfig);

            modelBuilder.Ignore<DomainEvent>();
            modelBuilder.Ignore<VueloCreado>();
            modelBuilder.Ignore<AeronaveEnPistaAsignado>();
            modelBuilder.Ignore<TripulanteAsignadoAgregado>();
            modelBuilder.Ignore<DestinoCreado>();
        }
    }
}
