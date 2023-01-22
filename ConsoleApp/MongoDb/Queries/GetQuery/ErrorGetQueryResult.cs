namespace ConsoleAppMongoDbWrapper;

public class ErrorGetQueryResult : IGetQueryResult
{
    public Exception exception => _exception;

    private readonly Exception _exception;

    public ErrorGetQueryResult(Exception exception)
    {
        _exception = exception;
    }
}