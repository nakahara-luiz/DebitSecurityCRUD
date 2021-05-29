using System;

namespace DebitSecurity.Domain.Entities
{
    public class Installment: BaseEntity
    {
        private int _installmentNumber;
        public int InstallmentNumber
        {
            get { return _installmentNumber; }
            set { _installmentNumber = value; }
        }
        
        private long _value;
        public long Value
        {
            get { return _value; }
            set { _value = value; }
        }
        
        private DateTime _dueDate;
        public DateTime DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }
        
    }
}