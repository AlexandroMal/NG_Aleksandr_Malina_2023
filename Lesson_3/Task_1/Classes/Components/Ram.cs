using Task_1.Abstraction;

namespace Task_1.Classes.Components;

public class RAM : Detail
{
    public string Type { get; set; }
    public string Size { get; set; }

    public RAM
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

