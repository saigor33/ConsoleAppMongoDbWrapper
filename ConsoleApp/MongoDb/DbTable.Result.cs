namespace ConsoleAppMongoDbWrapper;

public partial class DbTable<T>
{
    public class Result
    {
        public Dictionary<string, object> rows => _rows;

        private readonly Dictionary<string, object> _rows;

        public Result(List<Dictionary<string, object>> rows)
        {
            _rows = rows;
        }

        public void Iterate()
        {
        }
    }
}