namespace ConsoleAppMongoDbWrapper;

public class GetQueryHandler
    : BaseQuery<IGetQueryResult, GetQueryHandler>.IHandlerResultSetter,
        IHandler
{
    public bool hasResult => result != null;
    public IGetQueryResult result => _result;

    private IGetQueryResult _result;

    public void SetResult(IGetQueryResult result)
    {
        _result = result;
    }
}