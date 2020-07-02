using IEIMobile.Models;
using IEIMobile.Models.Dtos;
using IEIMobile.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace IEIMobile.Controllers
{
    // [EnableCors("AllowOrigin")] 
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepo _employeeRepo;
        public EmployeesController(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpPost("api/Employees/GetEmployee")]
        [Authorize]
        public IActionResult GetEmployee([FromBody] PinDto pinDto)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Employee employee = _employeeRepo.GetEmployee(pinDto.Pin);
            return Ok(employee);
        }

        [HttpPost("api/Employees/GetContributionBalance")]
        [Authorize]
        public IActionResult GetContributionBalance([FromBody] PinDto pinDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Contribution contribution = _employeeRepo.GetContributionBalance(pinDto.Pin);
            return Ok(contribution);
        }

    }
}