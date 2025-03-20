using OrangeAppleChallenge;

public class program
{
    public static void Main()
    {
        IOrangeApple orangeApple = new OrangeAppleCalculator();
        IprintFruits printFruits = new ImplementprintFruits();

        ProcessAll process = new ProcessAll(orangeApple, printFruits);

        process.Run();

        Console.ReadKey();
    }
}
