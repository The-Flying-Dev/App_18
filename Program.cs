namespace CurrencyConverter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Currency Converter");
        Console.WriteLine(
            "Press 'p' to convert from British Pounds to Euros or 'e' to convert from Euros to British Pounds."
        );
        string choice = Console.ReadLine();

        if (choice == "p")
        {
            Console.WriteLine("Enter the amount in British Pounds.");
            float pounds = float.Parse(Console.ReadLine()); // Using Parse to convert into a float

            float euros = pounds * 1.16f; // f as the suffix, used for floats

            // ToString with argument used for string formatting with 2 decimal places
            Console.WriteLine("The amount in euros is " + euros.ToString("0.00") + ".");
        }
        else
        {
            Console.WriteLine("Enter the amount in Euros.");
            float euros = float.Parse(Console.ReadLine());

            float pounds = euros / 1.16f; // f as the suffix, used for floats

            // ToString with argument used for string formatting with 2 decimal places
            Console.WriteLine("The amount in pounds is " + pounds.ToString("0.00") + ".");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadLine();
    }
}
