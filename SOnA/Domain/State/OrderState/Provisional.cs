using Domain.Model;

namespace Domain.State;

public class Provisional : OrderState
{
	public void remind(Customer customer)
	{
		customer.commPrefs.SendReminder();
	}
}