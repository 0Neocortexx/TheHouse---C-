using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Security.AcessToken
{
    public class TheHouseToken
    {

        // Construtor vazio para a classe TheHouseToken
        public TheHouseToken() { }

        // Método para gerar um token
        public string GerarToken(string email)
        {
            try
            {
                // Instanciar a classe JwtSecurityTokenHandler
                var tokenHandler = new JwtSecurityTokenHandler();

                // Criar a chave
                var key = Encoding.ASCII.GetBytes("TheHouseTokenSuperSecretKeyMaster2024");

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[] {
                    new Claim("email", $"{email}")
                }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                var tokenString = tokenHandler.WriteToken(token);

                return tokenString;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
