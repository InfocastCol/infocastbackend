using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace Data
{
   public class DAOEntidad
    {
        public void insertEntidad(UEntidades entidades)
        {
            using (var db = new Mapeo())
            {
                db.entidad.Add(entidades);
                db.SaveChanges();
            }
        }
    }
}
