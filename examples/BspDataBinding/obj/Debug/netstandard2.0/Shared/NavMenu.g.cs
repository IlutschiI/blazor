#pragma checksum "C:\Users\wicki\source\repos\blazor\blazor\examples\BspDataBinding\Shared\NavMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1003808626422f31e052b4ba49f59187d613b95"
// <auto-generated/>
#pragma warning disable 1591
namespace BspDataBinding.Shared
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
    public class NavMenu : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            builder.AddContent(2, "\n    ");
            builder.OpenElement(3, "a");
            builder.AddAttribute(4, "class", "navbar-brand");
            builder.AddAttribute(5, "href", "/");
            builder.AddContent(6, "BspDataBinding");
            builder.CloseElement();
            builder.AddContent(7, "\n    ");
            builder.OpenElement(8, "button");
            builder.AddAttribute(9, "class", "navbar-toggler");
            builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(ToggleNavMenu));
            builder.AddContent(11, "\n        ");
            builder.OpenElement(12, "span");
            builder.AddAttribute(13, "class", "navbar-toggler-icon");
            builder.CloseElement();
            builder.AddContent(14, "\n    ");
            builder.CloseElement();
            builder.AddContent(15, "\n");
            builder.CloseElement();
            builder.AddContent(16, "\n\n");
            builder.OpenElement(17, "div");
            builder.AddAttribute(18, "class", collapseNavMenu ? "collapse" : null);
            builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(ToggleNavMenu));
            builder.AddContent(20, "\n    ");
            builder.OpenElement(21, "ul");
            builder.AddAttribute(22, "class", "nav flex-column");
            builder.AddContent(23, "\n        ");
            builder.OpenElement(24, "li");
            builder.AddAttribute(25, "class", "nav-item px-3");
            builder.AddContent(26, "\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(27);
            builder.AddAttribute(28, "class", "nav-link");
            builder.AddAttribute(29, "href", "/");
            builder.AddAttribute(30, "Match", NavLinkMatch.All);
            builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(32, "\n                ");
                builder2.OpenElement(33, "span");
                builder2.AddAttribute(34, "class", "oi oi-home");
                builder2.AddAttribute(35, "aria-hidden", "true");
                builder2.CloseElement();
                builder2.AddContent(36, " Home\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(37, "\n        ");
            builder.CloseElement();
            builder.AddContent(38, "\n        ");
            builder.OpenElement(39, "li");
            builder.AddAttribute(40, "class", "nav-item px-3");
            builder.AddContent(41, "\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(42);
            builder.AddAttribute(43, "class", "nav-link");
            builder.AddAttribute(44, "href", "/oneWayBinding");
            builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(46, "\n                ");
                builder2.OpenElement(47, "span");
                builder2.AddAttribute(48, "class", "oi oi-arrow-right");
                builder2.AddAttribute(49, "aria-hidden", "true");
                builder2.CloseElement();
                builder2.AddContent(50, " One Way binding\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(51, "\n        ");
            builder.CloseElement();
            builder.AddContent(52, "\n        ");
            builder.OpenElement(53, "li");
            builder.AddAttribute(54, "class", "nav-item px-3");
            builder.AddContent(55, "\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(56);
            builder.AddAttribute(57, "class", "nav-link");
            builder.AddAttribute(58, "href", "/twoWayBinding");
            builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(60, "\n                ");
                builder2.OpenElement(61, "span");
                builder2.AddAttribute(62, "class", "oi oi-loop");
                builder2.AddAttribute(63, "aria-hidden", "true");
                builder2.CloseElement();
                builder2.AddContent(64, " Two Way Binding\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(65, "\n        ");
            builder.CloseElement();
            builder.AddContent(66, "\n        ");
            builder.OpenElement(67, "li");
            builder.AddAttribute(68, "class", "nav-item px-3");
            builder.AddContent(69, "\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(70);
            builder.AddAttribute(71, "class", "nav-link");
            builder.AddAttribute(72, "href", "/ignoreDataBinding");
            builder.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(74, "\n                ");
                builder2.OpenElement(75, "span");
                builder2.AddAttribute(76, "class", "oi oi-loop");
                builder2.AddAttribute(77, "aria-hidden", "true");
                builder2.CloseElement();
                builder2.AddContent(78, " Manually Update\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(79, "\n        ");
            builder.CloseElement();
            builder.AddContent(80, "\n    ");
            builder.CloseElement();
            builder.AddContent(81, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 33 "C:\Users\wicki\source\repos\blazor\blazor\examples\BspDataBinding\Shared\NavMenu.cshtml"
            
    bool collapseNavMenu = true;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
