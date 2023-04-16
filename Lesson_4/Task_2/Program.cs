using Open_Closed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

List<MagicClass> ListMagic = new List<MagicClass>()
{
    new FireMagic(),
    new WaterMagic()
};

int userMagic = 50000000;
var magic = new MagicClass();

magic.MagicChoice(userMagic, ListMagic);

namespace Open_Closed
{
    public class MagicClass
    {
        protected string Name { get; set; }
        public int CountMagic { get; set; }

        public MagicClass() 
        {
        }

        public string DisplayMessage()
        {
            return($"Wow, you have {CountMagic} powers, that means you're a {Name} mage.");
        }

        public void MagicChoice(int userMagic, List<MagicClass> ListMagic)
        {
            foreach (var magic in ListMagic)
            {
                if (magic.CountMagic == userMagic)
                {
                    Console.Write(magic.DisplayMessage());
                }
            }
        }

    }

    public class FireMagic : MagicClass
    {
        public FireMagic(string name = "Fire", int countMagic = 150)
        {
            this.Name = name;
            this.CountMagic = countMagic;
        }

    }

    public class WaterMagic : MagicClass
    {
        public WaterMagic(string name = "Water", int countMagic = 50000000)
        {
            this.Name = name;
            this.CountMagic = countMagic;
        }

    }
}