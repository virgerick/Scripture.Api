namespace Scripture.Api.Exceptions;

public class NotFoundException : Exception
{
	public NotFoundException() : base("Item could not be found.")
	{

	}
	public NotFoundException(string message) : base(message)
	{

	}
	public NotFoundException(string type, object key) : base($"{type} ({key}) could not be found.")
	{

	}
}
