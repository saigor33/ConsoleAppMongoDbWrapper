using System.Collections;

namespace ConsoleAppMongoDbWrapper;

public abstract class BaseQuery<TResult, THandler> :
    IExecuteQuery
    where TResult : IResult
    where THandler : IHandler
{
    public interface IHandlerResultSetter
    {
        public void SetResult(TResult result);
    }

    public BaseQuery(string tableName)
    {
    }

    public abstract THandler CreateHandler();

    public abstract Task<TResult> ExecuteAsync(IMongoSession mongoSession, IMongoDatabase mongoDatabase);

    public IEnumerator Execute(IMongoSession mongoSession, IMongoDatabase mongoDatabase, IHandler handler)
    {
        var handlerResultSetter = (IHandlerResultSetter)handler;
        return Execute(mongoSession, mongoDatabase, handlerResultSetter);
    }

    protected abstract IEnumerator Execute(IMongoSession mongoSession, IMongoDatabase mongoDatabase,
        IHandlerResultSetter handlerResultSetter);
}