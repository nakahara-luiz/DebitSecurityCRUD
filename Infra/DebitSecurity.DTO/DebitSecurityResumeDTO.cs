namespace DebitSecurity.DTO
{
    public class DebitSecurityResumeDTO
    {
        public string DocumentNumber { get; set; }
        public string CustomerName { get; set; }
        public double NumberInstallments { get; set; }
        public double OriginalValue { get; set; }
        public double DaysOverDue { get; set; }
        public double ActualValue { get; set; }
    }
}