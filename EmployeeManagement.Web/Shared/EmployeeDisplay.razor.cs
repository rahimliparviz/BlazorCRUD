using System;
using System.Threading.Tasks;
using EmployeeManagement.Domain;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Shared
{
    public partial class EmployeeDisplay
    {
        [Parameter] 
        public Employee Employee { get; set; }
        
        [Parameter]
        public EventCallback<int> OnEmployeeDeleted { get; set; }
        
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public Confirm DeleteConfirmation { get; set; }
        
        public async void Delete_Click()
        {
            DeleteConfirmation.Show();
        //     await EmployeeService.DeleteEmployee(Employee.EmployeeId);
        //     await OnEmployeeDeleted.InvokeAsync(Employee.EmployeeId);
        }
        protected async Task ConfirmDelete_Click(bool deleteConfirmed)
        {
            if(deleteConfirmed)
            {
                await EmployeeService.DeleteEmployee(Employee.EmployeeId);
                await OnEmployeeDeleted.InvokeAsync(Employee.EmployeeId);
            }
        }

    }
}