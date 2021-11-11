using Logica;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using Utilitarios;

namespace infocast.Controllers{
    [EnableCors("*", "*", "*")]
    [Route("api/[controller]")]
    public class UsuariosController : ApiController{
        [HttpPost]
        [Route("api/user/PostInsertarAcceso")]
        public IHttpActionResult InsertarAcceso(UAcceso acceso){
            try{
                if (acceso == null){
                    return BadRequest("Alguna de las variables requeridas viene vacia o null, intentelo de nuevo");
                }else{
                    new LUsuarios().InsertarAcceso(acceso);
                    return Ok();
                }
            }catch (Exception ex){
                return BadRequest("hay un problema interno: " + ex.StackTrace);
            }

        }
        //Registrar_Usuario
        [HttpPost]
        [Route("api/Usuarios/PostRegistrar_Usuario")]
        public string Registrar_Usuario([FromBody] JObject Vs_entrada){
            string correo;
            try  {
                correo = Vs_entrada["correo"].ToString();
                UUsuario validarUsuario = new LUsuarios().LBT_Registrar(correo);
               if (validarUsuario != null){
                  return "El correo ya existe, pruebe con otro";
                }  else {
                    UUsuario usuario = new UUsuario();
                    usuario.Nombres = Vs_entrada["nombre"].ToString();
                    usuario.Apellidos = Vs_entrada["apellidos"].ToString();
                    usuario.User_name = Vs_entrada["user_name"].ToString();
                    usuario.Correo = Vs_entrada["correo"].ToString();
                    usuario.Password = Vs_entrada["contrasenia"].ToString();
                    usuario.Documento = Vs_entrada["documento"].ToString();
                    usuario.Entidad = 1;
                    usuario.Tipo_usuario = 1;
                    usuario.Aprobacion = 1;
                    usuario.Direccion= Vs_entrada["direccion"].ToString();
                    usuario.Telefono= Vs_entrada["telefono"].ToString();
                    usuario.Barrio= Vs_entrada["barrio"].ToString();
                    usuario.Ciudad= Vs_entrada["ciudad"].ToString();
                    new LUsuarios().Registrar_usuario(usuario);
                    return "Registro exitoso";
               }

            } catch (Exception ex){
                return "hay un problema interno" + ex.StackTrace;
            }
        }
        //Registrar_Usuario
        //Registrar_entidad
        [HttpPost]
        [Route("api/Usuarios/PostRegistrar_Entidad")]
        public string Registrar_Entidad([FromBody] JObject Vs_entrada){
            string correo;
            UUsuario usuario = new UUsuario();
            try{
                usuario.Entidad = 2;
                usuario.Ciudad = Vs_entrada["Ciudad"].ToString();
                UUsuario validarentidad = new LUsuarios().Verificar_entidad_existente(usuario);
                if (validarentidad!=null){
                    return "En este momento en " + usuario.Ciudad + " YA esta registrada la entidad que presentas";
                }else{
                    //
                    correo = Vs_entrada["correo"].ToString();
                    UUsuario validarUsuario = new LUsuarios().LBT_Registrar(correo);
                    if (validarUsuario != null){
                        return "El correo ya existe, pruebe con otro";
                    }else{
                        usuario.Nombres = Vs_entrada["nombre"].ToString();
                       // usuario.Apellidos = Vs_entrada["apellidos"].ToString();
                        usuario.User_name = Vs_entrada["user_name"].ToString();
                        usuario.Correo = Vs_entrada["correo"].ToString();
                        usuario.Password = Vs_entrada["contrasenia"].ToString();
                        usuario.Documento = Vs_entrada["documento"].ToString();
                        // usuario.Entidad = 2;
                        usuario.Tipo_usuario = 2;
                        usuario.Aprobacion = 0;//0 sin aprobar//1 aprobado// 2 rechazado
                        usuario.Direccion = Vs_entrada["direccion"].ToString();
                        usuario.Telefono = Vs_entrada["telefono"].ToString();
                      //  usuario.Ciudad = Vs_entrada["Ciudad"].ToString();
                        new LUsuarios().Registrar_usuario(usuario);
                        return "Registro exitoso";
                    }
                    //
                }
            //
            }catch (Exception ex){
                return "hay un problema interno" + ex.StackTrace;
            }
        }
        //Registrar_Entidad
        //Registrar_Socorrista
        [HttpPost]
        [Route("api/Usuarios/PostRegistrar_Socorrista")]
        public string Registrar_Socorrista([FromBody] JObject Vs_entrada){
            string correo;
            UUsuario usuario = new UUsuario();
            try{
                usuario.Entidad= int.Parse(Vs_entrada["entidad"].ToString());
                usuario.Ciudad = Vs_entrada["Ciudad"].ToString();
                UUsuario validarentidad = new LUsuarios().Verificar_entidad_existente(usuario);
                if (validarentidad!=null){
                    correo = Vs_entrada["correo"].ToString();
                    UUsuario validarUsuario = new LUsuarios().LBT_Registrar(correo);
                    if (validarUsuario != null){
                        return "El correo ya existe, pruebe con otro";
                    }else{
                        usuario.Nombres = Vs_entrada["nombre"].ToString();
                        usuario.Apellidos = Vs_entrada["apellidos"].ToString();
                        usuario.User_name = Vs_entrada["user_name"].ToString();
                        usuario.Correo = Vs_entrada["correo"].ToString();
                        usuario.Password = Vs_entrada["contrasenia"].ToString();
                        usuario.Documento = Vs_entrada["documento"].ToString();
                        //  usuario.Entidad = int.Parse(Vs_entrada["entidad"].ToString()); 
                        usuario.Tipo_usuario = 3;
                        usuario.Aprobacion = 0;//0 sin aprobar//1 aprobado// 2 rechazado
                        usuario.Direccion = Vs_entrada["direccion"].ToString();
                        usuario.Telefono = Vs_entrada["telefono"].ToString();
                        // usuario.Ciudad = Vs_entrada["Ciudad"].ToString();
                        new LUsuarios().Registrar_usuario(usuario);
                        return "Registro exitoso";
                    }
                }else{
                    return "En este momento en "+ usuario.Ciudad+" no esta registrada la entidad a la que te presentas";
                }
               
            }catch (Exception ex){
                return "hay un problema interno" + ex.StackTrace;
            }
        }
        //Registrar_Socorrista
        //Registrar_Lider_de_Barrio
        [HttpPost]
        [Route("api/Usuarios/PostRegistrar_Lider_de_Barrio")]
        public string Registrar_Lider_de_Barrio([FromBody] JObject Vs_entrada){
            string correo;
            try{
                correo = Vs_entrada["correo"].ToString();
                UUsuario validarUsuario = new LUsuarios().LBT_Registrar(correo);
                if (validarUsuario != null){
                    return "El correo ya existe, pruebe con otro";
                }else{
                    UUsuario usuario = new UUsuario();
                    usuario.Nombres = Vs_entrada["nombre"].ToString();
                    usuario.Apellidos = Vs_entrada["apellidos"].ToString();
                    usuario.User_name = Vs_entrada["user_name"].ToString();
                    usuario.Correo = Vs_entrada["correo"].ToString();
                    usuario.Password = Vs_entrada["contrasenia"].ToString();
                    usuario.Documento = Vs_entrada["documento"].ToString();
                    usuario.Entidad = 7;
                    usuario.Tipo_usuario = 4;
                    usuario.Aprobacion = 0;//0 sin aprobar//1 aprobado// 2 rechazado
                    usuario.Direccion = Vs_entrada["direccion"].ToString();
                    usuario.Telefono = Vs_entrada["telefono"].ToString();
                    usuario.Barrio= Vs_entrada["barrio"].ToString();
                    usuario.Ciudad= Vs_entrada["ciudad"].ToString();
                    new LUsuarios().Registrar_usuario(usuario);
                    return "Registro exitoso";
                }
            }catch (Exception ex){
                return "hay un problema interno" + ex.StackTrace;
            }
        }
        //Registrar_Lider_de_Barrio
        //Registrar_Administrador
        [HttpPost]
        [Route("api/Usuarios/PostRegistrar_Administrador")]
        public string Registrar_Administrador([FromBody] JObject Vs_entrada){
            string correo;
            try{
                correo = Vs_entrada["correo"].ToString();
                UUsuario validarUsuario = new LUsuarios().LBT_Registrar(correo);
                if (validarUsuario != null){
                    return "El correo ya existe, pruebe con otro";
                }else{
                    UUsuario usuario = new UUsuario();
                    usuario.Nombres = Vs_entrada["nombre"].ToString();
                    usuario.Apellidos = Vs_entrada["apellidos"].ToString();
                    usuario.User_name = Vs_entrada["user_name"].ToString();
                    usuario.Correo = Vs_entrada["correo"].ToString();
                    usuario.Password = Vs_entrada["contrasenia"].ToString();
                    usuario.Documento = Vs_entrada["documento"].ToString();
                    usuario.Entidad = 8;
                    usuario.Tipo_usuario = 5;
                    usuario.Aprobacion = 1;//0 sin aprobar//1 aprobado// 2 rechazado
                    usuario.Direccion = Vs_entrada["direccion"].ToString();
                    usuario.Telefono = Vs_entrada["telefono"].ToString();
                    new LUsuarios().Registrar_usuario(usuario);
                    return "Registro exitoso";
                }
            }catch (Exception ex){
                return "hay un problema interno" + ex.StackTrace;
            }
        }
        //Registrar_Administrador
        //[HttpPost]
        //[Route("api/Usuarios/PostActualizarUsuario")]
        //public string actualizarUsuario([FromBody] JObject Vs_entrada)
        //{
        //    try
        //    {
        //        UUsuario usuario = new UUsuario();

