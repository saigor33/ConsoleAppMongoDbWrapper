namespace ConsoleAppMongoDbWrapper;

partial class DbTable<T>
{
    public class SpecificTypedGetQueryBuilder
    {
        private readonly string _tableName;

        public SpecificTypedGetQueryBuilder(string tableName)
        {
            _tableName = tableName;
        }

        public SpecificTypedGetQuery Build()
        {
            return new SpecificTypedGetQuery(_tableName);
        }
    }
}