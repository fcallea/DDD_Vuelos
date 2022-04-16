using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.ValueObjects
{
    public record DestinoValue : ValueObject
    {
        public string Destino { get; }

        public DestinoValue(string destino)
        {
            CheckRule(new StringNotNullOrEmptyRule(destino));
            if (destino != "SCZ" || destino != "CBBA")
            {
                throw new BussinessRuleValidationException("Destino no Habilitado");
            }
            Destino = destino;
        }

        public static implicit operator string(DestinoValue value)
        {
            return value.Destino;
        }

        public static implicit operator DestinoValue(string destino)
        {
            return new DestinoValue(destino);
        }


    }
}
