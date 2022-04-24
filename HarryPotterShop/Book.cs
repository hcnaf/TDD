using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterShop
{
    public class Book
    {
        public BookPart BookPart { get; set; }
    }

    public enum BookPart
    {
        PhilosophersStone = 1,
        ChamblerOfSecrets,
        PrisonerOfAzkaban,
        GobletOfFire,
        OrderOfThePhoenix
    }
}
