namespace Demo.web.Code
{
    public class HtmlEmailSender:IEmailSender
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine("html email");
        }
    }
}
