namespace Domain.State;

public class Provisional : OrderState
{
	public string whatIsMyState()
	{
		return "I am provisional... pay soon";
	}
}