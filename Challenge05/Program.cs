namespace Challenge05
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var emp = new Employee(2);
            emp.MontlySalary = 1000;
            emp.Comission = 200;
            emp.Bonus = 500;

            Console.WriteLine("Manager: " + emp.GetPaymentAmount() );

            Console.WriteLine("-------------------------------------------");

            var payments = new MontlyPayment{ MontlySalary = 1000, Bonus = 500, Comission = 200 };


            var empEngineer = new EmployeeEngineer();
            Console.WriteLine("Engineer: " + empEngineer.GetPaymentAmount(payments) );

            var empSalesman = new EmployeeSalesman();
            Console.WriteLine("Salesman: " + empSalesman.GetPaymentAmount(payments));

            var empManager = new EmployeeManager();
            Console.WriteLine("Manager: " + empManager.GetPaymentAmount(payments));
        }
    }
}