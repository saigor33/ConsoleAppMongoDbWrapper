namespace ConsoleAppMongoDbWrapper;

partial class DbTable<T>
{
    public class TypedCommonGetQueryHandler
        : BaseQuery<IGetQueryResult, TypedCommonGetQueryHandler>.IHandlerResultSetter,
            IHandler
    {
        public bool hasResult => _result != null;
        public IGetQueryResult result => _result;

        private IGetQueryResult _result;

        public void SetResult(IGetQueryResult result)
        {
            _result = result;
        }
    }
}