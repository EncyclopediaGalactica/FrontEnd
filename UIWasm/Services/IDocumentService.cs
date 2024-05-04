#region

using EncyclopediaGalactica.BusinessLogic.Contracts;

#endregion

namespace UIWasm.Services;

public interface IDocumentService
{
    Task<ICollection<DocumentResult>> GetAllAsync();

    Task<DocumentResult> GetById(long id, CancellationToken cancellationToken = default);
}