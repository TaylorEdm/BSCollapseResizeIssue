#pragma checksum "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\Pages\PizzaWorld.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "358dea8b5f332c23613fd86f9466572c3562a9e2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\Pages\PizzaWorld.razor"
using BlazorApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\Pages\PizzaWorld.razor"
using BlazorApp.GroupByMany;

#line default
#line hidden
#nullable disable
    public partial class PizzaWorld : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenComponent<BlazorApp.Components.RecursiveGroupContainer<PizzaViewModel>>(1);
            __builder.AddAttribute(2, "Group", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp.GroupByMany.IGroupByManyResult<PizzaViewModel>>(
#nullable restore
#line 5 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\Pages\PizzaWorld.razor"
                                                           Pizza.GroupedPizzas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "GroupTemplate", (Microsoft.AspNetCore.Components.RenderFragment<BlazorApp.GroupByMany.IGroupByManyResult<PizzaViewModel>>)((context) => (__builder2) => {
                __builder2.OpenComponent<BlazorApp.Components.StandardGroupTemplate>(4);
                __builder2.AddAttribute(5, "HeaderTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 9 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\Pages\PizzaWorld.razor"
                     if (context.GroupName == nameof(PizzaViewModel.AccountNumber))
                    {
                        

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(6, 
#nullable restore
#line 11 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\Pages\PizzaWorld.razor"
                          $"Pizza Account:  {context.Item}"

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 11 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\Pages\PizzaWorld.razor"
                                                            ;
                    }
                    else if (context.GroupName == nameof(PizzaViewModel.RecipeYear))
                    {
                        

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(7, 
#nullable restore
#line 15 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\Pages\PizzaWorld.razor"
                          $"Recipe Year:  {context.Item}"

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 15 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\Pages\PizzaWorld.razor"
                                                          ;
                    }
                    else if (context.GroupName == nameof(PizzaViewModel.Size))
                    {
                        

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(8, 
#nullable restore
#line 19 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\Pages\PizzaWorld.razor"
                          $"Pizza Size:  {context.Item}"

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 19 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\Pages\PizzaWorld.razor"
                                                         ;
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(9, 
#nullable restore
#line 23 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\Pages\PizzaWorld.razor"
                          $"Cost:  {context.Item}"

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 23 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\Pages\PizzaWorld.razor"
                                                   ;
                    }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.AddAttribute(10, "Badges", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                }
                ));
                __builder2.AddAttribute(11, "MainContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                }
                ));
                __builder2.AddAttribute(12, "ActionTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                }
                ));
                __builder2.AddAttribute(13, "SummaryTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(14, "DetailTemplate", (Microsoft.AspNetCore.Components.RenderFragment<System.Collections.Generic.IEnumerable<PizzaViewModel>>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "<div>Details Section</div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\dnuno\Desktop\BlazorApp\BlazorApp\Pages\PizzaWorld.razor"
       
    [CascadingParameter(Name = "PizzaWorld")]
    private PizzaWorldViewModel Pizza { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
