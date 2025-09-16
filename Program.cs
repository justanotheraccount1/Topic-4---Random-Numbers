namespace Topic_4___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxValue, minValue;
           
            Console.WriteLine("Please enter the minimum value:");
            while (!Int32.TryParse(Console.ReadLine(), out minValue))
            {
                Console.WriteLine("That is an invalid input. Try Again:");

            }
            Console.WriteLine();
            Console.WriteLine("Please enter the maximum value:");
            while (!Int32.TryParse(Console.ReadLine(), out maxValue) || maxValue <= minValue)
            {
                Console.WriteLine("That is an invalid input. Try Again:");

            }
            Console.WriteLine();
            Console.WriteLine($"A number between {minValue} and {maxValue} will now be generated...");
            Console.WriteLine($"Your number is {random.Next(minValue, (maxValue + 1))}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            int die1, die2;
            Console.Write("Press ENTER to roll the first die:");
            Console.ReadLine();
            die1 = random.Next(7);
            Console.WriteLine($"You rolled a {die1}");
            Console.WriteLine();
            Console.Write("Press ENTER to roll the second die:");
            Console.ReadLine();
            die2 = random.Next(7);
            Console.WriteLine($"You rolled a {die2}");
            Console.WriteLine();
            Console.WriteLine($"The sum of the two dice was {die1 + die2}");


            //Console.WriteLine($"Three decimal values between {minValue} and {maxValue} will now be generated...");
            //Console.WriteLine($"Your numbers are {random.NextDouble(minValue, (maxValue + 1))}");

        }
    }
}
