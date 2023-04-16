using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Interfaces;

namespace Task_4.Vehicles
{
    public class Airplane : Vehicles, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("It's flying!");
        }
    }
}
