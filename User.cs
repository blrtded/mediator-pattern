using System;

public abstract class User
{
    protected IChatMediator mediator;
    public string Name { get; }

    public User(IChatMediator mediator, string name)
    {
        this.mediator = mediator;
        this.Name = name;
    }

    public abstract void SendMessage(string message);
    public abstract void ReceiveMessage(string message);
}

public class ChatUser : User
{
    public ChatUser(IChatMediator mediator, string name) : base(mediator, name) { }

    public override void SendMessage(string message)
    {
        Console.WriteLine($"{Name} sends: {message}");
        mediator.SendMessage(this, message);
    }

    public override void ReceiveMessage(string message)
    {
        Console.WriteLine($"{Name} receives: {message}");
    }
}
