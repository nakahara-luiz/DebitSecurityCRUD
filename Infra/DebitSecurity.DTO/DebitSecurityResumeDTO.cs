namespace DebitSecurity.DTO
{
    public class DebitSecurityResumeDTO
    {
        public string DocumentNumber { get; set; }
        public string CustomerName { get; set; }
        public int NumberInstallments { get; set; }
        public int OriginalValue { get; set; }
        public int DaysOverDue { get; set; }
        public int ActualValue { get; set; }
    }
}