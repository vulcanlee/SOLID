using System;

namespace Cohesion
{
    class Program
    {
        static void Main(string[] args)
        {
            new InvitationService().SendInvite("vulcan.lee@gmail.com", "Vulcan", "Lee");
        }
    }
    public class InvitationService
    {
        public void SendInvite(string email, string firstName, string lastName)
        {
            if (String.IsNullOrWhiteSpace(firstName) ||
                        String.IsNullOrWhiteSpace(lastName))
            {
                throw new Exception("Name is not valid!");
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new Exception("Email is not valid!!");
            }
            SmtpClient client = new SmtpClient();
            client.Send(new MailMessage("mysite@nowhere.com", $"{firstName} {lastName}")
            { Subject = "Please join me at my party!", Body="Content" });
        }
    }
    public class SmtpClient
    {
        public void Send(MailMessage mailMessage)
        {
            Console.WriteLine($"電子郵件 {mailMessage.Subject} 已經送給 {mailMessage.Email}");
        }
    }
    public class MailMessage
    {
        public MailMessage(string email, string name)
        {
            Email = email;
            Name = name;
        }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
