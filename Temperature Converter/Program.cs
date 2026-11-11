namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;
            while (!gameOver)
            {
                // Ask the user which conversion method they want to do
                Console.Write("Please select an option.\n1. Farenheit to Degree Celsius\n2. Degree Celsius to Farenheit\nOption: ");
                string? temperatureOption = Console.ReadLine();

                // Convert the temperature based on chosen option
                ConvertTemperature(temperatureOption);

                while (true)
                {
                    Console.Write("Would you like to convert again? (Y/N): ");
                    string? again = Console.ReadLine();

                    if (again == "N")
                    { 
                        gameOver = true; // User selected N
                        break;
                    } 
                    else if (again == "Y")
                    { 
                        break; // User selects Y
                    }
                    else
                    { // User put invalid selection
                        Console.WriteLine("Invalid selection, try again");
                    }
                }
            }


        }

        static void ConvertTemperature(string temperatureOption) {
            // Convert the temperature based on chosen option
            decimal userTemperature;
            switch (temperatureOption)
            {
                // Farenheit to Celsius
                case "1":
                    userTemperature = GetUserTemperature();
                    Console.WriteLine($"{userTemperature}°F is {FahrenheitToCelsius(userTemperature)}°C");
                    break;

                // Celsius to Farenheit
                case "2":
                    userTemperature = GetUserTemperature();
                    Console.WriteLine($"{userTemperature}°C is {CelsiusToFahrenheit(userTemperature)}°F");
                    break;

                default:
                    Console.WriteLine("Error, invalid input.");
                    break;
            }
        }

        static decimal GetUserTemperature()
        {
            while (true)
            {
                Console.Write("Enter a temperature to be converted: ");
                string? input = Console.ReadLine();

                if (decimal.TryParse(input, out decimal temperature))
                {
                    // temperature now holds the real number, use it
                    return temperature;
                } else
                {
                    // failure: input wasn't a valid number, no crash, just re-ask
                    Console.WriteLine("That's not a valid number, try again.");
                }
            }

            /* Previous code:
            Console.Write("Enter temperature to be converted: ");
            string temperature = Console.ReadLine();
            return ParseTemperature(temperature);
            */
        }

        // Converting from farenheit to celsius
        static decimal FahrenheitToCelsius(decimal temperature) {
            decimal result = (temperature - 32) * 5 / 9;
            return Math.Round(result, 3);
        }

        // Converting from celsius to farenheit
        static decimal CelsiusToFahrenheit(decimal temperature)
        {
            decimal result = (temperature * 9 / 5) + 32;
            return Math.Round(result, 3);
        }
    }
}
