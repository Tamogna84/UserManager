using Dapper;
using Microsoft.Data.Sqlite;

namespace UserManager.DbLib;

public class TableOperationSqLite<T> : ITableOperation<T>
{
    private readonly SqliteConnection _db;

    public TableOperationSqLite(string connectionString)
    {
        _db = new SqliteConnection(connectionString);
    }

    public bool Change(string sql)
    {
        _db.Open();

        var command = new SqliteCommand(sql, _db);
        var result = command.ExecuteNonQuery();
        
        _db.Close();

        return result > 0;
    }

    public IEnumerable<T>? FindAll(string sql)
    {
        _db.Open();

        var result = _db.Query<T>(sql);
        
        _db.Close();

        return result;
    }

    public T? FindOne(string sql)
    {
        _db.Open();

        var result = _db.QuerySingleOrDefault<T>(sql);
        
        _db.Close();

        return result;
    }
}