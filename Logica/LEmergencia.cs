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
