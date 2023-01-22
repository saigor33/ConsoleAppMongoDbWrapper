using System.Collections;

namespace ConsoleAppMongoDbWrapper;

public abstract class BaseGetQuery<THandler>
    : BaseDocumentsQuery<IGetQueryResult, THandler>
    where THandler : IHandler

{
    public BaseGetQuery(string tableName) : base(tableName)
    {
    }

    protected override async Task<IGetQueryResult> ExecuteAsync(IMongoSession mongoSession,
        IMongoCollection mongoCollection)
    {
        try
        {
            await Task.Yield();
            return new SuccessGetQueryResult(new List<Dictionary<string, object>>());
        }
        catch (Exception e)
        {
            return new ErrorGetQueryResult(e);
        }
    }

    protected override IEnumerator Execute(IMongoSession mongoSession,
        IMongoDatabase mongoDatabase, IHandlerResultSetter handlerResultSetter)
    {
        Task<IGetQueryResult> task = ExecuteAsync(mongoSession, mongoDatabase);
        while (task.IsCompleted)
            yield return null;

        if (task.IsFaulted)
            throw new InternalException(task.Exception);

        handlerResultSetter.SetResult(task.Result);
    }
}