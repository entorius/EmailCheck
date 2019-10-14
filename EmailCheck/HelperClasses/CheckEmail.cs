using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;

namespace EmailCheck
{
    public class CheckEmail
    {
        public static async Task<List<MimeKit.MimeMessage>> FetchAllMailbotMessages(string username, string password, DateTime dateFrom = default(DateTime),DateTime dateTo = default(DateTime))
        {
            List<MimeKit.MimeMessage> listMails = new List<MimeKit.MimeMessage>();
            using (var client = new ImapClient())
            {
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(username, password);
                client.Inbox.Open(FolderAccess.ReadOnly);
                IList<UniqueId> uids;
                if (dateFrom != default(DateTime) && dateTo != default(DateTime))
                {
                    uids = await client.Inbox.SearchAsync(SearchQuery.SubjectContains("Delivery Status Notification (Failure)").And(SearchQuery.SentAfter(dateFrom.AddDays(-1)).And(SearchQuery.SentBefore(dateTo.AddDays(1)))));
                }
                else
                {
                    uids = await client.Inbox.SearchAsync(SearchQuery.SubjectContains("Delivery Status Notification (Failure)"));
                }
                    foreach (var uid in uids)
                {
                    var message = client.Inbox.GetMessage(uid);
                    listMails.Add(message);
                }
                client.Disconnect(true);
            }
            return listMails;
        }
        public static List<string> CollectToEmailsFromMessages(List<string> messagesBody)
        {
            List<string> selectedEmails = new List<string>();
            foreach (string messageBody in messagesBody)
            {
                string[] splitedBody = messageBody.Split(' ');
                for (int i = 1; i < splitedBody.Length; i++)
                {
                    if (splitedBody[i - 1].Contains("To:"))
                    {
                        string selectedEmail = splitedBody[i];
                        selectedEmail = selectedEmail.Replace("\"", string.Empty);
                        selectedEmails.Add(selectedEmail);
                    }
                }
            }
            return selectedEmails;
        }
    }
}
