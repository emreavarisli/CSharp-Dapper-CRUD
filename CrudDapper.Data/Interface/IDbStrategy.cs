using System.Data;

namespace CrudDapper.Data
{
    public interface IDbStrategy
    {
        IDbConnection GetConnection(string connectionString);
    }
}
