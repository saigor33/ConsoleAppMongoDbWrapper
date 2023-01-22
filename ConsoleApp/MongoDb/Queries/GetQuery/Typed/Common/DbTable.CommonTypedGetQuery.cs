namespace ConsoleAppMongoDbWrapper;

public partial class DbTable<T>
{
    public class CommonTypedGetQuery : BaseGetQuery<CommonTypedGetQueryHandler>
    {
        public CommonTypedGetQuery(string tableName) : base(tableName)
        {
        }

        public override CommonTypedGetQueryHandler CreateHandler()
        {
            return new CommonTypedGetQueryHandler();
        }
    }
}