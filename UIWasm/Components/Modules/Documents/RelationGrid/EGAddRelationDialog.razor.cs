#region

using EncyclopediaGalactica.BusinessLogic.Contracts;
using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;

#endregion

namespace UIWasm.Components.Modules.Documents.RelationGrid;

public partial class EGAddRelationDialog
{
    [CascadingParameter]
    public FluentDialog? FluentDialog { get; set; }

    [Parameter]
    public RelationResult Content { get; set; }
}