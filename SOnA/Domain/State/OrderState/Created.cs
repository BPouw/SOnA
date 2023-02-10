namespace Domain.State;

public class Created : OrderState
{
	public string whatIsMyState()
	{
		return "I have been created";
	}
}