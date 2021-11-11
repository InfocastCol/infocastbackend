using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class UMac
    {
        private int id;
        private UUsuario usuario;
        private DateTime FechaInicio;
        private string ip;
        private string mac;
        private string session;
        private int user_id;
        private string url;
        private bool falso;
        private bool verdadero;
        private bool decision;
        private Nullable<DateTime> fecha_fin;
   
        public UUsuario Usuario { get => usuario; set => usuario = value; }

        public string Ip { get => ip; set => ip = value; }
        public string Mac { get => mac; set => mac = value; }
        public string Session { get => session; set => session = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public string Url { get => url; set => url = value; }
        public DateTime? Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
        public int Id { get => id; set => id = value; }
        public DateTime Fecha_Inicio1 { get => FechaInicio; set => FechaInicio = value; }
        public bool Falso { get => falso; set => falso = value; }
        public bool Verdadero { get => verdadero; set => verdadero = value; }
    }
}
