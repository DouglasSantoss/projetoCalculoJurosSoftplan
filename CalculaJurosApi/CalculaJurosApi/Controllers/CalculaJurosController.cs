using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculaJurosApi.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculaJurosApi.Controllers
{
    [Route("api")]
    public class CalculaJurosController : Controller
    {
        /// <summary>
        /// Retorna o valor calculado com juros em formato decimal
        /// </summary>
        /// <param name="ValorInicial"></param>
        /// <param name="Tempo"></param>
        /// <returns></returns>
        [HttpGet("calculajuros/{ValorInicial}/{Tempo}", Name ="calculajuros")]
        public decimal Calculajuros(decimal ValorInicial, int Tempo)
        {
            return CalculaJuros.CalcularJuros(new CalculoJuros()
            {
                ValorInicial = ValorInicial,
                Tempo = Tempo
            });
        }

        /// <summary>
        /// Retorna uma string formatada com os dados informados e o valor calculado com juros
        /// </summary>
        /// <param name="ValorInicial"></param>
        /// <param name="Tempo"></param>
        /// <returns></returns>
        [HttpGet("calculajuros2/{ValorInicial}/{Tempo}", Name = "calculajuros2")]
        public string Calculajuros2(decimal ValorInicial, int Tempo)
        {
            var calculoJuros = CalculaJuros.CalcularJuros2(new CalculoJuros()
            {
                ValorInicial = ValorInicial,
                Tempo = Tempo
            });

            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("Valor inicial = R$" + calculoJuros.ValorInicial.ToString("N2"));
            retorno.AppendLine("Meses = " + calculoJuros.Tempo);
            retorno.AppendLine("Juros = 1%, R$" + (calculoJuros.ValorFinal - calculoJuros.ValorInicial).ToString("N2"));
            retorno.AppendLine("Valor final = R$" + calculoJuros.ValorFinal.ToString("N2"));
            return retorno.ToString();

        }

        /// <summary>
        /// Retorna o link do repositorio git
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("showmethecode", Name = "showmethecode")]
        public string ShowMeTheCode()
        {
            return @"https://github.com/DouglasSantoss/projetoCalculoJurosSoftplan.git";
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
