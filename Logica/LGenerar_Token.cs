using Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace Logica
{
    public class LGenerar_Token
    {
        string respuesta;
        public string LB_Recuperar3(String TB_Correo)
        {

            UUsuario usuario = new DAOUsuario().getUserByUserName(TB_Correo);
            if (usuario != null)
            {
                UToken validarToken = new DAOSeguridad().getTokenByUser(usuario.Id);
                UToken token = new UToken();
                token.Fecha_creacion = DateTime.Now;
                token.Usuario = usuario.Id;
                token.Fecha_vencimiento = DateTime.Now.AddHours(1);
                token.Token = encriptar(JsonConvert.SerializeObject(token));
                new DAOSeguridad().insertarToken(token);
                Correo correo = new Correo();
                new DAOUsuario().getCorreoByCorreos(usuario.Correo);
                String mensaje = "su link de acceso es: " + "http://localhost:56248/View/RecuperarContrasenia.aspx?" + token.Token;
                correo.enviarCorreo(usuario.Correo, token.Token, mensaje);
                respuesta = "Su nueva contraseña ha sido enviada a su correo" + token.Token; ;
                //}
            }
            else
            {
                respuesta = "El usuario digitado no existe";
            }
            return respuesta;
        }

            private string encriptar(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }
        public UToken LB_Recuperar3(UUsuario usuario)
        {
            return new DAOSeguridad().getTokenByUser(usuario.Id);
        }
        public void LB_Recuperar4(UToken token)
        {
            new DAOSeguridad().insertarToken(token);
        }
        public void LB_Recuperar5(UUsuario usuario)
        {
            new DAOUsuario().getCorreoByCorreos(usuario.Correo);
        }
    }
}
