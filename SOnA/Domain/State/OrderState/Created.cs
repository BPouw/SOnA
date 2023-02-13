using Domain.Client;

namespace Domain.State;

public class Created : ObservableOrderState
{
	public Created(List<ISender> observers) : base(observers)
	{
	}
}