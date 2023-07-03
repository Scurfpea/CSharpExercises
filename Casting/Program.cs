namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float myFloatValue = 10;
            int myIntValue = (int)myFloatValue;

            Console.WriteLine("myIntValue is " + myIntValue);


            //Automatically converts to float
            int myInt = 36;
            float myFloat = 16.4F;
            myFloat = myInt + myFloat;

            Console.WriteLine("myFloat is " + myFloat);
        }
    }
}