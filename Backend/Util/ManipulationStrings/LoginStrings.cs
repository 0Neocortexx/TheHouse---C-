namespace Util.ManipulationStrings
{
    public class LoginStrings
    {
        public static string FormatarEmail(string text)
        {
            try
            {
                // Remove os espaços
                text = text.Replace(" ", "");

                // Define o texto em minusculo
                text = text.ToLower();

                // Retorna Texto
                return text;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
