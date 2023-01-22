namespace ConsoleAppMongoDbWrapper;

public partial class DbTable<T> where T : DbTable<T>
{
    private readonly string _tableName;

    public DbTable(string tableName)
    {
        _tableName = tableName;
    }

    public CommonTypedGetQueryBuilder Get()
    {
        return new CommonTypedGetQueryBuilder(_tableName);
    }
}