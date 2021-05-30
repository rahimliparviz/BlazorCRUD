﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Domain;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    
    public partial class EmployeeAddEdit
    {
        [Parameter]
        public string Id { get; set; }
        
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        [Inject]
        private NavigationManager NavigationManager { get; set; }

        private Employee Employee { get; set; } = new ();

        public IEnumerable<Domain.Department> Departments = new List<Domain.Department>();

        protected override async Task OnInitializedAsync()
        {
            int.TryParse(Id, out int employeeId);

            if (employeeId != 0)
            {
                Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            }
            else
            {
                Employee = new Employee
                {
                    DepartmentId = 1,
                    DateOfBrith = DateTime.Now,
                    PhotoPath = "images/nophoto.jpg"
                };
            }
            Departments = await DepartmentService.GetDepartments();

        }

        private async void HandleValidSubmit()
        {
            Employee result = null;

            if (Employee.EmployeeId != 0)
            {
                result = await EmployeeService.UpdateEmployee(Employee);
            }
            else
            {
                result = await EmployeeService.CreateEmployee(Employee);
            }
            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}