namespace ConsoleAppMongoDbWrapper;

public abstract partial class DbTable<T>
: IQueryBuilderFactory<>
    where T : DbTable<T>
{
    private readonly string _tableName;

    protected DbTable(string tableName)
    {
        _tableName = tableName;
    }

    public CommonTypedGetQueryBuilder Get()
    {
        return new CommonTypedGetQueryBuilder(_tableName);
    }
}

public interface IQueryBuilderFactory<TGetQueryBuilder>
{
    public TGetQueryBuilder Get();
}