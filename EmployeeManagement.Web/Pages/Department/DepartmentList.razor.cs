using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages.Department
{
    public partial class DepartmentList
    {
        [Inject] 
        private IDepartmentService _service { get; set; }

        private IEnumerable<Domain.Department> _departments = new List<Domain.Department>();


        protected override async Task OnInitializedAsync()
        {
            _departments = await _service.GetDepartments();
        }
    }
}