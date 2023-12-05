// File: NotificationService.cs
using System;

namespace MediatorPatternExample
{
    public class NotificationService
    {
        private IChatMediator mediator;

        public NotificationService(IChatMediator mediator)
        {
            this.mediator = mediator;
        }

        public void SendNotification(string notification)
        {
            Console.WriteLine($"Notification Service sends: {notification}");
            mediator.SendMessage(null, notification); // Sending notification to all users
        }
    }
}
