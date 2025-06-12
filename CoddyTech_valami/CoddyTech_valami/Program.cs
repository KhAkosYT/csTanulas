using System;

public class Program
{
    public static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string[] arr = text.Split(',');
        // Write your code below
        string[] arr2 = new string[arr.Length];
        int seged = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length > 5)
            {
                Console.WriteLine(string.Join(", ", arr[i]));
            }
        }

    }
}