using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Vuelos.ValueObjects
{
    public record VODestinoVuelo : ValueObject
    {
        public string Destino { get; }

        public VODestinoVuelo(string destino)
        {
            CheckRule(new StringNotNullOrEmptyRule(destino));
            if (destino != "SCZ" || destino != "CBB")
            {
                throw new BussinessRuleValidationException("Destino no Habilitado");
            }
            Destino = destino;
        }


        public static implicit operator string(VODestinoVuelo value)
        {
            return value.Destino;
        }

        public static implicit operator VODestinoVuelo(string value)
        {
            return new VODestinoVuelo(value);
        }
    }
}
