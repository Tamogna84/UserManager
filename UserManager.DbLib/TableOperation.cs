namespace UserManager.DbLib;

public class TableOperation<T> : ITableOperation<T>
{
    private readonly ITableOperation<T> _table;

    public TableOperation(ITableOperation<T> table)
    {
        _table = table;
    }

    public bool Change(string sql)
    {
        return _table.Change(sql);
    }

    public IEnumerable<T>? FindAll(string sql)
    {
        return _table.FindAll(sql);
    }

    public T? FindOne(string sql)
    {
        return _table.FindOne(sql);
    }
}