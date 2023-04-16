using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3.Interfaces;

namespace Task_3.Classes
{
    public class User : IUser
    {
        public void OpenFile()
        {
            Console.WriteLine("File open!");
        }

        public void CloseFile()
        {
            Console.WriteLine("File close!");
        }

        public void DownloadFile()
        {
            Console.WriteLine("File download!");
        }
    }
}
