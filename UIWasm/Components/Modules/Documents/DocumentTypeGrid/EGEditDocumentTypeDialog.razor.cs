using EncyclopediaGalactica.BusinessLogic.Contracts;
using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using UIWasm.Components.Modules.Documents.Application;

namespace UIWasm.Components.Modules.Documents.DocumentTypeGrid;

public partial class EGEditDocumentTypeDialog
{
    [Inject]
    public ILogger<EGAddApplicationDialog> Logger { get; set; }

    [CascadingParameter]
    public FluentDialog? DialogService { get; set; }

    [Parameter]
    public DocumentTypeResult Content { get; set; }
}