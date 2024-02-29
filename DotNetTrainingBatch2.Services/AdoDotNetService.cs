using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace DotNetTrainingBatch2.Services
{
    public class AdoDotNetService
    {
        private readonly SqlConnectionStringBuilder _connectionStringBuilder;

        public AdoDotNetService(SqlConnectionStringBuilder connectionStringBuilder)
        {
            _connectionStringBuilder = connectionStringBuilder;
        }

        // adoDotNetService.Query("select * from tbl_blog where BlogId = @BlogId", new SqlParameter(@pageNo", pageNo), new SqlParameter(@pageNo", pageNo) )
        public DataTable Query(string query, CommandType commandType = CommandType.Text, params SqlParameter[] sqlParameters)
        {
            SqlConnection connection = new SqlConnection(_connectionStringBuilder.ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = commandType;
            command.Parameters.AddRange(sqlParameters);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            connection.Close();
            return dt;
        }

        public List<T> Query<T>(string query, CommandType commandType = CommandType.Text, params SqlParameter[] sqlParameters)
        {
            SqlConnection connection = new SqlConnection(_connectionStringBuilder.ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = commandType;
            command.Parameters.AddRange(sqlParameters);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            connection.Close();

            var jsonStr = JsonConvert.SerializeObject(dt);
            return JsonConvert.DeserializeObject<List<T>>(jsonStr)!;
        }

        public int Execute(string query, CommandType commandType = CommandType.Text, params SqlParameter[] sqlParameters)
        {
            SqlConnection connection = new SqlConnection(_connectionStringBuilder.ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddRange(sqlParameters);
            int result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }
    }
}
