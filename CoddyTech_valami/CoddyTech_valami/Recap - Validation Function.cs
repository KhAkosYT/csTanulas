using System;

public class Recap_Validation_Function{
    public static bool is_valid(string username, string password)
    {
        // Write your code below
        if (((username == "user") && (password == "qweasd")) || (username == "admin"))
        {
            return true;
        }
        else
        {
            return false;
        }


    }

    public static void Main(string[] args)
    {
        string user = Console.ReadLine();
        string pass = Console.ReadLine();
        bool res = is_valid(user, pass);
        Console.WriteLine(res);
    }
}