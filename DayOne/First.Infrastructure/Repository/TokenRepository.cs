using Dapper;
using First.Application.Interface;
using First.Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace First.Infrastructure.Repository;

public class TokenRepository : ITokenRepository
{
    private readonly SqlConnection _connection;
    public TokenRepository(SqlConnection connection)
    {
        _connection=connection;
    }

    public async Task AddRefreshToken(RefreshToken token)
    {
        const string sql="INSERT INTO RefreshToken(UserId,TokenHash,ExpiresAt,CreatedAt) VALUES(@UserId, @TokenHash,@ExpiresAt,@CreatedAt) ";

        await _connection.ExecuteAsync(sql,token);
    }

    public async Task<RefreshToken?> GetRefreshTokenAsync(string hash)
    {
        const string sql="SELECT *FROM RefreshToken WHERE TokenHash=@TokenHash";

        var parameters=new DynamicParameters();
        parameters.Add("@TokenHash",hash,dbType:System.Data.DbType.String);

        return await _connection.QuerySingleOrDefaultAsync<RefreshToken>(sql,parameters);
    }

    public async Task RevokeToken(string token,string? replacementToken)
    {
        const string sql="UPDATE RefreshToken SET ReplacementToken=@ReplacementToken, RevokedAt=@RevokedAt WHERE TokenHash=@TokenHash";

        var parameter=new DynamicParameters();
        parameter.Add("@TokenHash",token);
        parameter.Add("@ReplacementToken",replacementToken);
        parameter.Add("@RevokedAt",DateTime.UtcNow);

        await _connection.ExecuteAsync(sql,parameter);
    }

    public async Task DeleteToken(CancellationToken cancellationToken)
    {
        const string sql="DELETE FROM RefereshToken WHERE ExpiresAt<@CurrentTime";

        await _connection.OpenAsync(cancellationToken);

        await _connection.ExecuteAsync(new CommandDefinition(sql,
            new {CurrentTime=DateTime.UtcNow},
            cancellationToken:cancellationToken 
         
        ));
    }
}