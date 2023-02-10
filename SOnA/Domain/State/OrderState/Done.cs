namespace Domain.State;

public class Done : OrderState
{
	public string whatIsMyState()
	{
		return "I have been paid for enjoy the show";
	}
}