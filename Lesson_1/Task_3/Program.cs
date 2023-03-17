
List<int> numbers = new List<int> ();

while (numbers.Count < 10)
{
    Console.Write("Enter number: ");

    try {
        numbers.Add(Convert.ToInt32(Console.ReadLine()));
    }

    catch {
        Console.WriteLine("Incorrect value, try again!");
    }
}


while (true)
{
    Console.Write("Enter number for create dublicate:");

    try
    {
        int number = Convert.ToInt32(Console.ReadLine());

        var indexValue = numbers.IndexOf(number);

        if (indexValue != -1)
        {
            numbers.Insert(indexValue + 1, number);

            // Output list
            Console.Write("Your list: ");
            foreach (int i in numbers)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
        }

        else
        {
            Console.WriteLine("No such number is found in the list. Try again!");
        }
    }

    catch
    {
        Console.WriteLine("Incorect valuy, try again!");
    }

}





