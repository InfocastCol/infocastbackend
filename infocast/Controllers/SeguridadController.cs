
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using infocast.Seguridad;
using Logica;
using Utilitarios;

namespace infocast.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/admin")]
    public class SeguridadController : ApiController
    {
        // GET: Seguridad
        [Route("login")]
        [HttpPost]
        public async Task<IHttpActionResult> loginAsync(LoginRequest login)
        {
            string mensaje;
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
            UUsuario user = await new LUsuarios().LG_Principal2(login);
            if (user == null)
                return Unauthorized();
            else
            {
                var token = TokenGenerator.GenerateTokenJwt(user);
                return Ok(token);
            }
        }

    }
}