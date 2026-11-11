namespace Calculator_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                PrintMenu();
                Console.Write("Choose an operation: ");
                string? operationNum = Console.ReadLine();           


                    switch (operationNum)
                    {
                        // Addition
                        case "1":
                            decimal add1 = GetUserNum(1);
                            decimal add2 = GetUserNum(2);

                            Console.WriteLine($"{add1} + {add2} = {Add(add1, add2)}");
                            Console.WriteLine();

                            break;

                        // Subtraction
                        case "2":
                            decimal sub1 = GetUserNum(1);
                            decimal sub2 = GetUserNum(2);

                            Console.WriteLine($"{sub1} - {sub2} = {Subtract(sub1, sub2)}");
                            Console.WriteLine();

                            break;

                        // Multiplication
                        case "3":
                            decimal mult1 = GetUserNum(1);
                            decimal mult2 = GetUserNum(2);

                            Console.WriteLine($"{mult1} * {mult2} = {Multiply(mult1, mult2)}");
                            Console.WriteLine();

                            break;

                        // Division
                        case "4":
                            decimal div1 = GetUserNum(1);
                            decimal div2 = GetUserNum(2);

                            if (div2 == 0)
                            {
                                Console.WriteLine("Can't divide by zero, try again.");
                                Console.WriteLine();
                                continue;
                            }

                            Console.WriteLine($"{div1} / {div2} = {Divide(div1, div2)}");
                            Console.WriteLine();

                            break;

                        // Quit
                        case "5":
                            Console.WriteLine("You have quit the program.");
                            return;

                        default:
                            Console.WriteLine("Please choose 1, 2, 3, 4 or 5.");
                            break;
                    }
                

            }


        }

        static decimal GetUserNum(int numberPosition)
        {
            while (true)
            {
                Console.Write($"Enter number {numberPosition}: ");
                string? numX = Console.ReadLine();

                if (decimal.TryParse(numX, out decimal result))
                {
                    return result; // Valid: leave the method with the value
                }
                else
                {
                    // Not valid, no return, so the while(true) loop repeats
                    Console.WriteLine("Error: please enter a  number");
                }
            }
            

        }

        static void PrintMenu()
        {
            Console.WriteLine("CALCULATOR APP");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Quit");

            Console.WriteLine();
        }

        // Operation methods
        static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        static decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }

        static decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        static decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
