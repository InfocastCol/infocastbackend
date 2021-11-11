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
    [Table("recuperacion", Schema = "seguridad")]
   public  class UToken
    {
        private int id;
        private int usuario;
        private String token;
        private DateTime fecha_creacion;
        private DateTime fecha_vencimiento;
        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("usuario")]
        public int Usuario { get => usuario; set => usuario = value; }
        [Column("token")]
        public string Token { get => token; set => token = value; }
        [Column("fecha_creacion")]
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        [Column("fecha_vencimiento")]
        public DateTime Fecha_vencimiento { get => fecha_vencimiento; set => fecha_vencimiento = value; }
    }
}
