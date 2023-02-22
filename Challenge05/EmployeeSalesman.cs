namespace Challenge05
{
    public class EmployeeSalesman : EmployeeStandard
    {
        public override int GetPaymentAmount(MontlyPayment payment)
        {
            return payment.MontlySalary + payment.Comission;
        }
    }
}