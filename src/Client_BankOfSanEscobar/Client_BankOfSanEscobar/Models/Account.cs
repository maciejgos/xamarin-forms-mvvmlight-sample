namespace Client_BankOfSanEscobar.Models
{
    public class Account
    {
        public Account(string name, string number, float balance)
        {
            this.Name = name;
            this.Number = number;
            this.Balance = balance;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public float Balance { get; set; }
        public string Number { get; set; }
    }
}
