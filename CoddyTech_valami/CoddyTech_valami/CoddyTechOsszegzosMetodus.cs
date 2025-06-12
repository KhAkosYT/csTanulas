/*
 
Write a program that gets one input, a number. 
The input number indicates how many times to execute the below method. 

Create a method that calculates the sum of all of the numbers between 1 and 1000 (including) 
and prints it, name the method however you like.

 */

using System;

public class CoddyTechOsszegzosMetodus
{
    // Method declaration
    public static void SumNumbers()
    {
        int res = 0;
        for (int i = 1; i <= 1000; i++)
        {
            res += i;
        }
        Console.WriteLine(res);
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        // Call the method n times
        for (int i = 0; i < n; i++)
        {
            SumNumbers();
        }
    }
}