using SolidExamples.Models;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace SolidExamples.Services
{
    public class UserService
    {
        private readonly SmtpClient _smtpClient = new SmtpClient();

        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new ValidationException("Email is not an email");

            var user = new User(email, password);

            SendEmail(new MailMessage("test-no-reply@gmail.com", email) { Subject = "Hello new user" });
        }

        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
        }
    }
}
