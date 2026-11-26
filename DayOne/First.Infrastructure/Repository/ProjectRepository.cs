using Dapper;
using First.Application.Dtos;
using First.Application.Interface;
using First.Application.services;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;

namespace First.Infrastructure.Repository;

public class ProjectRepository : IProjectRepository
{
    private readonly SqlConnection _connection;
    private readonly IMemoryCache _cache;
    public ProjectRepository(SqlConnection connection,IMemoryCache cache)
    {
        _connection=connection;
        _cache=cache;
    }
    public async Task AddProject(Projects projects)
    {
        const string sql="INSERT INTO Project(Name,Tasks) VALUES(@Name,@Tasks)";

        var parameters=new DynamicParameters();
        parameters.Add("@Name",projects.Name);
        parameters.Add("@Tasks",projects.Tasks);

        await _connection.ExecuteAsync(sql,parameters);
    }

    public async Task<Projects?> GetProjectById(int id)
    {
         string cacheKey=$"project:{id}";

        if(_cache.TryGetValue(cacheKey,out Projects? cachedProjects))
        {
            Console.WriteLine($"Project found in cache : {cachedProjects?.Name}");
            return cachedProjects;
        }

        const string sql="SELECT *FROM Project WHERE Id=@Id";

        var project=await _connection.QueryFirstOrDefaultAsync<Projects>(sql,new {Id=id});

        if(project==null)
            return null;

        _cache.Set(cacheKey,
                project,
                new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow=TimeSpan.FromMinutes(10)
                });

        return project;


    }
    public async Task<IEnumerable<Projects>> GetAllProjects()
    {
        const string sql="SELECT *FROM Project";

        return await  _connection.QueryAsync<Projects>(sql);

    }

    public async Task UpdateProject(int id,UpdateProjectDto dto)
    {
        const string sql="UPDATE Project SET Name=@Name, Tasks=@Tasks WHERE Id=@Id";

        var parameters=new DynamicParameters();

        parameters.Add("@Name",dto.Name,dbType:System.Data.DbType.String);
        parameters.Add("@Tasks",dto.Tasks,dbType:System.Data.DbType.Int16);
        parameters.Add("@Id",id,dbType:System.Data.DbType.Int16);

        await _connection.ExecuteAsync(sql,parameters);

         _cache.Remove($"project:{id}");
    }
}