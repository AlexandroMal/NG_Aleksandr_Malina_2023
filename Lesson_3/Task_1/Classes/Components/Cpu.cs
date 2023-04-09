using Task_1.Abstraction;

namespace Task_1.Classes.Components;

public class CPU : Detail
{
    public string Socket { get; set; }

    public int Cores { get; set;}

    public string Frequency { get; set; }

    public CPU
    (
        int price,
        string supplier,
        string country,
        string name
    )

    : base(price, supplier, country, name)
    {

    }


}