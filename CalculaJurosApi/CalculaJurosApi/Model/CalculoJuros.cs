using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJurosApi.Model
{
    public class CalculoJuros : ICalculaJuros
    {
        /*Valor Final = Valor Inicial* (1 + juros) ^ Tempo
        Valor inicial é um decimal recebido como parâmetro Juros é 1% ou 0,01 (fixo no código) Tempo é um inteiro, que representa meses, também recebido como parâmetro ^ 
        representa a operação de potência Resultado final deve ser truncado(sem arredondamento) em duas casas decimais
        Exemplo: /calculajuros? valorinicial = 100 & meses = 5 Resultado esperado: 105,10*/
        public decimal ValorInicial { get; set; }
        public decimal ValorFinal { get; set; }
        public double Juros { get; set; }
        public int Tempo { get; set; }

        public void Calcular(CalculoJuros calculoJuros)
        {
            throw new NotImplementedException();
        }

        public string ShowMeTheCode()
        {
            throw new NotImplementedException();
        }
    }
}
