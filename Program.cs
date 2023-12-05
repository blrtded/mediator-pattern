// File: Program.cs
using System;

class Program
{
    static void Main()
    {
        // Create Mediator
        var chatMediator = new ChatMediator();

        // Create Users
        var user1 = new ChatUser(chatMediator, "User 1");
        var user2 = new ChatUser(chatMediator, "User 2");
        var user3 = new ChatUser(chatMediator, "User 3");

        // Create Notification Service
        var notificationService = new NotificationService(chatMediator);

        // Add Users to Mediator
        chatMediator.AddUser(user1);
        chatMediator.AddUser(user2);
        chatMediator.AddUser(user3);

        // User 1 sends a message
        user1.SendMessage("Hello, everyone!");

        // Notification Service sends a notification
        notificationService.SendNotification("Important Announcement!");

        // Output:
        // User 1 sends: Hello, everyone!
        // User 2 receives: Hello, everyone!
        // User 3 receives: Hello, everyone!
        // Notification Service sends: Important Announcement!
    }
}
