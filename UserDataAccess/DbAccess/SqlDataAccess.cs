using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace UserDataAccess.DbAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private IConfiguration _configuration;
    public SqlDataAccess(IConfiguration configuration)
    {
        this._configuration = configuration;
    }

    public async Task<IEnumerable<T>> LoadData<T, U>(string storeName, U parameters, string connectionId = "Default")
    {

        using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionId));

        var query = await connection.QueryAsync<T>(storeName, parameters, commandType: CommandType.StoredProcedure);

        return query.ToList();
    }

    public async Task SaveData<T>(string storeName, T parameters, string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionId));

        await connection.ExecuteAsync(storeName, parameters, commandType: CommandType.StoredProcedure);
    }
}