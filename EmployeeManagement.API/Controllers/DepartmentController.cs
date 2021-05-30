using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.API.Repositories;
using EmployeeManagement.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _repository;

        public DepartmentController(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetEmployees()
        {
            try
            {
                return (await _repository.GetDepartments()).ToList();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        // [HttpGet("{id:int}")]
        // public async Task<ActionResult<Employee>> GetEmployee(int id)
        // {
        //     try
        //     {
        //         var result = await _employeeRepository.GetEmployee(id);
        //
        //         if (result == null) return NotFound();
        //
        //         return result;
        //     }
        //     catch (Exception)
        //     {
        //         return StatusCode(StatusCodes.Status500InternalServerError,
        //             "Error retrieving data from the database");
        //     }
        // }
        //
        // [HttpPost]
        // public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        // {
        //     try
        //     {
        //         if (employee == null)
        //             return BadRequest();
        //
        //         var createdEmployee = await _employeeRepository.AddEmployee(employee);
        //
        //         return CreatedAtAction(nameof(GetEmployee),
        //             new { id = createdEmployee.EmployeeId }, createdEmployee);
        //     }
        //     catch (Exception)
        //     {
        //         return StatusCode(StatusCodes.Status500InternalServerError,
        //             "Error creating new employee record");
        //     }
        // }
        //
        // [HttpPut("{id:int}")]
        // public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee employee)
        // {
        //     try
        //     {
        //         if (id != employee.EmployeeId)
        //             return BadRequest("Employee ID mismatch");
        //
        //         var employeeToUpdate = await _employeeRepository.GetEmployee(id);
        //
        //         if (employeeToUpdate == null)
        //             return NotFound($"Employee with Id = {id} not found");
        //
        //         return await _employeeRepository.UpdateEmployee(employee);
        //     }
        //     catch (Exception)
        //     {
        //         return StatusCode(StatusCodes.Status500InternalServerError,
        //             "Error updating data");
        //     }
        // }
        //
        // [HttpDelete("{id:int}")]
        // public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        // {
        //     try
        //     {
        //         var employeeToDelete = await _employeeRepository.GetEmployee(id);
        //
        //         if (employeeToDelete == null)
        //         {
        //             return NotFound($"Employee with Id = {id} not found");
        //         }
        //
        //        return  await _employeeRepository.DeleteEmployee(id);
        //     }
        //     catch (Exception)
        //     {
        //         return StatusCode(StatusCodes.Status500InternalServerError,
        //             "Error deleting data");
        //     }
        // }
        //
        // [HttpGet("{search}")]
        // public async Task<ActionResult<IEnumerable<Employee>>> Search(string name, Gender? gender)
        // {
        //     try
        //     {
        //         var result = await _employeeRepository.Search(name, gender);
        //
        //         if (result.Any())
        //         {
        //             return Ok(result);
        //         }
        //
        //         return NotFound();
        //     }
        //     catch (Exception)
        //     {
        //         return StatusCode(StatusCodes.Status500InternalServerError,
        //             "Error retrieving data from the database");
        //     }
        // }
    }
}