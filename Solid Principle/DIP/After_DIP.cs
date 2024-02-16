using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalsDemo.DIP
{
    public interface IMessage
    {
        void SendMessage();
    }

    public class EmailDIP : IMessage
    {
      
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("Mail Sended!!");
        }
    }

    public class SMSDIP : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("SMS Sended!!");
        }
    }

    public class NotificationDIP
    {
        private ICollection<IMessage> _messages;

        public NotificationDIP(ICollection<IMessage> messages)
        {
            this._messages = messages;
        }

        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
}
