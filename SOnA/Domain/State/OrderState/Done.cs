using Domain.Exception;
using Domain.Model;

namespace Domain.State;

public class Done : OrderState
{
	public void pay (Customer customer)
	{
		customer.commPrefs.SendConfirmed();
	}

	public void cancel (Customer customer)
	{
		throw new StateException();
	}
}