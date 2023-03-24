
List<Owner> owners = new List<Owner>()
{
    new Owner(1,"Aleksandr", "Address #1"),
    new Owner(2,"William", "Address #2"),
    new Owner(3,"Ethan", "Address #3"),
    new Owner(4,"Jacob", "Address #4"),
    new Owner(5,"Liam", "Address #5"),
    new Owner(6,"Aleksey", "Address #6"),
    new Owner(7,"Vladimir", "Address #7"),
    new Owner(8,"Denis", "Address #8"),
    new Owner(9,"Yegor", "Address #9"),
    new Owner(10,"Boris", "Address #10")
};

List<Car> cars = new List<Car>()
{
    new Car("00456523", 1),
    new Car("00835600", 2),
    new Car("00879400", 3),
    new Car("00457600", 4),
    new Car("00456700", 5),
    new Car("00455400", 6),
    new Car("00452500", 7),
    new Car("00456900", 8),
    new Car("00446700", 9),
    new Car("00556500", 10),
};

foreach(var car in cars)
{
    Console.WriteLine($"Car number: {car.Number} | Ownerld ID: {car.Ownerld}");
};

Console.Write($"\nWrite car number: ");
string inputNumber = Console.ReadLine();

try
{   //get Id ownerld
    var findCarID = cars.First(x => x.Number.Equals(inputNumber)).Ownerld;
    try
    {
        var findOwnerld = from owner in owners 
                          where owner.Id == findCarID 
                          select owner;

        foreach(var owner in findOwnerld)
        {
            Console.WriteLine($"\nCar number: {inputNumber} | Name ownerld: {owner.Name} | Address ownerld: {owner.Address}");
        }
    }
    catch
    {
        Console.WriteLine("Don't find ownerld for car with this number.");
    }
}
catch
{
    Console.Write("Don't find this car number.");
}


class Owner
{
    public int Id { get; }
    public string Name { get; }
    public string Address { get; }

    public Owner(int id, string name, string address)
    {
        Id = id;
        Name = name;
        Address = address;
    }
}

class Car
{
    public string Number { get; }
    public int Ownerld { get; }

    public Car(string number, int ownerld) 
    {
        Number = number;
        Ownerld = ownerld;
    }
}