        //        usuario.Nombres = Vs_entrada["nombre"].ToString();
        //        usuario.Apellidos = Vs_entrada["apellidos"].ToString();
        //        usuario.User_name = Vs_entrada["user_name"].ToString();
        //        usuario.Correo = Vs_entrada["correo"].ToString();
        //        usuario.Password = Vs_entrada["contra"].ToString();
        //        usuario.Documento = Vs_entrada["documento"].ToString();
        //        usuario.Entidad = int.Parse(Vs_entrada["entidad"].ToString());
        //        usuario.Tipo_usuario = int.Parse(Vs_entrada["tipoUsuario"].ToString());
        //        new LUsuarios().actualizarUsuario(usuario);
        //        return "Actualizacion exitosa";
        //    }
        //    catch(Exception ex)
        //    {
        //        return "Error interno: " + ex.StackTrace;
        //    }

        //}

        [HttpPost]
        [Route("api/Usuarios/PostIniciarSesion")]
        public async Task<UUsuario> LG_Principal1([FromBody] JObject Vs_entrada){
            UUsuario usuario = new UUsuario();
            usuario.Correo = Vs_entrada["correo"].ToString();
            usuario.Password = Vs_entrada["contra"].ToString();
            return await new LUsuarios().LG_Principal1(usuario);
        }

