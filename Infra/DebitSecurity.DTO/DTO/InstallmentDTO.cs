using System;

namespace DebitSecurity.DTO
{
    public class InstallmentDTO
    {
        public int Number { get; set; }
        public double Value { get; set; }
        public DateTime DueDate { get; set; }
        public Guid DebitSecurityId { get; set; }
        public Guid InstallmentId { get; set; }
    }
}