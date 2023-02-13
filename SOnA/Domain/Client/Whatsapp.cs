using Domain.Client;

public class Whatsapp : ISender
{
	private string number;

	public Whatsapp (string number)
	{
		this.number = number;
	}

	public void SendCancelled()
	{
		Console.WriteLine("Whatsapp cancel message");
	}

	public void SendConfirmed()
	{
		Console.WriteLine("Whatsapp confirm message");
	}

	public void SendReminder()
	{
		throw new NotImplementedException();
	}
}