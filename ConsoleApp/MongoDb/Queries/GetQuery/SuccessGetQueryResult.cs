namespace ConsoleAppMongoDbWrapper;

public class SuccessGetQueryResult : IGetQueryResult
{
    public List<Dictionary<string, object>> rows => _rows;

    private readonly List<Dictionary<string, object>> _rows;

    public SuccessGetQueryResult(List<Dictionary<string, object>> rows)
    {
        _rows = rows;
    }
}