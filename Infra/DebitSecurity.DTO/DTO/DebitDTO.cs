using System;
using System.Collections.Generic;

namespace DebitSecurity.DTO
{
    public class DebitDTO
    {
        public string SecurityNumber { get; set; }
        public double Interest { get; set; }
        public double Penalty { get; set; }
        public Guid PersonId { get; set; }
        public PersonDTO Person { get; set; }
        public IList<InstallmentDTO> Installments { get; set; }
        public Guid DebitId { get; set; }
    }
}