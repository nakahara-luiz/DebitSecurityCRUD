using System;

namespace DebitSecurity.DTO
{
    public class DebitResumeDTO
    {
        public Guid DebitId { get; set; }
        public string SecurityNumber { get; set; }
        public string CustomerName { get; set; }
        public double NumberInstallments { get; set; }
        public double OriginalValue { get; set; }
        public double DaysOverDue { get; set; }
        public double ActualValue { get; set; }
    }
}