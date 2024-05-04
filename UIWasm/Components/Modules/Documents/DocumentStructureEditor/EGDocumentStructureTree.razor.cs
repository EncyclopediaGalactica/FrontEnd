#region

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

#endregion

namespace UIWasm.Components.Modules.Documents.DocumentStructureEditor;

public partial class EGDocumentStructureTree
{
    [Inject]
    private ILogger<EGDocumentStructureEditor> Logger { get; set; }

    [Parameter]
    public StructureNode? StructureNode { get; set; }

    private async Task HandleAddStructureNodeAsync(MouseEventArgs mouseEventArgs, long structureNodeId)
    {
        Logger.LogInformation("HandleAddStructureNodeAsync");
    }

    private async Task HandleDeleteStructureNodeAsync(MouseEventArgs mouseEventArgs, long structureNodeId)
    {
        Logger.LogInformation("HandleDeleteStructureNodeAsync");
    }
}