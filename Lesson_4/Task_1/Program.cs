namespace SingleResponsibility
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public Customer(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }

        public class CustomerList
        {
            public List<Customer> CustomersList = new List<Customer>()
            {
                new Customer(1, "Fikus", 0),
                new Customer(2, "VHarbar", 100000)
            };

            public Customer GetById(int id)
            {
                return CustomersList.FirstOrDefault(x => x.Id == id);
            }
        }

        public class BalanceInformation
        {
            private CustomerList _customer = new CustomerList();

            public void GetBalance(int id)
            {
                Console.WriteLine($"Your balance is: {GetBalanceById(id)}");
            }
            public decimal GetBalanceById(int id)
            {
                var customer = _customer.GetById(id);
                return customer.Balance;
            }

        }

        public class CustomerRepository
        {
            private CustomerList _customer = new CustomerList();

            public void UpdateBalance(int id, decimal newBalance)
            {
                var customer = _customer.GetById(id);
                customer.Balance = newBalance;
                SaveToDatabase();
            }

            public void SaveToDatabase()
            {
                Console.WriteLine("Saved!");
            }

        }
    }
}


        
        
        
    

