namespace ConsoleAppMongoDbWrapper;

public class TestCollection : DbTable<TestCollection>
{
    public TestCollection() : base("Test")
    {
    }
}