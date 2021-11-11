using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using Data;
namespace Logica{
    public class LEmergencia {
        //
        public List<UEmergencia> Obtener_todas_emergencias(){
            return new DAOEmergencia().Obtener_todas_emergencias();
        }
        //
        public List<UEmergencia> Obtener_emergencias_sinAtender()
        {
            return new DAOEmergencia().Obtener_emergencias_sinAtender();
        }
        //
        public List<UEmergencia> Obtener_mis_emergencias_entidad(int identidad)
        {
            return new DAOEmergencia().Obtener_mis_emergecias_entidad(identidad);
        }
        //
        public List<UEmergencia> Obtener_mis_emergencias_usuario(int idusuario)
        {
            return new DAOEmergencia().Obtener_mis_emergencias_usuario(idusuario);
        }
        //
        public void Comentario_emergencia_usuario(UEmergencia emergencia){
            new DAOEmergencia().Comentario_emergencia_usuario(emergencia);
        }
        //
        //
        public void Comentario_emergencia_entidad(UEmergencia emergencia)
        {
            new DAOEmergencia().Comentario_emergencia_entidad(emergencia);
        }
        //

        //
    }
}
