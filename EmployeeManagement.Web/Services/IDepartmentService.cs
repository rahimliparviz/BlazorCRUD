using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Domain;

namespace EmployeeManagement.Web.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetDepartments();
    }
}