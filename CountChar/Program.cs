internal class Program
{
    private static void Main(string[] args)
    {
        // Step 1: Declare a string and assign a value to it
        string str = "Hello, World!";

        // Step 2: Declare a character variable and assign or input a value from the keyboard
        Console.Write("Enter a character: ");
        char character = Convert.ToChar(Console.ReadLine());

        // Step 3: Declare a variable named count and assign the value 0 to it to store the count of the character in the string
        int count = 0;

        // Step 4: Use a loop to iterate through each character in the string and count occurrences
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == character)
            {
                count++;
            }
        }

        // Step 5: Print out the count value
        Console.WriteLine($"The character '{character}' appears {count} time(s) in the string.");
    }
}