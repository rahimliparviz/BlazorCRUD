#pragma checksum "C:\Users\Pronet\Desktop\ownProjects\EmployeeManagementBlazorApp\EmployeeManagement.Web\Pages\Department\DepartmentEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "957e1393f6b941f37f971642d90559ea5d508231"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages.Department
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Pronet\Desktop\ownProjects\EmployeeManagementBlazorApp\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pronet\Desktop\ownProjects\EmployeeManagementBlazorApp\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pronet\Desktop\ownProjects\EmployeeManagementBlazorApp\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pronet\Desktop\ownProjects\EmployeeManagementBlazorApp\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Pronet\Desktop\ownProjects\EmployeeManagementBlazorApp\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Pronet\Desktop\ownProjects\EmployeeManagementBlazorApp\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Pronet\Desktop\ownProjects\EmployeeManagementBlazorApp\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Pronet\Desktop\ownProjects\EmployeeManagementBlazorApp\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Pronet\Desktop\ownProjects\EmployeeManagementBlazorApp\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Pronet\Desktop\ownProjects\EmployeeManagementBlazorApp\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
    public partial class DepartmentEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\Users\Pronet\Desktop\ownProjects\EmployeeManagementBlazorApp\EmployeeManagement.Web\Pages\Department\DepartmentEdit.razor"
                 Department

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(3);
                __builder2.AddAttribute(4, "id", "name");
                __builder2.AddAttribute(5, "class", "form-control");
                __builder2.AddAttribute(6, "placeholder", "Name");
                __builder2.AddAttribute(7, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "C:\Users\Pronet\Desktop\ownProjects\EmployeeManagementBlazorApp\EmployeeManagement.Web\Pages\Department\DepartmentEdit.razor"
                            Department.DepartmentName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Department.DepartmentName = __value, Department.DepartmentName))));
                __builder2.AddAttribute(9, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Department.DepartmentName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.AddMarkupContent(11, "<button class=\"btn btn-primary\">Save</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591