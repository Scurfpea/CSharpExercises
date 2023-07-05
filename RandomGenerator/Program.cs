namespace RandomGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomInt = random.Next();
            Console.WriteLine(randomInt);

            int zeroToNine = random.Next(10); //generates a random number between 0-9
            Console.WriteLine(zeroToNine);

            int dieRoll = random.Next(1, 7); //generates a random number between 1-6
            Console.WriteLine(dieRoll);

            double randomDouble = random.NextDouble();
            Console.WriteLine(randomDouble*100);

            Console.WriteLine((float)randomDouble* 100F);
            Console.WriteLine((decimal)randomDouble*100M);

            int zeroOrOne = random.Next(2); //generates a random number either 0 or 1.
            bool coinFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine(coinFlip);
        }
    }
}