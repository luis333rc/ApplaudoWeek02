using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge05.UnitTests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Create_EmployeeEngineer_ShouldReturnMontlySalary()
        {
            var engineer = 0;
            var montlySalary = 1000;
            var comission = 200;
            var bonus = 500;

            var expected = montlySalary;

            var employee = new Employee(engineer);
            employee.MontlySalary = montlySalary;
            employee.Comission = comission;
            employee.Bonus = bonus;

            Assert.AreEqual(expected, employee.GetPaymentAmount());
        }

        [TestMethod]
        public void Create_EmployeeSalesman_ShouldReturnMontlySalaryPlusComission()
        {
            var salesMan = 1;
            var montlySalary = 1000;
            var comission = 200;
            var bonus = 500;

            var expected = montlySalary + comission;

            var employee = new Employee(salesMan);
            employee.MontlySalary = montlySalary;
            employee.Comission = comission;
            employee.Bonus = bonus;

            Assert.AreEqual(expected, employee.GetPaymentAmount());
        }

        [TestMethod]
        public void Create_EmployeeManager_ShouldReturnMontlySalaryPlusBonus()
        {
            var manager = 2;
            var montlySalary = 1000;
            var comission = 200;
            var bonus = 500;

            var expected = montlySalary + bonus;

            var employee = new Employee(manager);
            employee.MontlySalary = montlySalary;
            employee.Comission = comission;
            employee.Bonus = bonus;

            Assert.AreEqual(expected, employee.GetPaymentAmount());
        }

        [TestMethod]
        [ExpectedException(typeof(SystemException))]
        public void Create_EmployeeUnknown_ThrowsAnException()
        {
            var unknown = 4;

            var employee = new Employee(unknown);
            employee.GetPaymentAmount();
        }
    }
}