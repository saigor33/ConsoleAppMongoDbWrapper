namespace ConsoleAppMongoDbWrapper;

public abstract class BaseDocumentsQuery<TResult, THandler> : BaseQuery<TResult, THandler>
    where TResult : IResult
    where THandler : IHandler
{
    protected BaseDocumentsQuery(string tableName) : base(tableName)
    {
    }

    public override Task<TResult> ExecuteAsync(IMongoSession mongoSession, IMongoDatabase mongoDatabase)
    {
        IMongoCollection mongoCollection = null;
        return ExecuteAsync(mongoSession, mongoCollection);
    }

    protected abstract Task<TResult> ExecuteAsync(IMongoSession mongoSession, IMongoCollection mongoCollection);
}