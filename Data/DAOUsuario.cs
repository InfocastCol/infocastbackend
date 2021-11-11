using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Utilitarios;


namespace Data
{
    public class DAOUsuario
    {
        public void insertUsuario(UUsuario usuario)
        {
            using (var db = new Mapeo())
            {
                db.usuario.Add(usuario);
                db.SaveChanges();
            }
        }

        public UUsuario getCorreoByregistrarse(string correo)
        {

            return new Mapeo().usuario.Where(x => (x.Correo.Equals(correo))).FirstOrDefault();
        }
        //envio dinamico clase generarToken dinamico correo
        public UUsuario getCorreoByCorreos(string correo)
        {
            return new Mapeo().usuario.Where(x => (x.Correo.Contains(correo))).FirstOrDefault();
        }
        public async Task<UUsuario> loginusuario(UUsuario usuario)
        {
            return await new Mapeo().usuario.Where(x => x.Correo.ToUpper().Equals(usuario.Correo.ToUpper()) && x.Password.Equals(usuario.Password)).FirstOrDefaultAsync();
        }

        //public void actualizarPerfil(UUsuario usuario)
        //{
        //    using (var db = new Mapeo())
        //    {
        //        UUsuario usuarioAnterior = db.usuario.Where(x => x.Id == usuario.Id).First();

        //        usuarioAnterior.Nombres = usuario.Nombres;
        //        usuarioAnterior.Apellidos = usuario.Apellidos;
        //        usuarioAnterior.User_name = usuario.User_name;
        //        usuarioAnterior.Correo = usuario.Correo;
        //        usuarioAnterior.Password = usuario.Password;
        //        usuario.Documento = usuario.Documento;

        //        db.usuario.Attach(usuarioAnterior);
        //        var entry = db.Entry(usuarioAnterior);
        //        entry.State = EntityState.Modified;
        //        db.SaveChanges();
        //    }
        //}

        public async Task<UUsuario> loginusuario1(LoginRequest user)
        {

            using (var db = new Mapeo())
            {
                UUsuario usuario = await db.usuario.Where(x => x.Correo.ToUpper().Equals(user.Correo.ToUpper()) && x.Password.Equals(user.Contrasenia)).FirstOrDefaultAsync();
                if (usuario != null)
                {
                    //var propiedades = db.aplicacion.Where(x => x.Id == user.AplicacionID).FirstOrDefault();
                    //usuario.Expiracion = propiedades.Expiracion;
                    //usuario.Key = propiedades.Key;
                    //usuario.AplicacionId = user.AplicacionID;

                    
                    var propiedades = db.aplicacion.Where(x => x.Id == user.AplicacionID).FirstOrDefault();
                    usuario.Expiracion = propiedades.Expiracion;
                    usuario.Key = propiedades.Key;
                    usuario.AplicacionId = user.AplicacionID;
                }
                return usuario;
            }
        }

        public UUsuario nuevaContrasena(UUsuario usuario){
            return new Mapeo().usuario.Where(x => x.Password.Equals(usuario.Password)).FirstOrDefault();
        }

        public UUsuario getUserByUserName(string correo){
            return new Mapeo().usuario.Where(x => x.Correo.ToUpper().Equals(correo.ToUpper())).FirstOrDefault();
        }
        //
        public UUsuario Verificar_entidad_existente(UUsuario usuario){

            return new Mapeo().usuario.Where(x => x.Entidad == usuario.Entidad && x.Ciudad == usuario.Ciudad).FirstOrDefault();
        }

        //
        public List<UUsuario> ObtenerUsuarios()
        {
            using (var db = new Mapeo())
            {
                return db.usuario.ToList();
            }
        }


        //
    }

}
