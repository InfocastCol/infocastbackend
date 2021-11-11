using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utilitarios;
using Logica;
using System.Web.Http;
using System.Web.Http.Cors;

namespace infocast.Controllers
{

    [EnableCors("*", "*", "*")]
    [Route("api/[controller]")]
    public class CerrarSesionController : ApiController
    {
        [Authorize]
        [HttpPost]
        [Route("api/CerrarSession/PostPage_Load")]
        public IHttpActionResult Page_Load(int usuario1)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    string error = "Datos incorrectos.";
                    foreach (var state in ModelState)
                    {
                        foreach (var item in state.Value.Errors)
                        {
                            error += $" {item.ErrorMessage}";
                        }
                    }
                    return BadRequest(error);
                }


                if (usuario1 == 0)
                {
                    return BadRequest("Alguna de las variables requeridas viene vacia o null, intentelo de nuevo");
                }
                else
                {

                    return Ok(new LCerrarSesion().Page_Load(usuario1));
                }

            }
            catch (Exception ex)
            {
                return BadRequest("hay un problema interno: " + ex.StackTrace);
            }


        }

    }
}