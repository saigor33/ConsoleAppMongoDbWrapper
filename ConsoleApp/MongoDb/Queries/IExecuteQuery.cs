using System.Collections;

namespace ConsoleAppMongoDbWrapper;

public interface IExecuteQuery
{
    public IEnumerator Execute(IMongoSession mongoSession, IMongoDatabase mongoDatabase, IHandler handler);
}