using System;

class Program
{
    static void Main()
    {
        // Array to store the numbers
        double[] numbers = new double[5];

        // Prompt the user to enter the numbers
        Console.WriteLine("Enter five numbers:");

        // Read the numbers from the user
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Calculate the sum of the numbers
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += numbers[i];
        }

        // Calculate the average
        double average = sum / 5;

        // Display the result
        Console.WriteLine($"The average of the five numbers is: {average}");

        // Wait for the user to press a key before closing the console window
        Console.ReadKey();
    }
}
