namespace Domain.State;

public class Submitted : OrderState
{
	public string whatIsMyState()
	{
		return "I have been submitted but someone is gonna have to pay for me";
	}
}