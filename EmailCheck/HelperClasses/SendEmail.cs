using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace EmailCheck
{
    public class SendEmail
    {
        private string fromEmail;
        private string fromPassword;
        public SendEmail(string fromEmail,string fromPassword)
        {
            this.fromEmail = fromEmail;
            this.fromPassword = fromPassword;
        }
        public void SendEmails(List<string> toEmails, string emailSubject, string emailBody)
        {
            var fromAddress = new MailAddress(fromEmail, fromEmail);
            string subject = emailSubject;
            string body = emailBody;
            List<MailAddress> toAddresses = new List<MailAddress>();
            foreach(string email in toEmails)
            {
                toAddresses.Add(new MailAddress(email, email));
            }

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            foreach (MailAddress mailAddress in toAddresses)
            {
                using (var message = new MailMessage(fromAddress, mailAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
        }
    }
}
