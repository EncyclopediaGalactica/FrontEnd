#region

using EncyclopediaGalactica.BusinessLogic.Contracts;

#endregion

namespace UIWasm.Services;

public interface IDocumentStructureService
{
    Task<ICollection<DocumentStructureResult>> GetAllAsync();
}