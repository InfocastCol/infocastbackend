using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace infocast.Controllers
{
    [EnableCors("*", "*", "*")]
    [Route("api/[controller]")]
    public class GenerarTokenController : ApiController
    {
        /// <summary>
        /// Este metodo nos permite Generar un token para recuperar la coontraseña
        /// datos de ingreso
        /// correo
        /// </summary>
        /// <param name="correo"></param>
        [HttpGet]
        [Route("api/GenerarToken/GetGenerarToken")]
        public IHttpActionResult GenerarToken(string correo)
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


                if (correo == null)
                {
                    return BadRequest("Alguna de las variables requeridas viene vacia o null, intentelo de nuevo");
                }
                else
                {

                    return Ok(new LGenerar_Token().LB_Recuperar3(correo));
                }
            }
            catch (Exception ex)
            {
                return BadRequest("hay un problema interno: " + ex.StackTrace);
            }

        }
    }
}