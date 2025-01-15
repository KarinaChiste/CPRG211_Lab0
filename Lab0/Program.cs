// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
 *CPRG 211 Lab 0 Activity
 * Author: Karina Chiste
 * When: Winter 2025
 */

// get low and high int numbers
//low must be positive
// high must be greater than low

using Lab0;

int low, high;
int diff; // difference between low and high

low = Utilities.GetPositiveInt("low number");

high = Utilities.GetIntInRange("high number", low + 1, Int32.MaxValue);

diff = high - low;

Console.WriteLine($"The low number: {low}");
Console.WriteLine($"The high number: {high}");

Console.WriteLine($"The difference between {low} and {high} is {diff}");


// create an array to hold numbers between low and high
int[] numbers = new int[diff + 1]; // size of the array
for (int i = 0; i<= diff; i++) // i is the index 
{
    numbers[i] = low + i;
}

Console.WriteLine("Numbers in the array");
for (int i = 0;i<= diff; i++)
{
    Console.WriteLine(numbers[i]);
}

//create a file name "number.txt" and write to it the numbers from the array in reverse order
StreamWriter streamWriter = File.CreateText("numbers.txt"); // located in the same folder as the .exe file
for (int i = numbers.Length - 1; i >= 0; i--)
{
    streamWriter.WriteLine(numbers[i]);
}
streamWriter.Close(); // important to finalize the writing
Console.WriteLine("File Written");


// determine prime numbers
Console.WriteLine("Prime Numbers: ");
for (int i = 0; i<= numbers.Length -1; i++)
{
    Utilities.GetPrimeNumber(numbers[i]);
}