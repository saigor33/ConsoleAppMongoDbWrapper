namespace ConsoleAppMongoDbWrapper;

partial class DbTable<T>
{
    public class SpecificTypedGetQueryHandler
        : BaseQuery<IGetQueryResult, SpecificTypedGetQueryHandler>.IHandlerResultSetter,
            IHandler
    {
        public bool hasResult => _result != null;
        public Result result => _result;

        Result _result;

        public void SetResult(IGetQueryResult result)
        {
            switch (result)
            {
                case SuccessGetQueryResult successGetQueryResult:
                    _result = new Result(successGetQueryResult.rows);
                    break;
                case ErrorGetQueryResult errorGetQueryResult:
                    throw new InternalException(errorGetQueryResult.exception);
                default:
                    throw new InternalException("Unhandled type");
            }
        }
    }
}