using Domain.Client;

namespace Domain.Model;

public class Customer
{
	private string name { get; set; }
	private string email { get; set; }
	private string phoneNumber { get; set; }
	public ISender commPrefs { get; private set; }

	public Customer (string name, string email, string phoneNumber, ISender commPrefs)
	{
		this.name = name;
		this.email = email;
		this.phoneNumber = phoneNumber;
		this.commPrefs = commPrefs;
	}
}