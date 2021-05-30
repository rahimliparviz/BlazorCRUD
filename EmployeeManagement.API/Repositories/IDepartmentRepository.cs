using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Domain;

namespace EmployeeManagement.API.Repositories
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
    }
}