using Domain.Client;

namespace Domain.State;

public class Created : OrderState
{
	public Created(List<ISender> observers) : base(observers)
	{
	}
}