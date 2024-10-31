using System.Security.Cryptography;
using System.Text;

namespace Security.Criptopass
{
    public class Criptografia
    {
        public static string GerarHashSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input); // Converte a string para bytes
                byte[] hashBytes = sha256.ComputeHash(inputBytes);  // Gera o hash

                // Converte o hash para uma string hexadecimal
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // Formato hexadecimal
                }

                return sb.ToString();
            }
        }
    }
}
