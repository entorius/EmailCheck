using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailCheck
{
    public class Mail
    {
        private string subject;
        private string body;
        public Mail(string subject, string body)
        {
            this.subject = subject;
            this.body = body;
        }
        public string GetSubject()
        {
            return this.subject;
        }
        public void SetSubject(string subject)
        {
            this.subject = subject;
        }
        public string GetBody()
        {
            return body;
        }
        public void SetBody(string body)
        {
            this.body = body;
        }
    }
}
