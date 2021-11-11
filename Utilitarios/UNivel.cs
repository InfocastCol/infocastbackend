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
    [Table("nivel", Schema = "informacion")]
    class UNivel
    {
        private int id;
        private String grado_emergencia;
        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("grado_emergencia")]
        public string Grado_emergencia { get => grado_emergencia; set => grado_emergencia = value; }
    }
}
