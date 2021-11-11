using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    [Serializable]
    [Table("entidades", Schema = "informacion")]
   public class UEntidades
    {
        private int id;
        private string entidad;
        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("entidad")]
        public string Entidad { get => entidad; set => entidad = value; }
    }
}
