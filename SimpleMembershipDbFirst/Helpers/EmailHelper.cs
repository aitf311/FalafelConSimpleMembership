using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleMembershipDbFirst.Helpers
{
    using System.Net.Mail;


    public class EmailHelper
    {
        public static void SendEmail(string to, string subject, string body)
        {
            var m = new MailMessage("demo@outlook.com", to, subject, body);
            var sc = new SmtpClient();

            try
            {
                sc.EnableSsl = true;
                sc.Send(m);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}