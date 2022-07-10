namespace Scripture.Api.Exceptions;

public class ValueNotSupportedException : Exception
{
    public ValueNotSupportedException(string key) : base($" ({key}) is not supported.")
    {

    }
    public ValueNotSupportedException(object type, string key) : base($"({key}) is not supported in {nameof(type)}.")
    {

    }
}
