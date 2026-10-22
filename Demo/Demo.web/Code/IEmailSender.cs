namespace Demo.web.Code
{
    public interface IEmailSender
    {
        public void SendEmail(string email, string subject, string body);
    }
}
