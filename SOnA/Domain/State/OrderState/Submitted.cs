using Domain.Client;

namespace Domain.State;

public class Submitted : OrderState
{
	public Submitted(List<ISender> observers) : base(observers)
	{
	}
}