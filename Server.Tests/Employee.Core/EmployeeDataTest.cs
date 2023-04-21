using Api.Employee;
using Employee.Core.Implementation;
using Employee.Core.InterFaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Server.Tests.Employee.Core
{
    public class EmployeeDataTest
    {
        public readonly IEmployeeData employeeData;
        public EmployeeDataTest()
        {
            employeeData = new EmployeeData();
        }

        [Fact]
        public async Task GetEmpnames_OnvalidInput_ReturnListofEmployee()
        {
            var result= employeeData.GetEmpnames();
            Assert.NotNull(result);
        }
    }
}
