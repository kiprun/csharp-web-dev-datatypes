namespace HelloMethods
{
    public class Message
    {
        private static string GetMessage(string lang)
        {
            if (lang.Equals("sp"))
            { 
                return "Hola Mundo";
            }
            else if (lang.Equals("fr"))
            {
                return "Bonjour le monde";
            }
            else if (lang.Equals("hi"))
            {
                return "Kiss my Grits!!";
            }
            else
            {
                return "Hello World";
            }
        }
    }
}
