using System;

public class CoddyTechMethods{
    // Create the DisplayMessage method here
    public static void DisplayMessage(string message, int repeatCount = 1){
        for (int i = 0; i < repeatCount; i++){
            Console.WriteLine(message);
        }
    }

    public static void Main(string[] args){
        DisplayMessage("Hello!");
        DisplayMessage("Coddy", 3);
    }
}