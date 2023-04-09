
using Task_1.Abstraction;

namespace Task_1.Classes.Components;

public class GPU : Detail
{
    public int Memory { get; set; }
    public string Speed { get; set; }

    public GPU
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