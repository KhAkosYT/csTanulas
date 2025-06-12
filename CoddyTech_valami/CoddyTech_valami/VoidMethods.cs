using System;

public class VoidMethods{
    public static void PrintNTimes(string message, int n = 1)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(message);
        }
    }

    public static void Main(string[] args)
    {
        string messageInput = Console.ReadLine();
        int n_times = int.Parse(Console.ReadLine());

        PrintNTimes(messageInput, n_times);
    }
}