using Task_1.Abstraction;

namespace Task_1.Classes.Components;

public class Motherboard : Detail
{
    public string? Socket { get; set; }

    public Motherboard
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