using Boletobus.Infraestructure.Base;
using Boletobus.Infraestructure.Notification.Interfaces;
using Boletobus.Infraestructure.Notification.Models;


namespace Boletobus.Infraestructure.Notification.Services
{
    public class EmailService : INotificationService<EmailModel>
    {
        public Task<NotificationResult> Send(EmailModel model)
        {
            throw new NotImplementedException();

        }
    }
}
