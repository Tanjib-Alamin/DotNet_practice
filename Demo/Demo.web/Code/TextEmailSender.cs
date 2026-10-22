namespace Demo.web.Code
{
    public class TextEmailSender:IEmailSender
    {
        public TextEmailSender(string a)
        {

        }
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine("text Email");
        }
    }
}
