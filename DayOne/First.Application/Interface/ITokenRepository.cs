using First.Domain.Entities;

namespace First.Application.Interface;

public interface ITokenRepository
{
    public Task AddRefreshToken(RefreshToken token );
    public Task<RefreshToken?> GetRefreshTokenAsync(string hash);
    Task RevokeToken(string tokenHash, string? replacementToken);

    public Task DeleteToken(CancellationToken cancellationToken);


}