namespace ConsoleAppMongoDbWrapper;

public partial class DbTable<T> where T : DbTable<T>
{
    private readonly string _tableName;

    public DbTable(string tableName)
    {
        _tableName = tableName;
    }

    public GetTypedQueryBuilder Get()
    {
        return new GetTypedQueryBuilder(_tableName);
    }
}