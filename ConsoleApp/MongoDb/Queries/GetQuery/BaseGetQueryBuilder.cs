namespace ConsoleAppMongoDbWrapper;

public abstract class BaseGetQueryBuilder
<
    TGetQuery,
    TGetQueryBuilder,
    TGetQueryHandler
>
    where TGetQuery : BaseGetQuery<TGetQueryHandler>
    where TGetQueryBuilder : BaseGetQueryBuilder<TGetQuery, TGetQueryBuilder, TGetQueryHandler>
    where TGetQueryHandler : IHandler
{
    protected BaseGetQueryBuilder()
    {
    }

    public TGetQueryBuilder Where()
    {
        return this;
    }

    public abstract TGetQuery Build();
}