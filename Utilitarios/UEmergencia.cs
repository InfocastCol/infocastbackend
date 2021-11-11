using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios{
    [Serializable]
    [Table("emergencia", Schema = "informacion")]
   public class UEmergencia{
        private int id;
        private int tipo_emergencia;
        private int nivel_emergencia;
        private string descripcion;
        private int usuario_reporta;
        private int estado_emergencia;
        private string ubicacion;
        private string entidad_solicitada;
        private int id_entidad;
        private string comentario_usuario;
        private string comentario_entidad;
        private string ciudad;

        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("tipo_emergencia")]
        public int Tipo_emergencia { get => tipo_emergencia; set => tipo_emergencia = value; }
        [Column("nivel_emergencia")]
        public int Nivel_emergencia { get => nivel_emergencia; set => nivel_emergencia = value; }
        [Column("descripcion")]
        public string Descripcion { get => descripcion; set => descripcion = value; }
        [Column("usuario_reporta")]
        public int Usuario_reporta { get => usuario_reporta; set => usuario_reporta = value; }
        [Column("estado_emergencia")]
        public int Estado_emergencia { get => estado_emergencia; set => estado_emergencia = value; }
        [Column("ubicacion")]
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        [Column("entidad_solicitada")]
        public string Entidad_solicitada { get => entidad_solicitada; set => entidad_solicitada = value; }
        [Column("id_entidad")]
        public int Id_entidad { get => id_entidad; set => id_entidad = value; }
        [Column("comentario_usuario")]
        public string Comentario_usuario { get => comentario_usuario; set => comentario_usuario = value; }
        [Column("comentario_entidad")]
        public string Comentario_entidad { get => comentario_entidad; set => comentario_entidad = value; }
        [Column("ciudad")]
        public string Ciudad { get => ciudad; set => ciudad = value; }
    }
}
