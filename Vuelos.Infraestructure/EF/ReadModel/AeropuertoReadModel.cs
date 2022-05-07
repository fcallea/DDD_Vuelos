using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Infraestructure.EF.ReadModel
{
    public class AeropuertoReadModel
    {
        public Guid IdAeropuerto { get; set; }
        public LugarReadModel Lugar { get; set; }
        //public Guid IdLugar { get; set; }
        public int SecuencialVuelo { get; set; }
        public string Nombre { get; set; }
        public ICollection<PistaReadModel> Pista { get; set; }
    }
}
