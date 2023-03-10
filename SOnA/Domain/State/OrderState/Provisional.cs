using Domain.Client;
using Domain.Model;

namespace Domain.State;

public class Provisional : ObservableOrderState
{
	public Provisional(List<ISender> observers) : base(observers)
	{
	}

	public override void remind()
	{
		foreach (ISender sender in observers)
		{
			sender.SendReminder();
		}
	}
}