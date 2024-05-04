#region

using EncyclopediaGalactica.BusinessLogic.Contracts;

#endregion

namespace UIWasm.Services;

public class DocumentService : IDocumentService
{
    private ICollection<DocumentResult> _storage = new List<DocumentResult>
    {
        new DocumentResult
        {
            Id = 1,
            Name = "Karman Todor Wikipedia page",
            Description = "Karman Todor Wikipedia page"
        },
        new DocumentResult
        {
            Id = 2,
            Name = "NeoVim Editor Wikipedia page",
            Description = "NeoVim Editor Wikipedia Page"
        },
        new DocumentResult
        {
            Id = 3,
            Name = "Jules Verne book from Gutenberg.org",
            Description = "Jules Verne book from Gutenberg.org"
        }
    };

    public async Task<ICollection<DocumentResult>> GetAllAsync()
    {
        return _storage;
    }

    public async Task<DocumentResult> GetById(long id, CancellationToken cancellationToken = default)
    {
        return new DocumentResult
        {
            Id = 1,
            Name = "Karman Todor Wikipedia page",
            Description = "Karman Todor Wikipedia page",
            StructureNodes = new List<StructureNodeResult>
            {
                new StructureNodeResult { Id = 1, DocumentId = 1, ParentId = 0 },
                new StructureNodeResult { Id = 2, DocumentId = 1, ParentId = 1 },
                new StructureNodeResult { Id = 3, DocumentId = 1, ParentId = 1 },
                new StructureNodeResult { Id = 4, DocumentId = 1, ParentId = 1 },
                new StructureNodeResult { Id = 5, DocumentId = 1, ParentId = 2 },
                new StructureNodeResult { Id = 6, DocumentId = 1, ParentId = 2 },
                new StructureNodeResult { Id = 7, DocumentId = 1, ParentId = 2 },
                new StructureNodeResult { Id = 8, DocumentId = 1, ParentId = 3 },
                new StructureNodeResult { Id = 9, DocumentId = 1, ParentId = 3 },
                new StructureNodeResult { Id = 10, DocumentId = 1, ParentId = 3 },
                new StructureNodeResult { Id = 11, DocumentId = 1, ParentId = 4 },
                new StructureNodeResult { Id = 12, DocumentId = 1, ParentId = 4 },
                new StructureNodeResult { Id = 13, DocumentId = 1, ParentId = 4 },
            }
        };
    }
}