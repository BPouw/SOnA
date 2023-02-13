using Domain.Client;
using Domain.Exception;
using Domain.Model;

namespace Domain.State;

public class Done : ObservableOrderState
{
	public Done(List<ISender> observers) : base(observers)
	{
	}

	public override void pay ()
	{
		foreach (ISender sender in observers)
		{
			sender.SendConfirmed();
		}
	}

	public override void cancel ()
	{
		throw new StateException();
	}
}