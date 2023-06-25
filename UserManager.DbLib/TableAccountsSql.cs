using UserManager.Models;

namespace UserManager.DbLib;

public class TableAccountsSql : ITableAccount
{
    private readonly TableOperation<Account> _tableOperation;

    public TableAccountsSql(ITableOperation<Account> source)
    {
        _tableOperation = new TableOperation<Account>(source);
    }

    public bool CheckLoginPassword(string login, string password)
    {
        var sql = $"SELECT id, login, password, is_active FROM table_accounts WHERE login = '{login}' AND password = '{password}'";
        var result = _tableOperation.FindOne(sql);
        return result is not null;
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