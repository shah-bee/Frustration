using System;
using System.Collections.Generic;
using System.Text;

namespace Frustration.EventsAndDelegates
{
    public class MailService
    {
        public MailService()
        {
           
        }
          

        public void SendMail(object source, EventArgs args) {

            Console.WriteLine("Mail sent");
        }
    }
}
