using UserManager.Models;

namespace UserManager.DbLib;

public class TableAccount : ITableAccount
{
    private readonly ITableAccount _table;

    public TableAccount(ITableAccount table)
    {
        _table = table;
    }
    
    public bool CheckLoginPassword(string login, string password)
    {
        return _table.CheckLoginPassword(login, password);
    }

    public bool Create(Account obj)
    {
        throw new NotImplementedException();
    }

    public bool Update(Account obj)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Account obj)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Account> FindAll()
    {
        throw new NotImplementedException();
    }

    public Account FindById(int id)
    {
        throw new NotImplementedException();
    }
}