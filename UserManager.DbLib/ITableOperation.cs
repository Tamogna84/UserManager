namespace UserManager.DbLib;

public interface ITableOperation<out T>
{
    public bool Change(string sql);
    public IEnumerable<T>? FindAll(string sql);
    public T? FindOne(string sql);
}