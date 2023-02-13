namespace Domain.Exception;

public class StateException : InvalidOperationException
{
    public string message()
    {
        return "This is not a valid function for this state";
    }
}