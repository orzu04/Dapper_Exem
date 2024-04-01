namespace Infrastructure;
using Npgsql;
public class DapperContext
{
   private readonly string _connectionString =
        $"Server=localhost;port=5432;database=SCHOOL_DB;User Id=postgres;password=20082003";

    public NpgsqlConnection Connection()
    {
        return new NpgsqlConnection(_connectionString);
    }
}
