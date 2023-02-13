using Domain.Exception;
using Domain.Model;

namespace Domain.State;

public interface OrderState
{
	public void create(Customer customer)
	{
		throw new StateException();
	}

	public void remind(Customer customer)
	{
		throw new StateException();
	}

	public void cancel(Customer customer)
	{
		customer.commPrefs.SendCancelled();
		Console.WriteLine("you are cancelled");
	}

	public void pay(Customer customer)
	{
		throw new StateException();
	}
}