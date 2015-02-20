/*
 * Problem 1. Say Hello
 * Write a method that asks the user for his name and prints �Hello, <name>�
 * Write a program to test this method.
 */

using System;

class SayHello
{
    static void Main()
    {
        Console.WriteLine("What is you name?");
        string name = Console.ReadLine();

        SayHallo(name);

    }

    private static void SayHallo(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}