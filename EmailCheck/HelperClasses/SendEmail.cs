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
            List<MailAddress> toAddresses = new List<MailAddress>();
            foreach(string email in toEmails)
            {
                if (!email.Contains(Environment.NewLine))
                {
                    toAddresses.Add(new MailAddress(email, email));
                }
            }
            string messageBodyFormated = MessageBodyFormat(emailBody);
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
                var message = new MailMessage(fromAddress, mailAddress);

                    message.Subject = emailSubject.Replace("\n","");
                    message.Body = messageBodyFormated;

                    smtp.Send(message);
                
            }
        }
        private string MessageBodyFormat(string emailBody)
        {
            List<char> messageBodySplit = new List<char>();
            for (int i = 0; i < emailBody.Length; i++)
            {
                messageBodySplit.Add(emailBody[i]);
            }
            int messageBodyLength = messageBodySplit.Count;
            for (int i = 0; i < messageBodySplit.Count; i++)
            {
                if (messageBodySplit[i] == '\n')
                {
                    messageBodySplit.RemoveAt(i);
                    i = i - 1;
                }
                else
                {
                    i = messageBodyLength;
                }
            }
            string newBody = "";
            for (int i = 0; i < messageBodySplit.Count; i++)
            {
                newBody = newBody.Insert(newBody.Length, messageBodySplit[i].ToString());
            }
            return newBody;
        }
    }
}
