using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_T1
{
    internal class Notification
    {
        public Developer Recipient { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }

        public Notification(Developer recipient, string message, DateTime timestamp)
        {
            Recipient = recipient;
            Message = message;
            Timestamp = timestamp;
        }
    }
}
