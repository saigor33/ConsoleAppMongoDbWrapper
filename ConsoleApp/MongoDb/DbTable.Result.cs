namespace ConsoleAppMongoDbWrapper;

public partial class DbTable<T>
{
    public class Result
    {
        public List<Dictionary<string, object>> rows => _rows;

        private readonly List<Dictionary<string, object>> _rows;

        public Result(List<Dictionary<string, object>> rows)
        {
            _rows = rows;
        }

        public void Iterate()
        {
        }
    }
}