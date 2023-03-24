

List<Customer> customers = new List<Customer>()
{
    new Customer("Yegor", 15, "Address #1"),
    new Customer("William", 20, "Address #2"),
    new Customer("Ethan", 91, "Address #3"),
    new Customer("Boris", 17, "Address #4"),
    new Customer("Liam", 32, "Address #5"),
    new Customer("Aleksey", 22, "Address #6"),
    new Customer("Yegor", 50, "Address #7"),
    new Customer("Denis", 44, "Address #8"),
    new Customer("Yegor", 21, "Address #9"),
    new Customer("Boris", 28, "Address #10")
};

foreach (var customer in customers)
{
    Console.WriteLine($"{customer.Name}, {customer.Age}-years, {customer.Address}");
}

Console.Write("Enter name for search: ");
string inputName = Console.ReadLine();

if (inputName.Count() > 0)
{
    var filteredCustomer = customers.Where(customer => customer.Name == inputName);
   
    if (filteredCustomer.Count() >= 1)
    {
        Console.WriteLine($"\nCustomers with this name:");
        foreach (var customer in filteredCustomer)
        {
            Console.WriteLine($"{customer.Name}, {customer.Age}-years, {customer.Address}");
        }

        var filterAge = filteredCustomer.Where(customer => customer.Age > 18);
        Console.WriteLine($"\nCustomers over 18 years old: {filterAge.Count()}");
      
    }
    else
    {
        Console.WriteLine($"No clients with this name were found.");
    }
}
else
{
    Console.WriteLine("You didn't write anything.");
}
class Customer 
{
    public string Name { get;}
    public int Age { get; }
    public string Address { get; }

    public Customer(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }
}
