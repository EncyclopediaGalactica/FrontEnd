using EncyclopediaGalactica.BusinessLogic.Contracts;

namespace UIWasm.Services;

public interface IDocumentStructureService
{
    Task<ICollection<DocumentStructureResult>> GetAllAsync();
}