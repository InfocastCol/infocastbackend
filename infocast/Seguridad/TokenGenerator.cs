using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utilitarios;
using Logica;
using System.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace infocast.Seguridad
{
    public class TokenGenerator
    {
        public static string GenerateTokenJwt(UUsuario user)
        {
            //TODO: appsetting for Demo JWT - protect correctly this settings
            var secretKey = ConfigurationManager.AppSettings["JWT_SECRET_KEY"];
            var audienceToken = ConfigurationManager.AppSettings["JWT_AUDIENCE_TOKEN"];
            var issuerToken = ConfigurationManager.AppSettings["JWT_ISSUER_TOKEN"];
            var expireTime = ConfigurationManager.AppSettings["JWT_EXPIRE_MINUTES"];



            var securityKey = new SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(secretKey));
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            // create a claimsIdentity 
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name, user.Correo),
                new Claim(ClaimTypes.Role, user.Tipo_usuario.ToString()),
               new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.Rsa,user.Password)
            });

            // create token to the user 
            var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
            var jwtSecurityToken = tokenHandler.CreateJwtSecurityToken(
                audience: audienceToken,
                issuer: issuerToken,
                subject: claimsIdentity,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddMinutes(user.Expiracion),
                signingCredentials: signingCredentials);

            var jwtTokenString = tokenHandler.WriteToken(jwtSecurityToken);

            UToken_Seguridad token_seguridad = new UToken_Seguridad();
            token_seguridad.AppId = user.AplicacionId;
            token_seguridad.Fecha_creacion = DateTime.Now;
            token_seguridad.Fecha_vigencia = DateTime.Now.AddMinutes(user.Expiracion);
            token_seguridad.UserId = user.Id;
            token_seguridad.Token = jwtTokenString;
            new LUsuarios().guardarToken(token_seguridad);
            return jwtTokenString;
        }
    }
}