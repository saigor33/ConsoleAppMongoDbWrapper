namespace ConsoleAppMongoDbWrapper;

public partial class DbTable<T>
{
    public class GetTypedCommonQuery : BaseGetQuery<TypedCommonGetQueryHandler>
    {
        public GetTypedCommonQuery(string tableName) : base(tableName)
        {
        }

        public override TypedCommonGetQueryHandler CreateHandler()
        {
            return new TypedCommonGetQueryHandler();
        }
    }
}