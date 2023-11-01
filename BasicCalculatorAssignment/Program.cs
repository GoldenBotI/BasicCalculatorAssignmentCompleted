namespace BasicCalculatorAssignment
{
    internal class Program
    {
        // The goal of this assignment is to learn how to create and use methods in our code
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            int command = 0;
            // Declare your methods/functions here
            double Addition(double a, double b)
            {
                return (a + b);
            }
            double Substraction(double a, double b)
            {
                return (a - b);
            }
            double Multiplication(double a, double b)
            {
                return (a * b);
            }
            double Division(double a, double b)
            {
                if (b == 0)
                {
                    Console.WriteLine("Sorry, we can't properly divide by 0, and because of that, the result of this division will be set to 0.");
                    return 0;
                }
                else
                    return (a / b);
            }
            while (true)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an operation: ");

                // Task 1. Read choice input and assing it to new int variable
                command = Convert.ToInt32(Console.ReadLine());
                // Task 2. Check if user selected choice 5. If so then exit the loop
                if (command == 5)
                {
                    break;
                }
                Console.Write("Enter first number: ");
                double FirstN = Convert.ToInt32(Console.ReadLine());
                // Task 3. Get the first number and assing it to new double variable

                Console.Write("Enter second number: ");
                double SecondN = Convert.ToInt32(Console.ReadLine());
                // Task 4. Get the second number and assing it to new double variable

                // Task 5. Create double variable for default result value and assign it to be 0
                double result = 0;
                // Task 6. Handle choices using switch statement
                // Task 6.1 For each case create new function/method an call it inside the case
                //          - Case 1: Add 
                //          - Case 2: Subtract
                //          - Case 3: Multiply
                //          - Case 4: Divide, Note remeber to handle 0
                // Note: Think what the default choice should be
                // Note: Declare each case function/method outside Main method
                //       There is comment below where you can place your methods
                // Task 7. Print out the result
                switch (command)
                {
                    case 1:
                        Console.WriteLine($"Result of addition is {result = Addition(FirstN, SecondN)}");
                        break;
                    case 2:
                        Console.WriteLine($"Result of substraction is {result = Substraction(FirstN, SecondN)}");
                        break;
                    case 3:
                        Console.WriteLine($"Result of multilication is {result = Multiplication(FirstN, SecondN)}");
                        break;
                    case 4:
                        Console.WriteLine($"Result of division is {result = Division(FirstN, SecondN)}");
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Entered wrong operation number.");
                        break;
                }
            }
        }
    }
}