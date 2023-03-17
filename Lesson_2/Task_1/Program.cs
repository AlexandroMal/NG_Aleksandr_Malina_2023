
var products = new List<Products>()
{
    new Products("Milk", 100),
    new Products("Bacon", 75),
    new Products("Cherry", 50),
    new Products("Cheese", 150),
    new Products("Cake", 25),
    new Products("Chocolate", 60),
    new Products("Popcorn", 20),
    new Products("Coffee", 30),
    new Products("Ice cream", 35),
    new Products("Lemon", 10)
};

var orderAscending = products.OrderBy(p=>p.Price);
var orderDescending = products.OrderByDescending(p => p.Price);

Console.WriteLine("Ascending sort by price:");
foreach (var product1 in orderAscending)
{
    Console.WriteLine($"{product1.Name} - {product1.Price} UAH");
}

Console.WriteLine("\nDescending sort by price:");
foreach (var product1 in orderDescending)
{
    Console.WriteLine($"{product1.Name} - {product1.Price} UAH");
}

class Products
{
    public string Name { get;}
    public int Price { get;}
    public Products(string name, int price)
    {
        Name = name;
        Price = price;
    }
}

