namespace ConsoleAppMongoDbWrapper;

public partial class DbTable<T>
{
    public class CommonTypedGetQueryBuilder
    {
        private readonly string _tableName;

        public CommonTypedGetQueryBuilder(string tableName)
        {
            _tableName = tableName;
        }

        public CommonTypedGetQuery Build()
        {
            return new CommonTypedGetQuery(_tableName);
        }
    }
}