using Task_1.Classes.Components;

namespace Task_1.Classes.Computer;

public class Computer
{
    public Motherboard? Motherboard { get; set; }
    public CPU? CPU { get; set; }
    public GPU? GPU { get; set; }
    public List<RAM>? RAMList { get; set; } = new List<RAM>();
    public List <Drive>? DriveList { get; set; } = new List<Drive>();

    private int ramSlots = 4;
    private string SocketType;

    public Computer() { }

    //main method
    public void Main(Computer myComputer)
    {

        DisplayInfoAndChoiceAction(myComputer);

    }

    // method for display information
    // user choice of action
    public void DisplayInfoAndChoiceAction(Computer myComputer)
    {
        Console.WriteLine
            (
            $"\nYou can do:\n" +
            $"Enter [1] for add Motherboard\n" +
            $"Enter [2] for add CPU\n" +
            $"Enter [3] for add GPU\n" +
            $"Enter [4] for add RAM\n" +
            $"Enter [5] for add Drive\n" +
            $"Enter [6] for display PC devices\n" +
            $"Enter [7] for exit\n"
            );

        string inputNumber = InputString();

        switch (inputNumber)
        {
            case "1":
                AddMotherboard(myComputer);
                break;
            case "2":
                AddCPU(myComputer);
                break;
            case "3":
                AddGPU(myComputer);
                break;
            case "4":
                AddRAM(myComputer);
                break;
            case "5":
                AddDrive(myComputer);
                break;
            case "6":
                DisplayInfoDevice(myComputer);
                break;
            case "7":
                return;
            default:
                Console.WriteLine("Error! Write correct number");
                break;

        }

    }

    // method for display properties device
    public void AddRAM(Computer myComputer)
    {

        (string Name, string Supplier, string Country, int Price) = InputBaseProperties();

        Console.Write("Type: ");
        string type = InputString();
        Console.Write("Size: ");
        string size = InputString();
        Console.Write("Speed: ");
        string speed = InputString();
        Console.Write("interfaceType: ");
        string interfaceType = InputString();
        Console.Write("interfaceType: ");
        string lifetime = InputString();

        DriveList.Add(new Drive(Price, Supplier, Country, Name) {Type = type, Size = size, Speed = speed, InterfaceType = interfaceType, Lifetime = lifetime});
        
        Main(myComputer);
    }

    // adding Drive properties using the InputBaseProperties method to add base values
    public void AddDrive(Computer myComputer)
    {
        if (DriveList.Count < ramSlots)
        {
            (string Name, string Supplier, string Country, int Price) = InputBaseProperties();

            Console.Write("Type: ");
            string type = InputString();
            Console.Write("Size: ");
            string size = InputString();

            RAMList.Add(new RAM(Price, Supplier, Country, Name) { Type = type, Size = size });
        }
        else
        {
            Console.WriteLine($"\nNo more slots for RAM");
        }

        Main(myComputer);
    }

    // adding motherboard properties using the InputBaseProperties method to add base values
    public void AddMotherboard(Computer myComputer)
    {
        try
        {
            (string Name, string Supplier, string Country, int Price) = InputBaseProperties();

            Console.Write("Socket: ");
            string socket = CheckSocket(InputString());

            myComputer.Motherboard = new Motherboard(Price, Supplier, Country, Name)
            {
                Socket = socket
            };
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        Main(myComputer);
    }

    // adding GPU properties using the InputBaseProperties method to add base values
    public void AddGPU(Computer myComputer)
    {
        (string Name, string Supplier, string Country, int Price) = InputBaseProperties();

        Console.Write("Speed: ");
        string speed = InputString();
        Console.Write("Memory: ");
        int memory = InputInt();

        myComputer.GPU = new GPU(Price, Supplier, Country, Name)
        {
            Speed = speed,
            Memory = memory
        };

        Main(myComputer);
    }

    // adding CPU properties using the InputBaseProperties method to add base values
    public void AddCPU(Computer myComputer)
    {
        try
        {
            (string Name, string Supplier, string Country, int Price) = InputBaseProperties();

            Console.Write("Socket: ");
            string socket = CheckSocket(InputString());
            Console.Write("Cores: ");
            int cores = InputInt();
            Console.Write("Frequency: ");
            string frequency = InputString();

            myComputer.CPU = new CPU(Price, Supplier, Country, Name)
            {
                Socket = socket,
                Cores = cores,
                Frequency = frequency
            };
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Main(myComputer);
    }
    // check sockets CPU and Motherboard
    public string CheckSocket(string socket)
    {
        if (SocketType == socket || SocketType == null)
        {
            SocketType = socket;
            return socket;
        }
        else
        {
            throw new ArgumentException("Sockets on the motherboard and the CPU do not match.");
        }
    }

    // display all properties device computer
    public void DisplayInfoDevice(Computer myComputer)
    {
        Console.WriteLine($"RAM: {RAMList.Count}");
        Console.WriteLine($"RAM: {DriveList.Count}");

        foreach (var propertyInfo in myComputer.GetType().GetProperties())
        {
            if (propertyInfo.GetValue(myComputer) != null && propertyInfo.Name != "RAMList" && propertyInfo.Name != "DriveList")
            {
                Console.WriteLine($"{propertyInfo.Name} - added");
            }
            
        }

        Main(myComputer);
    }

    // method for input base properties devices of computer
    public (string Name, string Supplier, string Country, int Price) InputBaseProperties()
    {
        Console.Write("Name: ");
        string name = InputString();
        Console.Write("Supplier: ");
        string supplier = InputString();
        Console.Write("Country: ");
        string country = InputString();
        Console.Write("Price: ");
        int price = InputInt();

        return (name, supplier, country, price);
    }

    // method for input string 
    public string InputString()
    {   
        string text = Console.ReadLine();

        if (string.IsNullOrEmpty(text))
            {
            Console.WriteLine("Suddenly, you didn't write anything.");
            return InputString();
            }
        else
        {
            return text;
        }
    }

    // method for input number 
    public int InputInt()
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        catch
        {
            Console.WriteLine("Suddenly an error! You did not enter a number. Try again");
            return InputInt();
        }

    }
}
