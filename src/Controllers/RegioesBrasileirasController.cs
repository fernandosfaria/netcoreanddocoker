using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SelfHostedApi.Controllers {
    [Route("api/regioes-brasileiras")]
    public class RegioesBrasileirasController : Controller {       
        [HttpGet("{estado}")]
        public IActionResult Get(string estado) {
            var retorno = string.Empty;

            switch (estado) {
                case "São Paulo":
                    retorno = "Sudeste";
                    break;
                case "Bahia":
                    retorno = "Nordeste";
                    break;
                case "Porto Alegre":
                    retorno = "Sul";
                    break;
                case "Pará":
                    retorno = "Norte";
                    break;
            }

            return Ok(retorno);
        }
    }
}