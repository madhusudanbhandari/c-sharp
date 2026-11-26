using System.Text.Json;
using Dapper;
using First.Application.Interface;
using First.Domain.Entities;
using Microsoft.Data.SqlClient;
using StackExchange.Redis;

namespace First.Infrastructure.Repository;

public class JobRepository : IJobRepository
{
    private readonly SqlConnection _connection;
    private readonly IDatabase _redis;

    public JobRepository(SqlConnection sqlConnection,IConnectionMultiplexer redis)
    {
        _connection=sqlConnection;
        _redis=redis.GetDatabase();
    }

    public async Task AddJob(Job job)
    {
        const string sql="INSERT INTO Job(Name,Description,Tasks) VALUES(@Name,@Description,@Tasks)";

        var parameter=new DynamicParameters();

        parameter.Add("@Name",job.Name);
        parameter.Add("@Description",job.Description);
        parameter.Add("@Tasks",job.Tasks);

        await _connection.ExecuteAsync(sql,parameter);
    }

    public async Task<Job?> GetJobById(int id)
    {
        var cacheKey=$"job:{id}";

        var job=await _redis.StringGetAsync(cacheKey);

        if (job.HasValue)
        {
            return JsonSerializer.Deserialize<Job>(job.ToString());
        }

        const string sql="SELECT *FROM Job WHERE Id=@Id";

        var fetchedJob=await _connection.QueryFirstOrDefaultAsync<Job>(sql,new {id=id});

        if (fetchedJob != null)
        {
            var cachedJob=JsonSerializer.Serialize(fetchedJob);

            await _redis.StringSetAsync(cacheKey,cachedJob,TimeSpan.FromMinutes(10));

        }

        return fetchedJob;
    }
   

    public async Task<IEnumerable<Job>> GetAllJobs()
    {
        const string sql="SELECT *FROM Job";

        return await _connection.QueryAsync<Job>(sql);
    }
}