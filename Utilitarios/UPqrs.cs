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
    [Table("pqrs", Schema = "informacion")]
    class UPqrs
    {
        private int id;
        private String nombres;
        private String correo;
        private String mensaje;
        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("nombres")]
        public string Nombres { get => nombres; set => nombres = value; }
        [Column("correo")]
        public string Correo { get => correo; set => correo = value; }
        [Column("mensaje")]
        public string Mensaje { get => mensaje; set => mensaje = value; }
    }
}
