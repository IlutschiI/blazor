#pragma checksum "C:\Users\wicki\source\repos\blazor\blazor\BspCallJavascript\Pages\CSharpCall.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c471b93de983eb89b2b816b5ecc0a207cbbdc3a"
// <auto-generated/>
#pragma warning disable 1591
namespace BspCallJavascript.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using BspCallJavascript;
    using BspCallJavascript.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/cSharp")]
    public class CSharpCall : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "button");
            builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>("callCSharp()"));
            builder.AddContent(2, "Click me!");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
