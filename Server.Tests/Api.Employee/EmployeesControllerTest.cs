using Api.Employee;
using Employee.Core.InterFaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Server.Tests.Api.Employee
{
    public class EmployeesControllerTest
    {
        private readonly EmployeesController employeesController;
        private  Mock<IEmployeeData> mockEmployeeData;
        public EmployeesControllerTest()
        {
            mockEmployeeData = new Mock<IEmployeeData>();
            employeesController = new EmployeesController(mockEmployeeData.Object);
        }

        [Fact]
        public async Task GetEmployeeDataOnInValidInputReturnNull()
        {

            var result = employeesController.GetEmployee();
            Assert.Null(result);
        }

        [Fact]
        public async Task GetEmployeeDataOnValidInput()
        {
            mockEmployeeData.Setup(x => x.GetEmpnames()).Returns(GetEmpnamesMockData());
             var result =  employeesController.GetEmployee();
            Assert.NotNull(result);
        }

        private static List<string> GetEmpnamesMockData()
        {
            List<string> list = new List<string>();
            list.Add("ankita");
            list.Add("demo");
            return list;
        }
    }
}
