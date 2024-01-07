using System.Data;
using System.Data.SqlClient;

namespace CrudDapper.Data
{
    public class SqlServerStrategy : IDbStrategy
    {
        public IDbConnection GetConnection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }
    }
}
