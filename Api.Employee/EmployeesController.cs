using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Employee.Core.InterFaces;
using System.Collections.Generic;

namespace Api.Employee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeData employeee;
        public EmployeesController(IEmployeeData employeee)
        {
            this.employeee = employeee;

        }

        [HttpGet]
        public List<string> GetEmployee()
        {
            var output=this.employeee.GetEmpnames();
            return output;
        }
    }
}
