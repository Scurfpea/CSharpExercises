namespace AbilityScoreTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DividedBy = ReadDouble(calculator.DividedBy, "Divided by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "AddAmount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }
        }

        private static double ReadDouble(double lastUsedValue, string promt)
        {
            Console.Write(promt + "[" + lastUsedValue + "]: ");
            string line = Console.ReadLine();

            if (double.TryParse(line, out double value)) 
            {
                Console.WriteLine("     using value " + value);
            return value;
            }
            else
            {
                Console.WriteLine("     using default value " + lastUsedValue);
                return lastUsedValue; 
            }
        }

        private static int ReadInt(int lastUsedValue, string promt)
        {
            Console.Write(promt + "[" + lastUsedValue + "]: ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out int value))
            {
                Console.WriteLine("     using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine("     using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }
    }
}