using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3.Interfaces;

namespace Task_3.Classes
{
    public class Administator : User, IAdministrator
    {
        public void DeleteFile()
        {
            Console.WriteLine("File delete!");
        }

        public void RenameFile()
        {
            Console.WriteLine("File renamed!");
        }
    }
}
