using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Infraestructure.EF.ReadModel {
    public class LugarReadModel {
        public Guid IdLugar { get; set; }
        public Guid IdLocalidad { get; set; }
        public ICollection<AeropuertoReadModel> LugarAeropuerto { get; set; }
        public ICollection<VueloReadModel> LugarVuelo { get; set; }
    }
}
