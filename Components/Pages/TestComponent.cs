using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Linq.Expressions;

namespace blazor_if_ignored.Components.Pages;

public class TestComponent : ComponentBase
{
    [CascadingParameter]
    protected ComponentBase Other { get; set; } = null!;

    [Parameter]
    public required int Value { get; set; }

    [Parameter]
    public EventCallback<int> ValueChanged { get; set; }

    [Parameter]
    public required Expression<Func<int>> ValueExpression { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        Console.WriteLine($"Test Component Rendered");
        builder.OpenElement(0, "div");
        builder.AddContent(1, ValueExpression.Compile()());
        builder.CloseElement();
    }
}
