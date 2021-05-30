using System.Threading.Tasks;
using EmployeeManagement.Domain;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public partial class EmployeeDetails
    {
        private Employee Employee { get; set; } = new Employee();


        [Inject]
        private IEmployeeService EmployeeService { get; set; }

        [Parameter]
        public string Id { get; set; }
        

        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }

     
    }
}