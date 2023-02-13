using Domain.Client;

namespace Domain.State;

public class Submitted : ObservableOrderState
{
	public Submitted(List<ISender> observers) : base(observers)
	{
	}
}