        //public string LLB_recuperarContra()
        //{
        //    return new LUsuarios().re
        //}

        [HttpPost]
        [Route("api/user/PostLG_Principal2")]
        public async Task<UUsuario> LG_Principal2(LoginRequest usuario){
            return await new LUsuarios().LG_Principal2(usuario);
        }



        [HttpPost]
        [Route("api/user/PostguardarToken")]
        public IHttpActionResult guardarToken(UToken_Seguridad token_seguridad){
            try{
                if (token_seguridad == null){
                    return BadRequest("Alguna de las variables requeridas viene vacia o null, intentelo de nuevo");
                }else{
                    new LUsuarios().guardarToken(token_seguridad);
                    return Ok();
                }
            }catch (Exception ex){
                return BadRequest("hay un problema interno: " + ex.StackTrace);
            }

        }
        //
        [Authorize]
        [HttpPost]
        [Route("api/user/PostCrear_Emergencia_Usuario")]
        public IHttpActionResult Crear_Emergencia_Usuario([FromBody] JObject Vs_entrada){
            try{
                UEmergencia emer = new UEmergencia();
                emer.Tipo_emergencia= int.Parse(Vs_entrada["tipo_emergencia"].ToString());
                emer.Nivel_emergencia= int.Parse(Vs_entrada["nivel_emergencia"].ToString()); ;
                emer.Descripcion = Vs_entrada["descripcion"].ToString();
                emer.Usuario_reporta= int.Parse(Vs_entrada["id_usuario"].ToString());
                emer.Estado_emergencia= 1;
                emer.Ubicacion= Vs_entrada["ubicacion"].ToString();
                emer.Entidad_solicitada= Vs_entrada["entidad_solicitada"].ToString();
                emer.Ciudad= Vs_entrada["ciudad"].ToString();
                if (emer== null){
                    return BadRequest("Alguna de las variables requeridas viene vacia o null, intentelo de nuevo");
                }
                else{
                    new LUsuarios().crear_emergencia_usuario(emer);
                    return Ok(" Emergencia Agregada Correctamente");
                }
            }
            catch (Exception ex){
                return BadRequest("hay un problema interno: " + ex.StackTrace);
            }
        }
        //
        //
        [Authorize]
        [HttpPost]
        [Route("api/user/PostCancelar_Emergencia_Usuario")]
        public IHttpActionResult Cancelar_Emergencia_Usuario([FromBody] JObject Vs_entrada){
            try {
                UEmergencia emer = new UEmergencia();                
                emer.Id = int.Parse(Vs_entrada["Id_emergencia"].ToString());
                emer.Estado_emergencia = 4;              
                if (emer == null){
                    return BadRequest("Alguna de las variables requeridas viene vacia o null, intentelo de nuevo");
                }else{
                    new LUsuarios().cancelar_emergencia_usuario(emer);
                    return Ok(" Emergencia Cancelada Correctamente");
                }
            } catch (Exception ex){
                return BadRequest("hay un problema interno: " + ex.StackTrace);
            }
        }
        //
        [Authorize]
        [HttpPost]
        [Route("api/user/PostComentario_emergencia_usuario")]
        public IHttpActionResult Comentario_emergencia_usuario([FromBody] JObject Vs_entrada){
            try{
                UEmergencia emer = new UEmergencia();
                emer.Id = int.Parse(Vs_entrada["Id_emergencia"].ToString());
                emer.Comentario_usuario= Vs_entrada["comentario_usuario"].ToString();
                if (emer == null){
                    return BadRequest("Alguna de las variables requeridas viene vacia o null, intentelo de nuevo");
                }else{
                    new LUsuarios().comentario_usuario_emergencia(emer);
                    return Ok("  comentario agregado Correctamente");
                }
            }catch (Exception ex){
                return BadRequest("hay un problema interno: " + ex.StackTrace);
            }
        }
        //
        //
        //Registrar_Usuario
        [HttpGet]
        [Route("api/Usuarios/PostObtener_Usuarios")]
        public List<UUsuario> Obtener_Usuarios(){
            return new LUsuarios().ObtenerUsuarios();
        }
        //Registrar_Usuario

        //
        /////////
    }
}