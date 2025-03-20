using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeAppleChallenge
{

    public struct point
    {
        public int s;
        public int t;
        public int a;
        public int b;
        public List<int> apples;
        public List<int> oranges;

        public point(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            this.s = s;
            this.t = t;
            this.a = a;
            this.b = b;
            this.apples = apples;
            this.oranges = oranges;
        }
    }
    class OrangeAppleCalculator: IOrangeApple
    {
        
        public int GetCountOfApples(point p)
        {
            p = new point() { s = 7, t = 10, a = 4, b = 12, apples = new List<int> { 2, 3, -4 }, oranges = new List<int> { 3, -2, -4 } };

            int CountNoOfApples = 0;
            var storeResult = new List<int>();
            int addedApples;

            for (var item = 0; item < p.apples.Count; item++)
            {
                addedApples = 0;
                addedApples = p.a + p.apples[item];
                storeResult.Add(addedApples);
            }

            foreach(var apples in storeResult)
            { 
                Console.WriteLine("Apples" + apples);

                if (apples > p.a)
                {
                    CountNoOfApples++;
                }
            }
            return CountNoOfApples;
        }

        public int GetCountOfOranges(point p)
        {
            p = new point() { s = 7, t = 10, a = 4, b = 12, apples = new List<int> { 2, 3, -4 }, oranges = new List<int> { 3, -2, -4 } };
            int CountNoOfOranges = 0;
            var storeResult = new List<int>();
            int addedOranges;
            for (var item = 0; item < p.oranges.Count; item++)
            {
                addedOranges = 0;
                addedOranges = p.b + p.oranges[item];
                storeResult.Add(addedOranges);
            }
            foreach (var oranges in storeResult)
            {
                Console.WriteLine("Oranges: " + oranges);
                if (oranges > p.b)
                {
                    CountNoOfOranges++;
                }
            }
            return CountNoOfOranges;
        }
    }

    public class ImplementprintFruits: IprintFruits
    {

        public void displayFruits(IOrangeApple orangeApple)
        {
            point p = new point() { s = 7, t = 10, a = 4, b = 12, apples = new List<int> { 2, 3, -4 }, oranges = new List<int> { 3, -2, -4 } }; ;
            var resultList = new List<int>();  
            var Apples = orangeApple.GetCountOfApples(p);
            var Oranges = orangeApple.GetCountOfOranges(p);

            Console.WriteLine("no of apples: " + Apples);
            Console.WriteLine("no of Oranges: " + Oranges);

            resultList.Add(Apples);
            resultList.Add(Oranges);

            foreach(var fruits in resultList)
            {
                Console.WriteLine(fruits);
            }

        }
    }

    public class ProcessAll
    {
        private readonly IOrangeApple orangeApple;
        private readonly IprintFruits printFruits;

        public ProcessAll(IOrangeApple orangeApple, IprintFruits printFruits)
        {
            this.orangeApple = orangeApple;
            this.printFruits = printFruits;
        }

        public void Run()
        {
            printFruits.displayFruits(orangeApple);
        }
    }
}
