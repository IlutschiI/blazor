#pragma checksum "C:\Users\lwickenhauser\blazor\blazor\BspJavaScriptLibraries\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15eb4c4c5999bc5f82e6a2b27326efeb8cbda7d2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BspJavaScriptLibraries.Pages
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
    using BspJavaScriptLibraries;
    using BspJavaScriptLibraries.Shared;
    using Microsoft.AspNetCore.Blazor.Browser.Interop;
    using System.Threading;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 11 "C:\Users\lwickenhauser\blazor\blazor\BspJavaScriptLibraries\Pages\Index.cshtml"
           
    private void DrawGraph()
    {
        RegisteredFunction.Invoke<Boolean>("drawGraph", "");
    }
   
       

#line default
#line hidden
    }
}
#pragma warning restore 1591