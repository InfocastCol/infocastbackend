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
    [Table("tipo", Schema = "informacion")]
    class UTipo
    {
        private int id;
        private String tipo_emergencia;
        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("tipo_emergencia")]
        public string Tipo_emergencia { get => tipo_emergencia; set => tipo_emergencia = value; }
    }
}
