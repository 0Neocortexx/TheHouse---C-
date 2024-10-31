namespace Util.ManipulationStrings
{
    public class LoginStrings
    {
        public static string FormatarEmail(string text)
        {
            try
            {
                text = text.Replace(" ", "");
                text = text.ToLower();
                return text;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
