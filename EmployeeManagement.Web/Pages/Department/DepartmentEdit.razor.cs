using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages.Department
{
    public partial class DepartmentEdit
    {
        [Parameter] 
        public Domain.Department Department { get; set; }


        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }
    }
}