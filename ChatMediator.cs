using System;
using System.Collections.Generic;

public interface IChatMediator
{
	void SendMessage(User sender, string message);
}

public class ChatMediator : IChatMediator
{
	private List<User> users = new List<User>();

	public void AddUser(User user)
	{
		users.Add(user);
	}

	public void SendMessage(User sender, string message)
	{
		foreach (var user in users)
		{
			if (user != sender)
			{
				user.ReceiveMessage(message);
			}
		}
	}
}
