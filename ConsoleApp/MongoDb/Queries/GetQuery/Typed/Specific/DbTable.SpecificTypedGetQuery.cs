namespace ConsoleAppMongoDbWrapper;

partial class DbTable<T>
{
    public class SpecificTypedGetQuery : BaseGetQuery<SpecificTypedGetQueryHandler>
    {
        public SpecificTypedGetQuery(string tableName) : base(tableName)
        {
        }

        public override SpecificTypedGetQueryHandler CreateHandler()
        {
            return new SpecificTypedGetQueryHandler();
        }
    }
}