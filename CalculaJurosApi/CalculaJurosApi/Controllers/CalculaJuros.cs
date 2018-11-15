using CalculaJurosApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJurosApi.Controllers
{
    public class CalculaJuros
    {
        /// <summary>
        /// Exemplo: / calculajuros ? valorinicial = 100 & meses = 5 Resultado esperado: 105,10 - Valor Final = Valor Inicial* (1 + juros) ^ Tempo
        /// </summary>
        /// <param name="calculoJuros"></param>
        /// <param name="ValorJuros"></param>
        /// <returns></returns>
        public static decimal CalcularJuros(CalculoJuros calculoJuros, double ValorJuros = 0.01)
        {
            double valorFinal = 0;
            if (calculoJuros != null)
            {
                calculoJuros.Juros = ValorJuros;
                valorFinal = Math.Round(Convert.ToDouble(calculoJuros.ValorInicial) * Math.Pow(1 + calculoJuros.Juros, calculoJuros.Tempo), 2);
            }
            return Convert.ToDecimal(valorFinal);
        }

        public static CalculoJuros CalcularJuros2(CalculoJuros calculoJuros, double ValorJuros = 0.01)
        {
            if (calculoJuros != null)
            {
                calculoJuros.Juros = ValorJuros;
                calculoJuros.ValorFinal = Convert.ToDecimal(Math.Round(Convert.ToDouble(calculoJuros.ValorInicial) * Math.Pow(1 + calculoJuros.Juros, calculoJuros.Tempo), 2));
            }
            return calculoJuros;
        }
    }
}
