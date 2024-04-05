internal class Program
{
    static void Main(string[] args)
    {
        // Valeur Minimum : 
        Console.Write("Limit1: ");
        string? min = Console.ReadLine();
        if (string.IsNullOrEmpty(min))
        {
            Console.WriteLine("minimum invalid, end of the program.");
            return;
        }

        if (int.TryParse(min, out int min_value))
        {
            // Valeur Maximum : 
            Console.Write("Limit2: ");
            string? max = Console.ReadLine();
            if (string.IsNullOrEmpty(max))
            {
                Console.WriteLine("maximum invalid, end of the program.");
                return;
            }

            if (int.TryParse(max, out int max_value))
            {
                // Valeur Integer : 
                Console.Write("Integer: ");
                string? value = Console.ReadLine();
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("integer invalid, end of the program.");
                    return;
                }

                if (int.TryParse(value, out int integer_val))
                {

                    // Check if the min value is sup than the max value then we born to min value : 
                    if (min_value > max_value)
                    {
                        Console.WriteLine($"You have entered {integer_val} which is greater than {min_value} which is the minimum.");
                        integer_val = min_value;
                    }
                    // Born to min value :
                    else if (integer_val < min_value)
                    {
                        Console.WriteLine($"You have entered {integer_val} which is lower than {min_value} which is the minimum.");
                        integer_val = min_value;
                    }
                    // Born to max value :
                    else if (integer_val > max_value)
                    {
                        Console.WriteLine($"You have entered {integer_val} which is greater than {max_value} which is the maximum.");
                        integer_val = max_value;
                    }

                    // Show the res : 
                    Console.WriteLine($"Resulting integer: {integer_val}");
                }
            }
        }

        Console.ReadKey();
    }
}