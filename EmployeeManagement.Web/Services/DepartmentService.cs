using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using EmployeeManagement.Domain;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Services
{
    public class DepartmentService:IDepartmentService
    {
        private readonly HttpClient _httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _httpClient.GetJsonAsync<Department[]>("api/department");

        }
    }
}