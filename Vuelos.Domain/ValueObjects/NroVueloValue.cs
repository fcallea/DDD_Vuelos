using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vuelos.Domain.ValueObjects {
    public record NroVueloValue {
        public int Value { get; }
        public NroVueloValue(int value) {
            /*
            if (Value > 0)
            {
                String msg = (String)"El nro de vuelo debe ser numerico positivo";
                throw new BussinessRuleValidationException(msg);
            }
            */
            Value = value;
        }

        public static implicit operator int(NroVueloValue value) {
            return value.Value;
        }

        public static implicit operator NroVueloValue(int value) {
            return new NroVueloValue(value);
        }


    }
}
