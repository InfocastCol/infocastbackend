using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Logica;
using Newtonsoft.Json.Linq;
using Utilitarios;


namespace infocast.Controllers{
    [EnableCors("*", "*", "*")]
    [Route("api/[controller]")]
    public class EntidadesController : ApiController{
        
        //
        [Authorize]
        [HttpPost]
        [Route("api/Entidades/PostAceptar_Emergencia_Entidad")]
        public IHttpActionResult Aceptar_Emergencia_Entidad([FromBody] JObject Vs_entrada){
            try{
                UEmergencia emer = new UEmergencia();
                emer.Id = int.Parse(Vs_entrada["id_emergencia"].ToString());
                emer.Id_entidad= int.Parse(Vs_entrada["id_entidad"].ToString());
                emer.Estado_emergencia = 2;
                emer.Id_entidad= int.Parse(Vs_entrada["id_entidad"].ToString());
                if (emer == null){
                    return BadRequest("Alguna de las variables requeridas viene vacia o null, intentelo de nuevo");
                } else{
                    new LEntidades().Aceptar_emergencia_entidad(emer);
                    return Ok(" Emergencia aceptada Correctamente");
                }
            }catch (Exception ex){
                return BadRequest("hay un problema interno: " + ex.StackTrace);
            }
        }
        //
        //
        [Authorize]
        [HttpPost]
        [Route("api/Entidades/PostCancelar_Emergencia_Entidad")]
        public IHttpActionResult Cancelar_Emergencia_Entidad([FromBody] JObject Vs_entrada){
            try{
                UEmergencia emer = new UEmergencia();
                emer.Id = int.Parse(Vs_entrada["id_emergencia"].ToString());
                emer.Estado_emergencia =1;
                emer.Id_entidad = int.Parse(Vs_entrada["id_entidad"].ToString());
                if (emer == null){
                    return BadRequest("Alguna de las variables requeridas viene vacia o null, intentelo de nuevo");
                }else{
                    new LEntidades().Cancelar_emergencia_entidad(emer);
                    return Ok(" Emergencia Cancelada Correctamente");
                }
            }catch (Exception ex){
                return BadRequest("hay un problema interno: " + ex.StackTrace);
            }
        }
        //
        //
        [Authorize]
        [HttpPost]
        [Route("api/user/PostComentario_emergencia_entidad")]
        public IHttpActionResult Comentario_emergencia_entidad([FromBody] JObject Vs_entrada){
            try{
                UEmergencia emer = new UEmergencia();
                emer.Id = int.Parse(Vs_entrada["Id_emergencia"].ToString());
                emer.Comentario_entidad = Vs_entrada["comentario_entidad"].ToString();
                if (emer == null){
                    return BadRequest("Alguna de las variables requeridas viene vacia o null, intentelo de nuevo");
                }else{
                    new LEntidades().comentario_entidad_emergencia(emer);
                    return Ok(" comentario agregado Correctamente");
                }
            }catch (Exception ex){
                return BadRequest("hay un problema interno: " + ex.StackTrace);
            }
        }
        //
        //
        [Authorize]
        [HttpPost]
        [Route("api/Entidades/PostCambiar_estado_emergencia_entidad")]
        public IHttpActionResult Cambiar_estado_emergencia_entidad([FromBody] JObject Vs_entrada){
            try{
                UEmergencia emer = new UEmergencia();
                emer.Id = int.Parse(Vs_entrada["id_emergencia"].ToString());               
                emer.Estado_emergencia = int.Parse(Vs_entrada["estado_emergencia"].ToString());
                emer.Id_entidad = int.Parse(Vs_entrada["id_entidad"].ToString());
                if (emer == null){
                    return BadRequest("Alguna de las variables requeridas viene vacia o null, intentelo de nuevo");
                }else{
                    new LEntidades().actualizar_estado_emergencia_entidad(emer);
                    return Ok(" Estado actualizado Correctamente");
                }
            }catch (Exception ex){
                return BadRequest("hay un problema interno: " + ex.StackTrace);
            }
        }
        //
        //
    }
}
