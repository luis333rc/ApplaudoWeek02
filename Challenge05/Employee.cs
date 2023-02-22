namespace Challenge05
{
    public class Employee
    {
        private int _type;

        static readonly int ENGINEER = 0;
        static readonly int SALESMAN = 1;
        static readonly int MANAGER = 2;

        public int MontlySalary { get; set; }
        public int Comission { get; set; }
        public int Bonus { get; set; }

        public Employee(int type)
        {
            _type = type;
        }

        public int GetPaymentAmount()
        {
            switch (_type)
            {
                case 0:
                    return MontlySalary;
                case 1:
                    return MontlySalary + Comission;
                case 2:
                    return MontlySalary + Bonus;
                default:
                    throw new SystemException("Incorrect Employee");
            }
        }
    }
}