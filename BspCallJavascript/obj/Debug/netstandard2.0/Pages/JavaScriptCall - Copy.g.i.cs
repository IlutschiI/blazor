#pragma checksum "C:\Users\lwickenhauser\source\repos\BlazorTest\BspCallJavascript\Pages\JavaScriptCall - Copy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e7d9904faae9717af5a17a5d4ff109277eb7a51"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    using Microsoft.AspNetCore.Blazor.Browser.Interop;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/javaScript")]
    public class JavaScriptCall___Copy : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 7 "C:\Users\lwickenhauser\source\repos\BlazorTest\BspCallJavascript\Pages\JavaScriptCall - Copy.cshtml"
           
    private void CallJavaScript()
    {
        RegisteredFunction.Invoke<Boolean>("say", "hello World");

}

#line default
#line hidden
    }
}
#pragma warning restore 1591
