using Boletobus.Infraestructure.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletobus.Infraestructure.Notification.Interfaces
{
    public interface INotificationService<Tmodel> where Tmodel : class
    {
        public Task<NotificationResult> Send(Tmodel model);
    }
}
