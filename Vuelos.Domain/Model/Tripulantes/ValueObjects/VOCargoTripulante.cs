using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Tripulantes.ValueObjects
{
    public record VOCargoTripulante : ValueObject
    {
        public string Value { get; }


        public VOCargoTripulante(string value)
        {
            CheckRule(new StringNotNullOrEmptyRule(value));
            if (value != "PILOTO" || value != "COPILOTO" || value != "ASISTENTE")
            {
                throw new BussinessRuleValidationException("El cargo de tripulante no habilitado");
            }
            Value = value;
        }


        public static implicit operator string(VOCargoTripulante value)
        {
            return value.Value;
        }

        public static implicit operator VOCargoTripulante(string value)
        {
            return new VOCargoTripulante(value);
        }
    }
}
