
using EncurtadorURLs.Models;

namespace EncurtadorURLs.Data;

/// <summary>
/// Contrato da camada de persistência.
/// </summary>
public interface IUrlContext
{
    Task<bool> ShortCodeExistsAsync(string shortCode);

    Task AddAsync(UrlItem item);

    Task<UrlItem?> GetByIdAsync(Guid id);
}
