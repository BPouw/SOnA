using Domain.Exception;
using Domain.Model;
using Domain.Client;

namespace Domain.State;

public abstract class OrderState
{
	public List<ISender> observers { get; set; }

	public OrderState (List<ISender> observers)
	{
		this.observers = observers;
	}

	public virtual void create()
	{
		throw new StateException();
	}

	public virtual void remind()
	{
		throw new StateException();
	}

	public virtual void cancel()
	{

		foreach (ISender sender in observers)
		{
			sender.SendCancelled();
		}
	}

	public virtual void pay()
	{
		throw new StateException();
	}
}