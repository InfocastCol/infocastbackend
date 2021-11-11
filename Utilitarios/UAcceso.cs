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
    [Table("acceso", Schema = "seguridad")]
    public class UAcceso
    {
        private int id;
        private int user_id;
        private DateTime fecha_ingreso;
        private Nullable<DateTime> fecha_salida;
        private string ip;
        private string mac;
        private string session;
        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("user_id")]
        public int User_id { get => user_id; set => user_id = value; }
        [Column("fecha_ingreso")]
        public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        [Column("fecha_salida")]
        public Nullable<DateTime> Fecha_salida { get => fecha_salida; set => fecha_salida = value; }
        [Column("ip")]
        public string Ip { get => ip; set => ip = value; }
        [Column("mac")]
        public string Mac { get => mac; set => mac = value; }
        [Column("session")]
        public string Session { get => session; set => session = value; }
    }
}
