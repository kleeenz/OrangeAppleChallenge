using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeAppleChallenge
{
    public interface IOrangeApple
    {
        public int GetCountOfApples(point points);
        public int GetCountOfOranges(point points);
    }

    public interface IprintFruits
    {
        public void displayFruits(IOrangeApple orangeApple);
    }
}
