using Fullstack.Api.Data;
using Fullstack.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fullstack.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private FullstackDbContext _fullstackDbContext;

        public EmployeesController(FullstackDbContext fullstackDbContext)
        {
            _fullstackDbContext = fullstackDbContext;

        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _fullstackDbContext.Employees.ToListAsync();

            return Ok(employees);
        }
        [HttpPost]
        public async Task<IActionResult> Addemployee([FromBody] Employee employeeRequest)
        {
            employeeRequest.Id = Guid.NewGuid();
            await _fullstackDbContext.Employees.AddAsync(employeeRequest);
            await _fullstackDbContext.SaveChangesAsync();
            return Ok(employeeRequest);
        }
        //[HttpGet]
        //[Route("{id : Guid}")]
        //public async Task<IActionResult> GetEmployee([FromRoute] Guid id)
        //{
        //    var employee = await _fullstackDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
        //    if(employee == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(employee);
        //}
        [HttpGet]
        [Route("{id:Guid}")]

        public async Task<IActionResult> GetEmployee([FromRoute] Guid id)
        {
            var employee = await _fullstackDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
         

            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpPut]
        [Route("{id:Guid}")]

        public async Task<IActionResult> UpdateEmployee([FromRoute] Guid id, Employee UpdateEmployeeRequest)
        {
            var employee = await _fullstackDbContext.Employees.FindAsync(id);

            if(employee == null)
            {
                return NotFound();
            }
            employee.Name  = UpdateEmployeeRequest.Name;
            employee.Email = UpdateEmployeeRequest.Email;
            employee.Phone = UpdateEmployeeRequest.Phone;
            employee.Salary = UpdateEmployeeRequest.Salary;
            employee.Department = UpdateEmployeeRequest.Department;

            await  _fullstackDbContext.SaveChangesAsync();
            return Ok(employee);

        }
        [HttpDelete]
        [Route("{id:Guid}")]
        public  async Task<IActionResult> DeleteEmployee([FromRoute] Guid id)
        {
            var employee = await _fullstackDbContext.Employees.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }
            _fullstackDbContext.Employees.Remove(employee);
            await _fullstackDbContext.SaveChangesAsync();
            return Ok(employee);

        }


    }
}
