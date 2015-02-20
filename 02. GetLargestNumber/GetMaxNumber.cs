/*
 * Problem 2. Get largest number
 * Write a method GetMax() with two parameters that returns the larger of two integers.
 * Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
 */

using System;

class GetMaxNumber
{
    static void Main()
    {
        Console.WriteLine("This program find maximun of three numbers."); 
        Console.Write("Please enter the first number: x= ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Please enter the first number: y= "); 
        int y = int.Parse(Console.ReadLine());
        Console.Write("Please enter the first number: z= "); 
        int z = int.Parse(Console.ReadLine());

        int result = GetMax(x, GetMax(y,z));

        Console.WriteLine("The maximun of the three numbers is: {0}", result);
    }

    private static int GetMax(int firstNumber, int secondNumber)
    {
        int maxNumber = Math.Max(firstNumber, secondNumber);
        return maxNumber;
    }
}