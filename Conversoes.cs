using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implemeta operações de conversão.
    /// </summary>
    internal static class Conversoes
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar.
        /// </summary>
        public enum conversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahenheit,
            FahrenheitCelsius
        }
        /// <summary>
        /// Conversão de temperatiras.
        /// </summary>
        /// <param name="conversao">A conversão a efetuar.</param>
        /// <param name="temperatura">A temperatura a converter.</param>
        /// <returns>Retorna o resultado da conversão.</returns>
        public static double ConverterTemperatura(conversaoTemperatura conversao, double temperatura)
        {
            if (conversao == conversaoTemperatura.CelsiusFahenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == conversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }
            return -1;
        }
    }
}
