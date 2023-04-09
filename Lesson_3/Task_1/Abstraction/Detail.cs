namespace Task_1.Abstraction;

public abstract class Detail
{
    public int? Price { get; set; }
    public string? Supplier { get; set; }
    public string? Country { get; set; }
    public string? Name { get; set; }

    public Detail(int price, string supplier, string country, string name)
    {
        Price = price;
        Supplier = supplier;
        Country = country;
        Name = name;
    }

 
}



