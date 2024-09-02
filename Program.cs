namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;

            string answer;

            Console.WriteLine("Hello, welcome to the calculator program");

            Console.WriteLine("Please enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the type of operation:");
            Console.WriteLine("a - addition");
            Console.WriteLine("s - subtraction");
            Console.WriteLine("m - multiplication");
            Console.WriteLine("d - division");
            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s") 
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thank you for using the program!");

            Console.ReadKey();
        }
    }
}
