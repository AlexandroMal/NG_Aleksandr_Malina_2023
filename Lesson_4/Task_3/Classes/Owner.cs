using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3.Interfaces;

namespace Task_3.Classes
{
    public class Owner : Administator, IOwner
    {
        public void DeleteAll()
        {
            Console.WriteLine("All files deleted!");
        }
    }
}
