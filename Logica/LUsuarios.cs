using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using Data;

namespace Logica{
    public class LUsuarios{
        public void InsertarAcceso(UAcceso acceso){
            new DAOSeguridad().insertarAcceso(acceso);
        }

        public UUsuario LBT_Registrar(string correo){
            DAOUsuario dAOUsuario = new DAOUsuario();
            return dAOUsuario.getCorreoByregistrarse(correo);
        }

        public void Registrar_usuario(UUsuario usuario){
            new DAOUsuario().insertUsuario(usuario);
        }

        public async Task<UUsuario> LG_Principal1(UUsuario usuario1){
            UUsuario usuario = new UUsuario();
            MAC mensaje = new MAC();
            return usuario = await new DAOUsuario().loginusuario(usuario1);

        }

        //public void actualizarUsuario(UUsuario usuario)
        //{
        //    DAOUsuario daousuario = new DAOUsuario();
        //    daousuario.actualizarPerfil(usuario);
        //}

        public void guardarToken(UToken_Seguridad token_seguridad){
            new DAOSeguridad().insertarToken_Seguridad(token_seguridad);
        }

        public async Task<UUsuario> LG_Principal2(LoginRequest usuario1){
            
            UUsuario usuario = new UUsuario();        
            MAC conexion = new MAC();          
            return usuario = await new DAOUsuario().loginusuario1(usuario1);
        }
        //
        public void crear_emergencia_usuario(UEmergencia emergencia){
            new DAOEmergencia().insertar_emergencia(emergencia);
        }
        //

        //
        public void cancelar_emergencia_usuario(UEmergencia emergencia){
            new DAOEmergencia().cancelar_emergencia(emergencia);
        }
        //
        public UUsuario Verificar_entidad_existente(UUsuario usuario){
            return new DAOUsuario().Verificar_entidad_existente(usuario);
        }
        //
        public List<UUsuario> ObtenerUsuarios()
        {

            return new DAOUsuario().ObtenerUsuarios(); ;
            
        }
        //
        //
        public void comentario_usuario_emergencia(UEmergencia emergencia)
        {
            new DAOEmergencia().Comentario_emergencia_usuario(emergencia);
        }

        //
        //
    }
}
