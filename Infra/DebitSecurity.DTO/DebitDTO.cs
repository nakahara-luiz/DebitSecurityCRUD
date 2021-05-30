using System.Collections.Generic;

namespace DebitSecurity.DTO
{
    public class DebitDTO
    {
        public int DebitId { get; set; }
        public long Penalty { get; set; }
        public long Interest { get; set; }
        public IList<InstallmentDTO> Installments { get; set; }
    }
}