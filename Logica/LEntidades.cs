using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using Data;

namespace Logica{
     public class LEntidades{
       
        //
        public void Aceptar_emergencia_entidad(UEmergencia emergencia){
            new DAOEmergencia().Aceptar_emergencia(emergencia);
        }
        //
        //
        public void Cancelar_emergencia_entidad(UEmergencia emergencia)
        {
            new DAOEmergencia().cancelar_emergencia(emergencia);
        }
        //
        //
        public void actualizar_estado_emergencia_entidad(UEmergencia emergencia)
        {
            new DAOEmergencia().Cambiar_estado_emergencia_entidad(emergencia);

        }
        //
        //
        public void comentario_entidad_emergencia(UEmergencia emergencia)
        {
            new DAOEmergencia().Comentario_emergencia_entidad(emergencia);
        }
        //
        //
    }
}
