using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Event;
using Vuelos.Domain.Model.Aeronaves;
using Vuelos.Domain.Model.Aeropuertos;
using Vuelos.Domain.Model.Itinerarios;
using Vuelos.Domain.Model.Lugares;
using Vuelos.Domain.Model.Vuelos;
using Vuelos.Infraestructure.EF.Config.WriteConfig;

namespace Vuelos.Infraestructure.EF.Contexts {
    public class WriteDbContext : DbContext {
        //public virtual DbSet<Aeropuerto> Aeropuerto { get; set; }
        //public virtual DbSet<Pista> Pista { get; set; }
        //public virtual DbSet<Aeronave> Aeronave { get; set; }
        public virtual DbSet<Itinerario> Itinerario { get; set; }
        //public virtual DbSet<Vuelo> Vuelo { get; set; }
        //public virtual DbSet<Lugar> Lugar { get; set; }

        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            var vueloConfig = new VueloWriteConfig();
            //modelBuilder.ApplyConfiguration<Aeropuerto>(vueloConfig);
            //modelBuilder.ApplyConfiguration<Pista>(vueloConfig);
            //modelBuilder.ApplyConfiguration<Aeronave>(vueloConfig);
            modelBuilder.ApplyConfiguration<Itinerario>(vueloConfig);
            //modelBuilder.ApplyConfiguration<Vuelo>(vueloConfig);
            //modelBuilder.ApplyConfiguration<Lugar>(vueloConfig);

            modelBuilder.Ignore<VueloCreado>();
            modelBuilder.Ignore<AeronaveEnPistaAsignado>();
            modelBuilder.Ignore<TripulanteAsignadoAgregado>();
            modelBuilder.Ignore<DestinoCreado>();
        }
    }
}
