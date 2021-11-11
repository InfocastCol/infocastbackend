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
    [Table("rol", Schema = "informacion")]
    class URol
    {
        private int id;
        private String tipo_usuario;
        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("tipo_usuario")]
        public string Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }
    }
}
