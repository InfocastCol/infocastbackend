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
    [Table("aplicaciones", Schema = "seguridad")]
    public class UAplicacion
    {
        private int id;
        private string nombre;
        private int expiracion;
        private string key;
        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Column("expiracion")]
        public int Expiracion { get => expiracion; set => expiracion = value; }
        [Column("key")]
        public string Key { get => key; set => key = value; }
    }
}
