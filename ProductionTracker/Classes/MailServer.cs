using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System;

namespace ProductionTracker.Classes
{
    class MailServer
    {
        SmtpClient smtpClient = new SmtpClient();
        MailAddress from = new MailAddress("roster@patritti.com", 
            "roster "+(char)0xD8+" service",
            System.Text.Encoding.UTF8);
        
        List<MailAddress> addresses = new List<MailAddress>();
        MailMessage message;

        
   }
}
