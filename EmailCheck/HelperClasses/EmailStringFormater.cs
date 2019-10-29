using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailCheck.HelperClasses
{
    public static class EmailStringFormater
    {
        public static string deleteCC(string email)
        {
            string badString = "\r\nCc:";
            int containsBadStringChars = 0;
            char[] charArray = email.ToCharArray();
            Array.Reverse(charArray);
            string reverseEmail = new string(charArray);
            for (int i=0; i < badString.Length; i++)
            {
                if (reverseEmail.Length > badString.Length)
                {
                    if (reverseEmail[badString.Length - i - 1] == badString[i])
                    {
                        containsBadStringChars++;
                    }
                }
            }
            if(badString.Length == containsBadStringChars)
            {
                email = email.Remove(email.Length - badString.Length, badString.Length);
            }
            return email;
        }
        public static string deleteContentType(string email)
        {
            string badString = "\r\nContent-Type:";
            int containsBadStringChars = 0;
            char[] charArray = email.ToCharArray();
            Array.Reverse(charArray);
            string reverseEmail = new string(charArray);
            for (int i = 0; i < badString.Length; i++)
            {
                if (reverseEmail.Length > badString.Length)
                {
                    if (reverseEmail[badString.Length - i - 1] == badString[i])
                    {
                        containsBadStringChars++;
                    }
                }
            }
            if (badString.Length == containsBadStringChars)
            {
                email = email.Remove(email.Length - badString.Length, badString.Length);
            }
            return email;
        }
    }
}
