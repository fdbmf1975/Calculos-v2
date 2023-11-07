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
        /// Tipo de conversão de distancias.
        /// </summary>
        public enum conversaoDistancia
        {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros
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
        /// <summary>
        /// Conversão de distâncias.
        /// </summary>
        /// <param name="conversao">Conversão a efetuar.</param>
        /// <param name="distancias">A distância a converter</param>
        /// <returns>O resultado da conversão da distância.</returns>
        public static double ConverterDistancias(conversaoDistancia conversao, double distancias)
        {
            if (conversao == conversaoDistancia.MetrosMilhas)
            {
                return distancias * 0.0006213712;
            }
            else if (conversao == conversaoDistancia.MilhasMetros)
            {
                return distancias * 1609.344;
            }
            return -1;
        }

    }
}
