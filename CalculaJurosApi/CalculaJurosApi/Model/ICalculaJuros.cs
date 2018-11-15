using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJurosApi.Model
{
    public interface ICalculaJuros
    {
        void Calcular(CalculoJuros calculoJuros);
        string ShowMeTheCode();
    }
}
