using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Utilitarios;

namespace Logica
{
    class LRecuperarContrasena
    {

        public UUsuario LB_Cambiar (UUsuario usuario)
        {
            UUsuario usuar = new UUsuario();
            return usuar = new DAOUsuario().nuevaContrasena(usuario);
        }

    }
}
