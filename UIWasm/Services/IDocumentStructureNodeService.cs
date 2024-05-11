#region

using EncyclopediaGalactica.BusinessLogic.Contracts;

#endregion

namespace UIWasm.Services;

public interface IDocumentStructureNodeService
{
    ICollection<DocumentStructureNodeResult> GetChildrenOfANode(
        long nodeId,
        CancellationToken cancellationToken = default);
}