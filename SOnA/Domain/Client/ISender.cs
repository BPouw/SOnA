namespace Domain.Client;

public interface ISender
{
	public void SendCancelled();
	public void SendConfirmed();
	public void SendReminder();
}