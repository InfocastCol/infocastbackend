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
    [Table("usuario", Schema = "informacion")]
    public class UUsuario
    {
        private int id;
        private string user_name;
        private string password;
        private string correo;
        private string nombres;
        private string apellidos;
        private string documento;
        private int entidad;
        private int tipo_usuario;

        private int expiracion;
        private string key;
        private int aplicacionId;
        private int aprobacion;
        private string direccion;
        private string telefono;
        private string modificada;
        private string ciudad;
        private string barrio;


        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("user_name")]
        public string User_name { get => user_name; set => user_name = value; }
        [Column("password")]
        public string Password { get => password; set => password = value; }
        [Column("correo")]
        public string Correo { get => correo; set => correo = value; }
        [Column("nombres")]
        public string Nombres { get => nombres; set => nombres = value; }
        [Column("apellidos")]
        public string Apellidos { get => apellidos; set => apellidos = value; }
        [Column("documento")]
        public string Documento { get => documento; set => documento = value; }
        [Column("entidad")]
        public int Entidad { get => entidad; set => entidad = value; }
        [Column("tipo_usuario")]
        public int Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }

        [NotMapped]
        public int Expiracion { get => expiracion; set => expiracion = value; }
        [NotMapped]
        public string Key { get => key; set => key = value; }
        [NotMapped]
        public int AplicacionId { get => aplicacionId; set => aplicacionId = value; }
        [Column("aprobacion")]
        public int Aprobacion { get => aprobacion; set => aprobacion = value; }
        [Column("direccion")]
        public string Direccion { get => direccion; set => direccion = value; }
        [Column("telefono")]
        public string Telefono { get => telefono; set => telefono = value; }
        [Column("modificada")]
        public string Modificada { get => modificada; set => modificada = value; }
        [Column("ciudad")]
        public string Ciudad { get => ciudad; set => ciudad = value; }
        [Column("barrio")]
        public string Barrio { get => barrio; set => barrio = value; }
    }
}
