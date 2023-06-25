using UserManager.Models;

namespace UserManager.DbLib;

public interface ITableAccount : ITable<Account>
{
    public bool CheckLoginPassword(string login, string password);
}