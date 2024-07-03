using Boletobus.Infraestructure.Base;
using Boletobus.Infraestructure.Notification.Interfaces;
using Boletobus.Infraestructure.Notification.Models;


namespace Boletobus.Infraestructure.Notification.Services
{
    public class WhatsAppService : INotificationService<WhatsAppModel>
    {
        public Task<NotificationResult> Send(WhatsAppModel model)
        {
            throw new NotImplementedException();

        }

    }
}
