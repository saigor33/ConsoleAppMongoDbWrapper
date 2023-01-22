namespace ConsoleAppMongoDbWrapper;

public partial class DbTable<T>
{
    public class GetTypedQueryBuilder
    {
        private readonly string _tableName;

        public GetTypedQueryBuilder(string tableName)
        {
            _tableName = tableName;
        }

        public GetTypedCommonQuery Build()
        {
            return new GetTypedCommonQuery(_tableName);
        }
    }
}