#pragma checksum "C:\Users\wicki\source\repos\blazor\blazor\examples\BspDataBinding\Pages\IgnoreDataBinding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6382bba499cc9edb5233a865816f06392348116"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BspDataBinding.Pages
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
    using BspDataBinding;
    using BspDataBinding.Shared;
    using System.Threading;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/ignoreDataBinding")]
    public class IgnoreDataBinding : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 9 "C:\Users\wicki\source\repos\blazor\blazor\examples\BspDataBinding\Pages\IgnoreDataBinding.cshtml"
           
    private int Counter = 10;

    private void CountDown()
    {
        var timer = new Timer(new TimerCallback(_ =>
        {
            if (Counter > 0)
            {
                Counter--;
                //this.StateHasChanged();
            }
        }), null, 1000, 1000);
       
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591