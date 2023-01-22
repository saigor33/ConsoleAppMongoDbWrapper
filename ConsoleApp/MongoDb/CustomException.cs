namespace ConsoleAppMongoDbWrapper;

public class CustomException : Exception
{
    private readonly Exception _exception;

    public CustomException(Exception exception)
    {
        _exception = exception;
    }

    public CustomException(string unahdledType)
    {
        throw new NotImplementedException();
    }
}