namespace Challenge05
{
    public class EmployeeManager : EmployeeStandard
    {
        public override int GetPaymentAmount(MontlyPayment payment)
        {
            return payment.MontlySalary + payment.Bonus;
        }
    }
}