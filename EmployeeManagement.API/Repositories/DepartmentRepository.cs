using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.API.Data;
using EmployeeManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.API.Repositories
{
    public class DepartmentRepository:IDepartmentRepository
    {
        private readonly EmployeeManagementContext _context;

        public DepartmentRepository(EmployeeManagementContext context)
        {
            _context = context;
        }

        
        
        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _context.Departments.ToListAsync();
        }
    }
}