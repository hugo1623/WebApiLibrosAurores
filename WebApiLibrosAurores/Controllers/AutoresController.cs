using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiLibrosAurores.Entidades;

namespace WebApiLibrosAurores.Controllers
{
    [ApiController] //Permite hacer validaciones Automaticas respecto a la data recibida del controlador

    [Route("api/autores")] // Permite definir las rutas para nuestros controladores

    public class AutoresController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>
            {
                new Autor() {Id = 1, Nombre = "Luis"},
                new Autor() {Id = 2, Nombre = "Kyra"}
            };
        }
    }
}
