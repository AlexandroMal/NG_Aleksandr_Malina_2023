
List<Person> persons = new List<Person>()
{
    new Person("Aleksandr", 30),
    new Person("William", 20),
    new Person("Ethan", 91),
    new Person("Jacob", 79),
    new Person("Liam", 32),
    new Person("Aleksey", 22),
    new Person("Vladimir", 50),
    new Person("Denis", 44),
    new Person("Yegor", 21),
    new Person("Boris", 28)
};

foreach (var person in persons)
{
    Console.WriteLine($"{person.Name} - {person.Age}-years");
}


try
{
    Console.WriteLine("\nWrite the range of the person's desired age.");
    Console.Write("Age from... ");
    int ageFrom = Convert.ToInt32(Console.ReadLine());
    Console.Write("Age to... ");
    int ageTo = Convert.ToInt32(Console.ReadLine());
    
    var filteredPerson = persons.Where(person => person.Age >= ageFrom & person.Age <= ageTo);
        if (filteredPerson.Count() > 0)
        {
            Console.WriteLine("\nFound people in this range:");
            foreach (var person in filteredPerson)
            {
                Console.WriteLine($"{person.Name} - {person.Age}-years");
            }
        }
        else
        {
            Console.WriteLine("No people in this range were found");
        }
    
}
catch
{
        Console.WriteLine("Error. Try enter the number in the next time.");
}

class Person
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

}