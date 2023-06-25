namespace UserManager.DbLib;

public interface ITable<T>
{
    public bool Create(T obj);
    public bool Update(T obj);
    public bool Delete(T obj);
    public IEnumerable<T> FindAll();
    public T FindById(int id);
}