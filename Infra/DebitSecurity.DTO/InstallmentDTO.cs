using System;

namespace DebitSecurity.DTO
{
    public class InstallmentDTO
    {
        public int InstallmentId { get; set; }
        public int InstallmentNumber { get; set; }
        public long Value { get; set; }
        public DateTime DueDate { get; set; }
        public int DebitID { get; set; }
    }
}