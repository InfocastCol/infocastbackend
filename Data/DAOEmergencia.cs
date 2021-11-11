using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace Data{

    public class DAOEmergencia{
        public void insertar_emergencia(UEmergencia emergencia){
            using (var db = new Mapeo()){
                db.emergencia.Add(emergencia);
                db.SaveChanges();
              //  return pedido2;
            }
        }
        //

        //
        public void cancelar_emergencia(UEmergencia emergencia){
            using (var db = new Mapeo()){
                UEmergencia emergencianterior = db.emergencia.Where(x => x.Id == emergencia.Id).First();
                emergencianterior.Estado_emergencia = emergencia.Estado_emergencia;
                db.emergencia.Attach(emergencianterior);
                var entry = db.Entry(emergencianterior);
                entry.State= EntityState.Modified;                
                db.SaveChanges();               
            }
        }
        //
        //
        public void Aceptar_emergencia(UEmergencia emergencia){
            using (var db = new Mapeo()){
                UEmergencia emergencianterior = db.emergencia.Where(x => x.Id == emergencia.Id).First();
                emergencianterior.Estado_emergencia = emergencia.Estado_emergencia;
                emergencianterior.Id_entidad = emergencia.Id_entidad;
                db.emergencia.Attach(emergencianterior);
                var entry = db.Entry(emergencianterior);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        //
        public List<UEmergencia> Obtener_todas_emergencias(){
            using (var db = new Mapeo()){
                return db.emergencia.ToList();
            }
        }
        //
        public List<UEmergencia> Obtener_emergencias_sinAtender()
        {
            using(var db = new Mapeo())
            {
                return new Mapeo().emergencia.Where(x => x.Estado_emergencia == 1).ToList();
            }
        }
        //
        public List<UEmergencia> Obtener_mis_emergecias_entidad(int identidad)
        {
            using(var db = new Mapeo())
            {
                return new Mapeo().emergencia.Where(x => x.Estado_emergencia == 2 && x.Id_entidad == identidad).ToList();
            }
        }
        public List<UEmergencia> Obtener_mis_emergencias_usuario(int idusuario)
        {
            return new Mapeo().emergencia.Where(x => x.Estado_emergencia == 2 && x.Usuario_reporta == idusuario).ToList();
        }
        //
        public void Comentario_emergencia_usuario(UEmergencia emergencia){
            using (var db = new Mapeo()){
                UEmergencia emergencianterior = db.emergencia.Where(x => x.Id == emergencia.Id).First();
                emergencianterior.Comentario_usuario = emergencia.Comentario_usuario;
                db.emergencia.Attach(emergencianterior);
                var entry = db.Entry(emergencianterior);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        //
        //
        public void Comentario_emergencia_entidad(UEmergencia emergencia){
            using (var db = new Mapeo()){
                UEmergencia emergencianterior = db.emergencia.Where(x => x.Id == emergencia.Id).First();
                emergencianterior.Comentario_entidad = emergencia.Comentario_entidad;
                db.emergencia.Attach(emergencianterior);
                var entry = db.Entry(emergencianterior);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        //
        //
        public void Cambiar_estado_emergencia_entidad(UEmergencia emergencia){
            using (var db = new Mapeo()){
                UEmergencia emergencianterior = db.emergencia.Where(x => x.Id == emergencia.Id).First();
                emergencianterior.Estado_emergencia = emergencia.Estado_emergencia;
                db.emergencia.Attach(emergencianterior);
                var entry = db.Entry(emergencianterior);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        //
        //
    }
}
