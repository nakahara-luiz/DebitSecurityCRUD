namespace DebitSecurity.Domain.Entities
{
    public class Person: BaseEntity
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        private string _cpf;
        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
    }
}