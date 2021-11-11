using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace Data
{
   public  class Mapeo: DbContext
    {
        //Revisar
        //static Mapeo()
        //{
        //    Database.SetInitializer<Mapeo>(null);
        //}
        public Mapeo() : base("name=bd_inicial")
        {

        }
        public DbSet<UEntidades> entidad { get; set; }
        public DbSet<UUsuario> usuario { get; set; }
        public DbSet<UToken_Seguridad> token_seguridad { get; set; }
        public DbSet<UAplicacion> aplicacion { get; set; }
        public DbSet<UAcceso> acceso { get; set; }
        public DbSet<UToken> token  { get; set; }
        public DbSet<UEmergencia> emergencia { get; set; }


    }
}
