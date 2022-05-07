using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vuelos.Domain.ValueObjects
{
    public record NroVueloValue
    {
        public string Value { get; }
        public NroVueloValue(string value)
        {
            Match m = Regex.Match(Value, @"V-(\d{6})");
            if ((m.Success) && (int.Parse(m.Groups[3].Value)) < 8)
            {
                throw new BussinessRuleValidationException("El nro de vuelo no tiene formato requerido");
            }
            Value = value;
        }

        public static implicit operator string(NroVueloValue value)
        {
            return value.Value;
        }

        public static implicit operator NroVueloValue(string value)
        {
            return new NroVueloValue(value);
        }


    }
}
