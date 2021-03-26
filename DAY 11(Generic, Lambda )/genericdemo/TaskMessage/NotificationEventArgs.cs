using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMessage
{
    public class NotificationEventArgs : EventArgs
    {
        public bool status;
        public NotificationEventArgs(bool incomingStatus)
        {
            this.status = incomingStatus;
        }
    }
}
