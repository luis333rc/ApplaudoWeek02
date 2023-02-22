namespace Challenge05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var emp = new Employee(1);
            emp.MontlySalary = 1000;
            emp.Comission = 200;
            emp.Bonus = 500;

            Console.WriteLine( emp.GetPaymentAmount() );
        }
    }
}