namespace ConsoleAppMongoDbWrapper;

partial class DbTable<T>
{
    public class CommonTypedGetQueryHandler
        : BaseQuery<IGetQueryResult, CommonTypedGetQueryHandler>.IHandlerResultSetter,
            IHandler
    {
        // todo: create typed i result
        // SuccessResult
        // ErrorResult
        
        public bool hasResult => _result != null;
        public IGetQueryResult result => _result;

        private IGetQueryResult _result;

        public void SetResult(IGetQueryResult result)
        {
            _result = result;
        }
    }
}