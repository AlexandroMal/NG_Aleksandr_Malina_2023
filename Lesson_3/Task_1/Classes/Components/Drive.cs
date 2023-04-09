using System.Runtime.Serialization;
using Task_1.Abstraction;

namespace Task_1.Classes.Components;

public class Drive : Detail
{
    public string? Size { get; set; }
    public string? Speed { get; set; }
    public string? Type { get; set; }
    public string? InterfaceType { get; set; }
    public string? Lifetime { get; set; } 

    public Drive
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
