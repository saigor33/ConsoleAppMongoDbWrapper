namespace ConsoleAppMongoDbWrapper;

public class InternalException : Exception
{
    private readonly Exception _exception;

    public InternalException(Exception exception)
    {
        _exception = exception;
    }

    public InternalException(string unahdledType)
    {
        throw new NotImplementedException();
    }
}