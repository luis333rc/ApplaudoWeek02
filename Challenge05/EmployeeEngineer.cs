namespace Challenge05
{
    public class EmployeeEngineer : EmployeeStandard
    {
        public override int GetPaymentAmount(MontlyPayment payment)
        {
            return payment.MontlySalary;
        }
    }
}