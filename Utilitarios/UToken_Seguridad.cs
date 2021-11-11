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
    [Table("token_seguridad", Schema = "seguridad")]
    public class UToken_Seguridad
    {
        private int id;
        private int appId;
        private int userId;
        private string token;
        private DateTime fecha_creacion;
        private DateTime fecha_vigencia;

        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("aplicacion_id")]
        public int AppId { get => appId; set => appId = value; }
        [Column("user_id")]
        public int UserId { get => userId; set => userId = value; }
        [Column("token")]
        public string Token { get => token; set => token = value; }
        [Column("fecha_generado")]
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        [Column("fecha_vigencia")]
        public DateTime Fecha_vigencia { get => fecha_vigencia; set => fecha_vigencia = value; }
    }
}
