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
    [Table("estado_emergencia", Schema = "informacion")]
    class UEstado_emergencia
    {
        private int id;
        private String estado;

        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("estado")]
        public string Estado { get => estado; set => estado = value; }
    }
}
